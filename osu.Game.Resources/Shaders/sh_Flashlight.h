#ifdef GL_ES
    precision mediump float;
#endif

varying vec2 v_Position;
varying vec4 v_Colour;

uniform vec2 flashlightPos;
uniform vec2 flashlightSize;

const float smoothness = 1.1;

vec4 getColourAt(vec2, vec2, vec4);

void main(void)
{
    gl_FragColor = getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour);
}