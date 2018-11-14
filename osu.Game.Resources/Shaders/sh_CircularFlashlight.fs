#include "sh_Flashlight.h"

vec4 getColourAt(vec2 diff, vec2 size, vec4 originalColour)
{
    float dist = length(diff);
    float flashlightRadius = length(size);

    return vec4(originalColour.xyz, smoothstep(flashlightRadius, flashlightRadius * smoothness, dist));
}