#include "sh_Flashlight.h"

vec4 getColourAt(vec2 diff, vec2 size, vec4 originalColour)
{
    diff = abs(diff);

    float alpha = length(smoothstep(size, size * smoothness, diff));

    return vec4(originalColour.xyz, alpha);
}