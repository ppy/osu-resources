#include "sh_Utils.h"
#include "sh_Masking.h"
#include "sh_TextureWrapping.h"

layout(location = 2) in mediump vec2 v_TexCoord;

layout(set = 0, binding = 0) uniform lowp texture2D m_Texture;
layout(set = 0, binding = 1) uniform lowp sampler m_Sampler;

layout(std140, set = 1, binding = 0) uniform m_BeatmapBackgroundParameters
{
    lowp vec4 m_DimColour;
    lowp float m_DimLevel;
};

layout(location = 0) out vec4 o_Colour;

void main(void) 
{
    vec2 wrappedCoord = wrap(v_TexCoord, v_TexRect);
    vec4 texel = wrappedSampler(wrappedCoord, v_TexRect, m_Texture, m_Sampler, -0.9);
    texel.rgb = mix(texel.rgb, m_DimColour.rgb, m_DimLevel);
    o_Colour = getRoundedColor(texel, wrappedCoord);
}
