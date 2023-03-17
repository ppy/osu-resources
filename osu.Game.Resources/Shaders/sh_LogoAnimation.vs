#include "sh_Utils.h"

layout(location = 0) in highp vec2 m_Position;
layout(location = 1) in lowp vec4 m_Colour;
layout(location = 2) in highp vec2 m_TexCoord;

layout(location = 0) out lowp vec4 v_Colour;
layout(location = 1) out highp vec2 v_TexCoord;

void main(void)
{
	v_Colour = m_Colour;
	v_TexCoord = m_TexCoord;

	gl_Position = g_ProjMatrix * vec4(m_Position, 1.0, 1.0);
}
