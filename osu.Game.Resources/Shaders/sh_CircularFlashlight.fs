#include "sh_Flashlight.h"

// highp diff prevents loss in precision when calculating smoothing distance on GL_ES platforms
vec4 getColourAt(highp vec2 diff, vec2 size, vec4 originalColour)
{
    float dist = length(diff);
    float flashlightRadius = length(size);

    return originalColour * vec4(1.0, 1.0, 1.0, smoothstep(flashlightRadius, flashlightRadius * smoothness, dist));
}