#include "Internal/sh_MaskingInfo.h"

layout(location = 0) in vec2 m_Position;
layout(location = 1) in vec4 m_Colour;
layout(location = 2) in vec2 m_TexCoord;
layout(location = 3) in vec4 m_TexRect;
layout(location = 4) in float m_Time;
layout(location = 5) in int m_MaskingIndex;

layout(location = 0) out vec2 v_MaskingPosition;
layout(location = 1) out vec4 v_Colour;
layout(location = 2) out vec2 v_TexCoord;
layout(location = 3) out vec4 v_TexRect;
layout(location = 4) out vec2 v_BlendRange;
layout(location = 5) flat out int v_MaskingIndex;
layout(location = 6) out highp vec2 v_ScissorPosition;

layout(std140, set = 1, binding = 0) uniform m_CursorTrailParameters
{
    float g_FadeClock;
    float g_FadeExponent;
};

void main(void)
{
    InitMasking(m_MaskingIndex);

    // Transform to position to masking space.
    highp vec4 maskingPos = g_MaskingInfo.ToMaskingSpace * vec4(m_Position.xy, 1.0, 1.0);
    v_MaskingPosition = maskingPos.xy / maskingPos.z;

    highp vec4 scissorPos = g_MaskingInfo.ToScissorSpace * vec4(m_Position.xy, 1.0, 1.0);
    v_ScissorPosition = scissorPos.xy / scissorPos.z;

    v_Colour = vec4(m_Colour.rgb, m_Colour.a * pow(clamp(m_Time - g_FadeClock, 0.0, 1.0), g_FadeExponent));

    v_TexCoord = m_TexCoord;
    v_TexRect = m_TexRect;
    v_BlendRange = vec2(0.0);
    v_MaskingIndex = m_MaskingIndex;

    gl_Position = g_ProjMatrix * vec4(m_Position, 1.0, 1.0);
}
