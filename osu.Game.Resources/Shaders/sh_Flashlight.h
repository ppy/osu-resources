#ifdef GL_ES
    precision mediump float;
#endif

varying vec2 v_Position;
varying vec4 v_Colour;

uniform vec2 flashlightPos;
uniform vec2 flashlightSize;

uniform float flashlightLightness;

const float smoothness = 1.1;

vec4 getColourAt(vec2, vec2, vec4);

void main(void)
{
    gl_FragColor = mix(vec4(0.0, 0.0, 0.0, 1.0), getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour), flashlightLightness);
}