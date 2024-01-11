#ifndef ARGON_BAR_PATH_FS
#define ARGON_BAR_PATH_FS

#undef HIGH_PRECISION_VERTEX
#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"
#include "sh_TextureWrapping.h"
#include "sh_ArgonBarPathUtils.h"

layout(location = 2) in highp vec2 v_TexCoord;

layout(std140, set = 0, binding = 0) uniform m_ArgonBarPathParameters
{
    lowp vec4 barColour;
    lowp vec4 glowColour;
    mediump vec2 size;
    highp vec2 progressRange;
    mediump float pathRadius;
    mediump float padding;
    mediump float glowPortion;
};

layout(location = 0) out vec4 o_Colour;

lowp vec4 glowColAt(highp float absoluteTexturePos, highp float absoluteGlowPortion)
{
    highp float mixValue = 1.0 - (absoluteTexturePos - pathRadius + absoluteGlowPortion) / absoluteGlowPortion;
    return vec4(glowColour.rgb, mix(0.0, glowColour.a, mixValue * mixValue * mixValue * mixValue));
}

lowp vec4 getColour(highp float absoluteTexturePos)
{
    highp float absoluteGlowPortion = pathRadius * glowPortion;
    absoluteTexturePos = clamp(absoluteTexturePos, 0.0, pathRadius);

    if (absoluteTexturePos < pathRadius - absoluteGlowPortion)
        return barColour;

    if (absoluteTexturePos < pathRadius - absoluteGlowPortion + 1.0)
        return mix(glowColAt(absoluteTexturePos, absoluteGlowPortion), barColour, pathRadius - absoluteGlowPortion + 1.0 - absoluteTexturePos);

    return glowColAt(absoluteTexturePos, absoluteGlowPortion);
}

void main(void)
{
    highp vec2 resolution = v_TexRect.zw - v_TexRect.xy;
    highp vec2 pixelPos = (v_TexCoord - v_TexRect.xy) / resolution;

    mediump vec2 absolutePos = size * pixelPos;
    highp float absoluteTexturePos = getBarTexturePosition(size, progressRange, padding, absolutePos);
    o_Colour = getRoundedColor(getColour(absoluteTexturePos), v_TexCoord);
}

#endif
