#include "sh_Utils.h"

varying mediump vec2 v_TexCoord;
varying lowp vec4 v_Colour;

uniform lowp sampler2D m_Sampler;
uniform lowp float progress;

// Taken from http://lolengine.net/blog/2013/07/27/rgb-to-hsv-in-glsl
vec3 rgb2hsv(vec3 c)
{
    vec4 K = vec4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    vec4 p = c.g < c.b ? vec4(c.bg, K.wz) : vec4(c.gb, K.xy);
    vec4 q = c.r < p.x ? vec4(p.xyw, c.r) : vec4(c.r, p.yzx);

    float d = q.x - min(q.w, q.y);
    float e = 1.0e-10;
    return vec3(abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x);
}

void main(void) 
{
    vec4 colour = toSRGB(texture2D(m_Sampler, v_TexCoord, -0.9));

    /*vec3 hsv = rgb2hsv(colour.rgb);

    gl_FragColor = hsv.x < progress ? toSRGB(vec4(v_Colour.rgb, v_Colour.a * colour.a * hsv.z)) : vec4(0);*/
    
    gl_FragColor = colour.r < progress ? toSRGB(vec4(v_Colour.rgb, v_Colour.a * colour.a)) : vec4(0);
}
