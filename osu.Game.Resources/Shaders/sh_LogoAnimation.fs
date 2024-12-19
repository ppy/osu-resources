#include "sh_Utils.h"

layout(location = 0) in lowp vec4 v_Colour;
layout(location = 1) in mediump vec2 v_TexCoord;

layout(set = 0, binding = 0) uniform lowp texture2D m_Texture;
layout(set = 0, binding = 1) uniform lowp sampler m_Sampler;

layout(std140, set = 1, binding = 0) uniform m_AnimationData
{
    lowp float progress;
};

layout(location = 0) out vec4 o_Colour;

void main(void) 
{
    // todo: workaround for a SPIR-V bug (https://github.com/ppy/osu-framework/issues/5719)
    float one = g_BackbufferDraw ? 1 : 0;

    vec4 texel = texture(sampler2D(m_Texture, m_Sampler), v_TexCoord, -0.9) * one;

    // in the logo animation textures, progress information is stored in red channel, 
    // and alpha information is stored in green channel. this is done this way
    // to avoid alpha pre-multiplication causing data precision loss.
    float current = texel.r;
    float alpha = texel.g;

    o_Colour = current < progress ? v_Colour.rgba * alpha : vec4(0);
}