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
    return (sc.y * pixelPos.x > sc.x * pixelPos.y) ? length(pixelPos - sc * radius) : abs(length(pixelPos) - radius);
}

highp float dstToTopLine(
    highp vec2 progressRange,
    mediump vec2 p1,
    mediump vec2 arc1Start,
    highp float progressArc1Start,
    mediump vec2 pixelAbsolutePos)
{
    if (progressRange.x > progressArc1Start)
        return 1000.0;

    if (progressArc1Start < 0.001)
        return distance(pixelAbsolutePos, arc1Start);

    progressRange.y = min(progressRange.y, progressArc1Start);

    mediump vec2 startPos = mix(p1, arc1Start, progressRange.x / progressArc1Start);
    mediump vec2 endPos = mix(p1, arc1Start, progressRange.y / progressArc1Start);
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float dstToTopArc(
    highp vec2 progressRange,
    mediump float radius,
    highp float progressArc1Start,
    highp float progressArc1End,
    mediump vec2 arcCentre,
    highp float slashAngle,
    highp float fullArcAngle,
    mediump vec2 pixelAbsolutePos)
{
    if (progressRange.x > progressArc1End || progressRange.y < progressArc1Start)
        return 1000.0;

    if (progressArc1End - progressArc1Start < 0.001)
        return distance(pixelAbsolutePos, vec2(arcCentre.x, arcCentre.y - radius));

    progressRange.x = max(progressRange.x, progressArc1Start);
    progressRange.y = min(progressRange.y, progressArc1End);

    highp float currentArcAngle = fullArcAngle * (progressRange.y - progressRange.x) / (progressArc1End - progressArc1Start);
    highp float rotationOffset = fullArcAngle * (progressRange.x - progressArc1Start) / (progressArc1End - progressArc1Start);
    return dstToArc(arcCentre, radius, currentArcAngle, pixelAbsolutePos, HALF_PI + (slashAngle + fullArcAngle - currentArcAngle) * 0.5 - rotationOffset);
}

highp float dstToSlash(
    highp vec2 progressRange,
    mediump vec2 arc1End,
    mediump vec2 arc2Start,
    highp float progressArc1End,
    highp float progressArc2Start,
    mediump vec2 pixelAbsolutePos)
{
    if (progressRange.x > progressArc2Start || progressRange.y < progressArc1End)
        return 1000.0;

    progressRange.x = max(progressRange.x, progressArc1End);
    progressRange.y = min(progressRange.y, progressArc2Start);

    mediump vec2 startPos = mix(arc1End, arc2Start, (progressRange.x - progressArc1End) / (progressArc2Start - progressArc1End));
    mediump vec2 endPos = mix(arc1End, arc2Start, (progressRange.y - progressArc1End) / (progressArc2Start - progressArc1End));
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float dstToBottomArc(
    highp vec2 progressRange,
    mediump float radius,
    highp float progressArc2Start,
    highp float progressArc2End,
    mediump vec2 arcCentre,
    highp float slashAngle,
    highp float fullArcAngle,
    mediump vec2 pixelAbsolutePos)
{
    if (progressRange.x > progressArc2End || progressRange.y < progressArc2Start)
        return 1000.0;

    if (progressArc2End - progressArc2Start < 0.001)
        return distance(pixelAbsolutePos, vec2(arcCentre.x, arcCentre.y + radius));

    progressRange.x = max(progressRange.x, progressArc2Start);
    progressRange.y = min(progressRange.y, progressArc2End);

    highp float currentArcAngle = fullArcAngle * (progressRange.y - progressRange.x) / (progressArc2End - progressArc2Start);
    highp float rotationOffset = fullArcAngle * (progressRange.x - progressArc2Start) / (progressArc2End - progressArc2Start);
    return dstToArc(arcCentre, radius, currentArcAngle, pixelAbsolutePos, PI + HALF_PI + (slashAngle - fullArcAngle + currentArcAngle) * 0.5 + rotationOffset);
}

highp float dstToBottomLine(
    highp vec2 progressRange,
    mediump vec2 arc2End,
    mediump vec2 p4,
    highp float progressArc2End,
    mediump vec2 pixelAbsolutePos)
{
    if (progressRange.y < progressArc2End)
        return 1000.0;

    if (1.0 - progressArc2End < 0.001)
        return distance(pixelAbsolutePos, arc2End);

    progressRange.x = max(progressRange.x, progressArc2End);

    mediump vec2 startPos = mix(arc2End, p4, (progressRange.x - progressArc2End) / (1.0 - progressArc2End));
    mediump vec2 endPos = mix(arc2End, p4, (progressRange.y - progressArc2End) / (1.0 - progressArc2End));
    
    return dstToLine(startPos, endPos, pixelAbsolutePos);
}

highp float getBarTexturePosition(mediump vec2 size, highp vec2 progressRange, mediump float pathRadius, mediump vec2 pixelAbsolutePos)
{
    mediump vec2 p1 = vec2(min(pathRadius, size.x * 0.5), min(pathRadius, size.y * 0.5));
    mediump vec2 p4 = vec2(max(size.x - pathRadius, size.x * 0.5), max(size.y - pathRadius, size.y * 0.5));

    if (p4.y == p1.y)
    {
        return dstToLine(vec2(p1.x + progressRange.x * (p4.x - p1.x), p1.y), vec2(p1.x + progressRange.y * (p4.x - p1.x), p1.y), pixelAbsolutePos);
    }

    const float curve_start_offset = 70.0;
    const float curve_end_offset = 40.0;
    const float curve_smoothness = 10.0;

    mediump float topWidth = max(size.x - pathRadius - curve_start_offset, p1.x) - p1.x;
    mediump float bottomWidth = p4.x - max(size.x - pathRadius - curve_end_offset, p1.x);

    if (topWidth < bottomWidth)
    {
        mediump float newWidth = (topWidth + bottomWidth) * 0.5;
        topWidth = newWidth;
        bottomWidth = newWidth;
    }

    mediump vec2 p2 = vec2(p1.x + topWidth, p1.y);
    mediump vec2 p3 = vec2(p4.x - bottomWidth, p4.y);

    mediump float slashLength = distance(p2, p3);
    mediump float roundOffset = min(min(topWidth, slashLength * 0.5), curve_smoothness);

    mediump vec2 arc1Start = vec2(p2.x - roundOffset, p2.y);
    mediump vec2 arc1End = mix(p2, p3, roundOffset / slashLength);
    mediump vec2 arc2Start = mix(p2, p3, 1.0 - roundOffset / slashLength);
    mediump vec2 arc2End = vec2(p3.x + roundOffset, p3.y);

    highp float slashAngle = atan(p2.y - p3.y, p2.x - p3.x) - HALF_PI;
    slashAngle += float(slashAngle < 0.0) * TWO_PI;
    slashAngle = TWO_PI - HALF_PI - slashAngle;

    highp float arcAngle = (HALF_PI - slashAngle * 0.5) * 2.0;
    mediump float arcRadius = roundOffset * tan(slashAngle * 0.5);
    mediump float arcLength = arcAngle * arcRadius;

    mediump float length1 = arc1Start.x - p1.x;
    mediump float length2 = distance(arc1End, arc2Start);
    mediump float length3 = p4.x - arc2End.x;
    
    mediump float totalLength = length1 + length2 + length3 + arcLength * 2.0;

    highp float progressArc1Start = length1 / totalLength;
    highp float progressArc1End = (length1 + arcLength) / totalLength;
    highp float progressArc2Start = (length1 + arcLength + length2) / totalLength;
    highp float progressArc2End = (length1 + length2 + arcLength * 2.0) / totalLength;
    mediump vec2 arc1Centre = vec2(p2.x - roundOffset, p2.y + arcRadius);
    mediump vec2 arc2Centre = vec2(p3.x + roundOffset, p3.y - arcRadius);

    mediump float minDst = dstToTopLine(progressRange, p1, arc1Start, progressArc1Start, pixelAbsolutePos);
    minDst = min(minDst, dstToTopArc(progressRange, arcRadius, progressArc1Start, progressArc1End, arc1Centre, slashAngle, arcAngle, pixelAbsolutePos));
    minDst = min(minDst, dstToSlash(progressRange, arc1End, arc2Start, progressArc1End, progressArc2Start, pixelAbsolutePos));
    minDst = min(minDst, dstToBottomArc(progressRange, arcRadius, progressArc2Start, progressArc2End, arc2Centre, slashAngle, arcAngle, pixelAbsolutePos));
    minDst = min(minDst, dstToBottomLine(progressRange, arc2End, p4, progressArc2End, pixelAbsolutePos));
    
    return minDst;
}

#endif
