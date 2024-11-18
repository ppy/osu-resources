#ifndef VIDEO_FS
#define VIDEO_FS

#include "sh_Utils.h"
#include "sh_Masking.h"
#include "sh_yuv2rgb.h"

layout(location = 2) in mediump vec2 v_TexCoord;

layout(location = 0) out vec4 o_Colour;

layout(std140, set = 4, binding = 0) uniform m_DimParameters
{
    lowp vec4 m_DimColour;
    lowp float m_DimLevel;
};

void main(void) 
{
    vec2 wrappedCoord = wrap(v_TexCoord, v_TexRect);
    vec4 texel = wrappedSamplerRgb(wrappedCoord, v_TexRect, 0.0);
    texel.rgb = mix(texel.rgb, m_DimColour.rgb, m_DimLevel);
    o_Colour = getRoundedColor(texel, wrappedCoord);
}

#endif