#include "sh_Utils.h"

varying mediump vec2 v_TexCoord;
varying lowp vec4 v_Colour;

uniform lowp sampler2D m_Sampler;
uniform lowp float progress;

void main(void) 
{
    vec4 colour = toSRGB(texture2D(m_Sampler, v_TexCoord, -0.9));
    
    gl_FragColor = colour.r < progress ? toSRGB(vec4(v_Colour.rgb, v_Colour.a * colour.a)) : vec4(0);
}
