#include "sh_Flashlight.h"

lowp vec4 getColourAt(highp vec2 diff, highp vec2 size, lowp vec4 originalColour)
{
    diff = abs(diff);

    lowp float alpha = length(smoothstep(size, size * smoothness, diff));

    return originalColour * vec4(1.0, 1.0, 1.0, alpha);
}
