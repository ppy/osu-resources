#ifndef LEGACY_COMBO_FIRE_VS
#define LEGACY_COMBO_FIRE_VS

layout(location = 0) in highp vec2 m_Position;
layout(location = 1) in lowp vec4 m_Colour;

layout(location = 0) out highp vec2 v_TexCoord;
layout(location = 1) out lowp vec4 v_Colour;

void main(void)
{
    gl_Position = g_ProjMatrix * vec4(m_Position, 1.0, 1.0);

    v_TexCoord = m_Position;
    v_Colour = m_Colour;
}

#endif
