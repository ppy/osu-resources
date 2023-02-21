layout(location = 0) in vec2 m_Position;
layout(location = 1) in vec4 m_Colour;

layout(location = 0) out vec2 v_Position;
layout(location = 1) out vec4 v_Colour;

void main(void)
{
	gl_Position = g_ProjMatrix * vec4(m_Position.xy, 1.0, 1.0);
	v_Position = m_Position;
	v_Colour = m_Colour;
}