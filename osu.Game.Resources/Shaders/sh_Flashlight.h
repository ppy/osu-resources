#ifdef GL_ES
    precision mediump float;
    // Not all GPUs support high precision, so we should fall back to medium precision.
    #ifndef GL_FRAGMENT_PRECISION_HIGH
        #define highp
    #endif
#else
    // Since glsl 1.1 doesn't define precision qualifiers but GL_ES does, 
    // Define them as nothing to avoid compilation issues.
    #define lowp
    #define highp
#endif




varying highp vec2 v_Position;
varying lowp vec4 v_Colour;

uniform highp vec2 flashlightPos;
uniform highp vec2 flashlightSize;

uniform lowp float flashlightDim;

const float smoothness = 1.1;

lowp vec4 getColourAt(vec2, vec2, vec4);

void main(void)
{
    gl_FragColor = mix(getColourAt(flashlightPos - v_Position, flashlightSize, v_Colour), vec4(0.0, 0.0, 0.0, 1.0), flashlightDim);
}