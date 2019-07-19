#include "sh_Flashlight.h"

// highp precision is necessary for vertex positions to prevent catastrophic failure on GL_ES platforms
vec4 getColourAt(highp vec2 diff, highp vec2 size, lowp vec4 originalColour)
{
    float dist = length(diff);
    float flashlightRadius = length(size);

    return originalColour * vec4(1.0, 1.0, 1.0, smoothstep(flashlightRadius, flashlightRadius * smoothness, dist));
}