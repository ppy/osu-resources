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

// Distance to the line with the points (0.0, 1.0) and (0.5, 0.0)
highp float dstToSideLine(highp vec2 pixelPos)
{
    highp vec2 a = vec2(0.4472, -0.8944);
    highp vec2 closest = dot(a, pixelPos - vec2(0.0, 1.0)) * a + vec2(0.0, 1.0); // closest point on a line from given position
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

    highp float dst = min(1.0 - pixelPos.y, dstToSideLine(pixelPos));

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
