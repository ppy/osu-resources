#ifdef GL_ES
    precision mediump float;
#endif

varying vec2 v_Position;
varying vec4 v_Colour;

uniform vec2 mousePos;
uniform float flashlightSize;

const float smoothness = 0.1;

void main(void)
{
    vec2 diff = mousePos - v_Position;

    float dist = sqrt(diff.x * diff.x + diff.y * diff.y);

    float smoothnessRange = flashlightSize * smoothness;

    gl_FragColor = v_Colour * vec4(1.0, 1.0, 1.0, smoothstep(flashlightSize, flashlightSize + smoothnessRange, dist));
}