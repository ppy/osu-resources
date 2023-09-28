#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"

layout(location = 2) in highp vec2 v_TexCoord;

layout(std140, set = 0, binding = 0) uniform m_BorderData
{
    mediump float thickness;
    highp float texelSize;
};

layout(location = 0) out vec4 o_Colour;

highp float dstToLine(highp vec2 start, highp vec2 end, highp vec2 pixelPos)
{
    highp float lineLength = distance(end, start);
    highp vec2 a = (end - start) / lineLength; // Within the scope of this shader line length won't be 0
    highp vec2 closest = clamp(dot(a, pixelPos - start), 0.0, lineLength) * a + start; // closest point on a line from given position
    return distance(closest, pixelPos);
}

void main(void)
{
    highp vec2 pixelPos = v_TexCoord / (v_TexRect.zw - v_TexRect.xy);
    pixelPos.x = 0.5 - abs(pixelPos.x - 0.5); // Mirror coordinate space horizontally (0 -> 1 to 0 -> 0.5 -> 0)

    // return if outside the triangle
    if (pixelPos.y < 1.0 - 2.0 * pixelPos.x)
    {
        o_Colour = vec4(0.0);
        return;
    }

    highp float dstToBottom = 1.0 - pixelPos.y;
    highp float dstToSide = dstToLine(vec2(0.0, 1.0), vec2(0.5, 0.0), pixelPos);
    highp float dst = min(dstToBottom, dstToSide);

    lowp float alpha = 0.0;

    if (texelSize == 0.0)
    {
        alpha = step(dst, thickness);
    }
    else
    {
        alpha = dst < texelSize
            ? smoothstep(0.0, texelSize, dst) // outer border smoothing
            : smoothstep(texelSize, 0.0, dst - thickness); // inner border smoothing
    }

    lowp vec4 col = getRoundedColor(vec4(1.0), v_TexCoord);

    o_Colour = vec4(col.rgb, col.a * alpha);
}
