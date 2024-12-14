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
    // todo: workaround for a SPIR-V bug (https://github.com/ppy/osu-framework/issues/5719)
    float one = g_WrapModeS >= 0 ? 1 : 0;

    vec4 result = mix(getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour), vec4(vec3(0.0), v_Colour.a), flashlightDim) * one;
    result = vec4(result.rgb * result.a, result.a);
    o_Colour = result;
}