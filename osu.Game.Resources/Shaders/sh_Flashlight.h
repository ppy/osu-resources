layout(location = 0) in highp vec2 v_Position;
layout(location = 1) in lowp vec4 v_Colour;

layout(std140, set = 0, binding = 0) uniform m_FlashlightParameters
{
    highp vec2 flashlightPos;
    highp vec2 flashlightSize;
    lowp float flashlightDim;
    lowp float flashlightSmoothness;
};

layout(location = 0) out vec4 o_Colour;

lowp vec4 getColourAt(highp vec2, highp vec2, lowp vec4);

void main(void)
{
    o_Colour = mix(getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour), vec4(0.0, 0.0, 0.0, 1.0), flashlightDim);
}
