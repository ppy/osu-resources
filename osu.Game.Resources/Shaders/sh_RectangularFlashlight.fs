#include "sh_Flashlight.h"

vec4 getColourAt(vec2 diff, vec2 size, vec4 originalColour)
{
    diff = abs(diff);

    float alpha = length(smoothstep(size, size * smoothness, diff));

    return originalColour * vec4(1.0, 1.0, 1.0, alpha);
}