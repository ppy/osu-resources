#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"

varying highp vec2 v_TexCoord;

uniform lowp sampler2D m_Sampler;

highp float dstToLine(highp vec2 start, highp vec2 end, highp vec2 pixelPos)
{
    highp float lineLength = distance(end, start);

    if (lineLength < 0.001)
        return distance(pixelPos, start);

    highp vec2 a = (end - start) / lineLength;
    highp vec2 closest = clamp(dot(a, pixelPos - start), 0.0, distance(end, start)) * a + start; // closest point on a line from given position
    return distance(closest, pixelPos);
}

bool insideTriangle(highp vec2 pixelPos)
{
    bool inLeftPart = pixelPos.x < 0.5 && pixelPos.x > 0.5 * (1.0 - pixelPos.y);
    bool inRightPart = pixelPos.x > 0.5 && pixelPos.x < 0.5 * (1.0 + pixelPos.y);

    return inLeftPart || inRightPart;
}

void main(void)
{
    highp vec2 resolution = v_TexRect.zw - v_TexRect.xy;
    highp vec2 pixelPos = (v_TexCoord - v_TexRect.xy) / resolution;

    highp float texelSize = max(abs(dFdx(pixelPos.x)), abs(dFdy(pixelPos.y))) * 1.5;

    if (!insideTriangle(pixelPos))
    {
        gl_FragColor = vec4(0.0);
        return;
    }

    highp float dst1 = dstToLine(vec2(0.0, 1.0), vec2(1.0), pixelPos);
    highp float dst2 = dstToLine(vec2(1.0), vec2(0.5, 0.0), pixelPos);
    highp float dst3 = dstToLine(vec2(0.0, 1.0), vec2(0.5, 0.0), pixelPos);
    highp float dst = min(min(dst1, dst2), dst3);

    // stroke width will be 2px assuming triangle size is 100px
    lowp float alpha = dst < texelSize ? dst / texelSize : smoothstep(texelSize, 0.0, dst - 0.02);

    lowp vec4 col = getRoundedColor(toSRGB(texture2D(m_Sampler, v_TexCoord)), v_TexCoord);

    gl_FragColor = vec4(col.rgb, col.a * alpha);
}
