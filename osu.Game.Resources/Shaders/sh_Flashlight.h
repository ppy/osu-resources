varying highp vec2 v_Position;
varying lowp vec4 v_Colour;

uniform highp vec2 flashlightPos;
uniform highp vec2 flashlightSize;

uniform lowp float flashlightDim;
uniform lowp float flashlightSmoothness;

lowp vec4 getColourAt(highp vec2, highp vec2, lowp vec4);

void main(void)
{
    gl_FragColor = mix(getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour), vec4(0.0, 0.0, 0.0, 1.0), flashlightDim);
}
