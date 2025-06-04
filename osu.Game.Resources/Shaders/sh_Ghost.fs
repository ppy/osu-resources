#ifndef GHOST_FS
#define GHOST_FS

#undef HIGH_PRECISION_VERTEX
#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"

layout(location = 2) in highp vec2 v_TexCoord;

layout(std140, set = 0, binding = 0) uniform m_GhostParameters
{
    highp float g_Time;
};

layout(location = 0) out vec4 o_Colour;

const float pi = 3.14159265359;

highp float distanceToBox(in vec2 p, in vec2 b)
{
    vec2 d = abs(p) - b;
    return length(max(d, 0.0)) + min(max(d.x, d.y), 0.0);
}

highp float easeInCirc(in float x) {
    return 1.0 - sqrt(1.0 - x * x);
}

highp float mainBody(in vec2 pos) {
    highp float topCircle = distance(pos, vec2(0.5, 0.375)) - 0.375;

    highp float box = distanceToBox(pos - vec2(0.5, 0.75), vec2(0.375, 0.375));

    return min(topCircle, box);
}

highp float eyes(in vec2 pos) {
    const vec2 eye_position = vec2(0.125, 0.375);

    return distance(vec2(abs(pos.x - 0.5), pos.y), eye_position) - 0.0625;
}

highp float zigzag(in vec2 pos) {
    const int num_spikes = 4;
    const float scale = pi * 2 * num_spikes;
    const float corner_radius = 0.0625;

    highp float strength = sin(pos.x * pi);

    highp float threshold = 0.875 + (cos((pos.x - g_Time) * scale) * 0.5 + 0.5) * 0.125 * strength;

    highp float distanceToEdge = 0.375 - abs(pos.x - 0.5);

    if (distanceToEdge < corner_radius) {
        threshold -= easeInCirc(1.0 - distanceToEdge / corner_radius) * corner_radius;
    }

    return pos.y - threshold;
}


void main(void)
{
    highp float blendRange = v_BlendRange.x / v_TexRect.z;

    vec2 pos = v_TexCoord;

    highp float dst = mainBody(pos);
    dst = max(dst, -eyes(pos));
    dst = max(dst, zigzag(pos));

    highp float alpha = blendRange.x == 0.0 ? float(dst < 0.0) : (clamp(-dst, 0.0, blendRange.x) / blendRange.x);

    o_Colour = getRoundedColor(vec4(vec3(1.0), alpha), vec2(0.0));
}

#endif