#ifndef LEGACY_COMBO_FIRE_FS
#define LEGACY_COMBO_FIRE_FS

#include "sh_TextureWrapping.h"

layout(location = 0) in highp vec2 v_TexCoord;
layout(location = 1) in lowp vec4 v_Colour;

layout(std140, set = 0, binding = 0) uniform m_FireParameters
{
    highp float g_Time;
    highp float g_AlphaFactor;
    highp float g_OrangeToBlueLerp;
    highp vec4 g_OrangeTexRect;
    highp vec4 g_BlueTexRect;
    highp vec4 g_EffectsTexRect;
};

layout(set = 1, binding = 0) uniform lowp texture2D m_OrangeTexture;
layout(set = 1, binding = 1) uniform lowp sampler m_OrangeSampler;

layout(set = 2, binding = 0) uniform lowp texture2D m_BlueTexture;
layout(set = 2, binding = 1) uniform lowp sampler m_BlueSampler;

layout(set = 3, binding = 0) uniform lowp texture2D m_EffectsTexture;
layout(set = 3, binding = 1) uniform lowp sampler m_EffectsSampler;

layout(location = 0) out vec4 o_Colour;

const highp float noiseHeightScale = 0.44;
const highp float noiseHeightOffset = -3.8;
const highp vec3 noiseSpeeds = vec3(0.69, 0.52, 0.75);
const highp vec3 noiseWeights = vec3(0.12, 0.09, 0.07);

const int WRAP_CLAMP_TO_EDGE = 1;
const int WRAP_REPEAT = 3;

lowp vec4 wrappedTexture(lowp texture2D t, lowp sampler s, highp vec2 pos, highp vec4 texRect, int wrapMode)
{
    pos = vec2
    (
        wrap(pos.x, wrapMode, 0, 1),
        wrap(pos.y, wrapMode, 0, 1)
    );

    return texture(sampler2D(t, s), pos * (texRect.zw - texRect.xy) + texRect.xy, -0.9);
}

void main(void)
{
    // Take 3 samples of the noise texture (red channel of effects)
    highp vec3 noiseCoordYs = noiseSpeeds * g_Time + v_TexCoord.y;
    lowp vec3 noiseSamples = vec3
    (
        wrappedTexture(m_EffectsTexture, m_EffectsSampler, vec2(v_TexCoord.x, noiseCoordYs.x), g_EffectsTexRect, WRAP_REPEAT).r,
        wrappedTexture(m_EffectsTexture, m_EffectsSampler, vec2(v_TexCoord.x, noiseCoordYs.y), g_EffectsTexRect, WRAP_REPEAT).r,
        wrappedTexture(m_EffectsTexture, m_EffectsSampler, vec2(v_TexCoord.x, noiseCoordYs.z), g_EffectsTexRect, WRAP_REPEAT).r
    );

    // Weighted sum of the noise samples, each rescaled to [-1, 1]
    lowp float noiseSum = dot(noiseSamples * 2 - 1, noiseWeights);

    // Apply noise to texture coordinate
    lowp vec2 adjustedCoord = v_TexCoord + vec2(noiseSum) * (v_TexCoord.y * noiseHeightScale + noiseHeightOffset);

    // Take samples of orange and blue with the adjusted coordinate
    lowp vec4 orange = wrappedTexture(m_OrangeTexture, m_OrangeSampler, adjustedCoord, g_OrangeTexRect, WRAP_CLAMP_TO_EDGE);

    // Change from osu!stable: Mask away top-right corner. The opacity tricks
    // below leave some artifacts of the orange fire in that corner. The smooth
    // step helps blend the orange to blue fire transition better.
    orange.a *= smoothstep(-0.1, 0.1, -v_TexCoord.x + v_TexCoord.y);

    lowp vec4 blue = wrappedTexture(m_BlueTexture, m_BlueSampler, adjustedCoord, g_BlueTexRect, WRAP_CLAMP_TO_EDGE);

    // Mix orange and blue together
    lowp vec4 base = mix(orange, blue, g_OrangeToBlueLerp);

    // Take sample of the "opacity" texture (green and blue channel of
    // effects) with the adjusted coordinate. Despite what it was named, the
    // texture also includes a subtle greyscale component.
    lowp vec4 opacity = wrappedTexture(m_EffectsTexture, m_EffectsSampler, adjustedCoord, g_EffectsTexRect, WRAP_CLAMP_TO_EDGE).gggb;

    // Adjust alpha using the base green channel and the alpha factor
    opacity.a *= clamp((base.g * 0.5 - 0.5 + g_AlphaFactor) / 0.1, 0, 1);

    o_Colour = base * opacity * v_Colour;
}

#endif
