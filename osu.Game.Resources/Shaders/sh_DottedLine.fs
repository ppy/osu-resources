#ifdef GL_ES
    precision mediump float;
#endif

#include "sh_Utils.h"

varying vec4 v_Colour;

uniform vec2 g_Position;
uniform vec2 g_Size;

uniform float g_Period;
uniform float g_PeriodOffset;

uniform float g_StrokeWidth;
uniform float g_StrokeHeight;
uniform float g_Separation;

void main(void)
{
	float xVisible = mod(gl_FragCoord.x, g_StrokeWidth + g_Separation);

	if (xVisible > g_StrokeWidth)
	{
		gl_FragColor = vec4(0.0);
		return;
	}

	// Normalized 
	float normalizedY = gl_FragCoord.y - g_Position.y;
	float yVisible = abs(normalizedY - ((g_Size.y / 2.0 - g_StrokeHeight / 2.0) * sin(g_Period / g_Size.x * gl_FragCoord.x + g_PeriodOffset) + g_Size.y / 2.0));

	if (yVisible > g_StrokeHeight / 2.0)
	{
		gl_FragColor = vec4(0.0);
		return;
	}

	gl_FragColor = toSRGB(v_Colour);
}