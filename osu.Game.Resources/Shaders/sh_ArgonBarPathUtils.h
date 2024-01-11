#ifndef ARGON_BAR_PATH_UTILS_H
#define ARGON_BAR_PATH_UTILS_H

#undef PI
#define PI 3.1415926536

#undef HALF_PI
#define HALF_PI 1.57079632679

#undef TWO_PI
#define TWO_PI 6.28318530718

highp float dstToLine(highp vec2 start, highp vec2 end, highp vec2 pixelPos)
{
    highp float lineLength = distance(end, start);

    if (lineLength < 0.001)
        return distance(pixelPos, start);

    highp vec2 a = (end - start) / lineLength;
    highp vec2 closest = clamp(dot(a, pixelPos - start), 0.0, distance(end, start)) * a + start; // closest point on a line from given position
    return distance(closest, pixelPos);
}

highp float dstToArc(highp vec2 arcPos, highp float radius, highp float angle, highp vec2 pixelPos, highp float rotation)
{
    pixelPos -= arcPos;

    highp float pixelAngle = atan(-pixelPos.y, -pixelPos.x) - HALF_PI + rotation;
    pixelAngle += float(pixelAngle < 0.0) * TWO_PI;
    highp vec2 cs = vec2(cos(pixelAngle - HALF_PI), sin(pixelAngle - HALF_PI));
    pixelPos = cs * vec2(distance(pixelPos, vec2(0.0)));

    pixelPos.x = abs(pixelPos.x);
    highp vec2 sc = vec2(sin(angle * 0.5), cos(angle * 0.5));
    return ((sc.y * pixelPos.x > sc.x * pixelPos.y) ? length(pixelPos - sc * radius) : abs(length(pixelPos) - radius));
}

