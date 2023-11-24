#ifndef SPINNER_GLOW_FS
#define SPINNER_GLOW_FS

#undef HIGH_PRECISION_VERTEX
#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"
#include "sh_CircularProgressUtils.h"

layout(location = 2) in highp vec2 v_TexCoord;

layout(std140, set = 0, binding = 0) uniform m_ProgressGlowParameters
{
    mediump float innerRadius;
    mediump float progress;
    highp float texelSize;
    highp float glowSize;
};

layout(set = 1, binding = 0) uniform lowp texture2D m_Texture;
layout(set = 1, binding = 1) uniform lowp sampler m_Sampler;

layout(location = 0) out vec4 o_Colour;

void main(void)
{
    highp vec2 resolution = v_TexRect.zw - v_TexRect.xy;

    // Inflate coordinate space, so it would be (-glowSize -> 0 -> 1 -> glowSize) to preserve everything in place while inflating the draw quad
    highp vec2 pixelPos = (v_TexCoord - v_TexRect.xy) / resolution * (vec2(1.0) + glowSize * 2.0) - glowSize;

    highp float dst = distanceToProgress(pixelPos, progress, innerRadius, true, texelSize);
    highp float progressThickness = innerRadius * 0.25;
    highp float relativeTextureHeight = glowSize + progressThickness;

    if (dst > relativeTextureHeight)
    {
        o_Colour = vec4(0.0);
        return;
    }

    highp float textureY = 1.0 - (dst / relativeTextureHeight);
    lowp vec4 texCol = texture(sampler2D(m_Texture, m_Sampler), v_TexRect.xy + vec2(0.0, textureY) * resolution, -0.9);

    o_Colour = getRoundedColor(texCol, v_TexCoord);
}

#endif
