#include "sh_Flashlight.h"

// highp precision is necessary for vertex positions to prevent catastrophic failure on GL_ES platforms
lowp vec4 getColourAt(highp vec2 diff, highp vec2 size, lowp vec4 originalColour)
{
    highp float dist = length(diff);
    highp float flashlightRadius = length(size);

    return originalColour * vec4(smoothstep(flashlightRadius, flashlightRadius * flashlightSmoothness, dist));
}