highp float dstToTopLine(
    highp float startProgress,
    highp float endProgress,
    mediump vec2 p1,
    mediump vec2 arc1Start,
    highp float progressArc1Start,
    mediump vec2 pixelAbsolutePos)
{
    if (startProgress > progressArc1Start)
        return 1000.0;

    endProgress = min(endProgress, progressArc1Start);

    mediump vec2 startPos = vec2(p1.x + (arc1Start.x - p1.x) * startProgress / progressArc1Start, p1.y);
    mediump vec2 endPos = vec2(p1.x + (arc1Start.x - p1.x) * endProgress / progressArc1Start, p1.y);
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float dstToTopArc(
    highp float startProgress,
    highp float endProgress,
    mediump vec2 arc1Start,
    mediump vec2 arc1End,
    highp float progressArc1Start,
    highp float progressArc1End,
    mediump vec2 arcCentre,
    highp float slashAngle,
    highp float fullArcAngle,
    mediump vec2 pixelAbsolutePos)
{
    if (startProgress > progressArc1End || endProgress < progressArc1Start)
        return 1000.0;

    startProgress = max(startProgress, progressArc1Start);
    endProgress = min(endProgress, progressArc1End);

    highp float currentArcAngle = fullArcAngle * (endProgress - startProgress) / (progressArc1End - progressArc1Start);
    highp float rotationOffset = fullArcAngle * (startProgress - progressArc1Start) / (progressArc1End - progressArc1Start);
    return dstToArc(arcCentre, arcCentre.y - arc1Start.y, currentArcAngle, pixelAbsolutePos, HALF_PI + slashAngle * 0.5 + (fullArcAngle - currentArcAngle) * 0.5 - rotationOffset);
}

highp float dstToSlash(
    highp float startProgress,
    highp float endProgress,
    mediump vec2 arc1End,
    mediump vec2 arc2Start,
    highp float progressArc1End,
    highp float progressArc2Start,
    mediump vec2 pixelAbsolutePos)
{
    if (startProgress > progressArc2Start || endProgress < progressArc1End)
        return 1000.0;

    startProgress = max(startProgress, progressArc1End);
    endProgress = min(endProgress, progressArc2Start);

    mediump vec2 startPos = mix(arc1End, arc2Start, (startProgress - progressArc1End) / (progressArc2Start - progressArc1End));
    mediump vec2 endPos = mix(arc1End, arc2Start, (endProgress - progressArc1End) / (progressArc2Start - progressArc1End));
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float dstToBottomArc(
    highp float startProgress,
    highp float endProgress,
    mediump vec2 arc2Start,
    mediump vec2 arc2End,
    highp float progressArc2Start,
    highp float progressArc2End,
    mediump vec2 arcCentre,
    highp float slashAngle,
    highp float fullArcAngle,
    mediump vec2 pixelAbsolutePos)
{
    if (startProgress > progressArc2End || endProgress < progressArc2Start)
        return 1000.0;

    startProgress = max(startProgress, progressArc2Start);
    endProgress = min(endProgress, progressArc2End);

    highp float currentArcAngle = fullArcAngle * (endProgress - startProgress) / (progressArc2End - progressArc2Start);
    highp float rotationOffset = fullArcAngle * (startProgress - progressArc2Start) / (progressArc2End - progressArc2Start);
    return dstToArc(arcCentre, arc2End.y - arcCentre.y, currentArcAngle, pixelAbsolutePos, slashAngle * 0.5 + PI + HALF_PI - (fullArcAngle - currentArcAngle) * 0.5 + rotationOffset);
}

highp float dstToBottomLine(
    highp float startProgress,
    highp float endProgress,
    mediump vec2 arc2End,
    mediump vec2 p4,
    highp float progressArc2End,
    mediump vec2 pixelAbsolutePos)
{
    if (endProgress < progressArc2End)
        return 1000.0;

    startProgress = max(startProgress, progressArc2End);

    mediump vec2 startPos = vec2(arc2End.x + (p4.x - arc2End.x) * (startProgress - progressArc2End) / (1.0 - progressArc2End), p4.y);
    mediump vec2 endPos = vec2(arc2End.x + (p4.x - arc2End.x) * (endProgress - progressArc2End) / (1.0 - progressArc2End), p4.y);
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float getBarTexturePosition(mediump vec2 size, highp float startProgress, highp float endProgress, mediump float pathRadius, mediump float padding, mediump vec2 pixelAbsolutePos)
{
    mediump vec2 p1 = vec2(min(padding, size.x * 0.5), min(padding, size.y * 0.5));
    mediump vec2 p4 = vec2(max(size.x - padding, size.x * 0.5), max(size.y - padding, size.y * 0.5));

    if (p4.y == p1.y)
    {
        return dstToLine(vec2(p1.x + startProgress * (p4.x - p1.x), p1.y), vec2(p1.x + endProgress * (p4.x - p1.x), p1.y), pixelAbsolutePos);
    }

    mediump float topWidth = max(size.x - padding - 70.0, padding) - p1.x;
    mediump float bottomWidth = p4.x - max(size.x - padding - 40.0, padding);

    if (topWidth < bottomWidth)
    {
        mediump float newWidth = (topWidth + bottomWidth) * 0.5;
        topWidth = newWidth;
        bottomWidth = newWidth;
    }

    mediump vec2 p2 = vec2(p1.x + topWidth, p1.y);
    mediump vec2 p3 = vec2(p4.x - bottomWidth, p4.y);

    mediump float slashLength = distance(p2, p3);
    mediump float roundOffset = min(topWidth, 10.0);

    highp float slashAngle = atan(p2.y - p3.y, p2.x - p3.x) - HALF_PI;
    slashAngle += float(slashAngle < 0.0) * TWO_PI;
    slashAngle = TWO_PI - HALF_PI - slashAngle;
    
    mediump float arcAngle = (HALF_PI - slashAngle * 0.5) * 2.0;
    mediump float arcRadius = roundOffset * tan(slashAngle * 0.5);

    mediump vec2 arc1Start = vec2(p2.x - roundOffset, p2.y);
    mediump vec2 arc1End = mix(p2, p3, roundOffset / slashLength);
    mediump vec2 arc2Start = mix(p2, p3, 1.0 - roundOffset / slashLength);
    mediump vec2 arc2End = vec2(p3.x + roundOffset, p3.y);

    mediump float length1 = arc1Start.x - p1.x;
    mediump float arcLength = arcAngle * arcRadius;
    mediump float length2 = distance(arc1End, arc2Start);
    mediump float length3 = p4.x - arc2End.x;
    
    mediump float totalLength = length1 + length2 + length3 + arcLength * 2.0;
    mediump float minDst = 1000.0;

    highp float progressArc1Start = length1 / totalLength;
    highp float progressArc1End = (length1 + arcLength) / totalLength;
    highp float progressArc2Start = (length1 + arcLength + length2) / totalLength;
    highp float progressArc2End = (length1 + length2 + arcLength * 2.0) / totalLength;
    mediump vec2 arc1Centre = vec2(p2.x - roundOffset, p2.y + arcRadius);
    mediump vec2 arc2Centre = vec2(p3.x + roundOffset, p3.y - arcRadius);

    minDst = min(minDst, dstToTopLine(startProgress, endProgress, p1, arc1Start, progressArc1Start, pixelAbsolutePos));
    minDst = min(minDst, dstToTopArc(startProgress, endProgress, arc1Start, arc1End, progressArc1Start, progressArc1End, arc1Centre, slashAngle, arcAngle, pixelAbsolutePos));
    minDst = min(minDst, dstToSlash(startProgress, endProgress, arc1End, arc2Start, progressArc1End, progressArc2Start, pixelAbsolutePos));
    minDst = min(minDst, dstToBottomArc(startProgress, endProgress, arc2Start, arc2End, progressArc2Start, progressArc2End, arc2Centre, slashAngle, arcAngle, pixelAbsolutePos));
    minDst = min(minDst, dstToBottomLine(startProgress, endProgress, arc2End, p4, progressArc2End, pixelAbsolutePos));
    
    return minDst;
}

#endif
