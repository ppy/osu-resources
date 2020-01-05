varying lowp vec4 v_Colour;
varying mediump vec2 v_TexCoord;

uniform lowp sampler2D m_Sampler;
uniform highp float highlight;
uniform highp float animation;

vec3 rgb2hsv(vec3 c)
{
    vec4 K = vec4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    vec4 p = mix(vec4(c.bg, K.wz), vec4(c.gb, K.xy), step(c.b, c.g));
    vec4 q = mix(vec4(p.xyw, c.r), vec4(c.r, p.yzx), step(p.x, c.r));

    float d = q.x - min(q.w, q.y);
    float e = 1.0e-10;
    return vec3(abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x);
}

void main(void)
{
	vec4 in_Colour = v_Colour * texture2D(m_Sampler, v_TexCoord, -0.9);
	vec3 hsv = rgb2hsv(in_Colour.rgb);

    gl_FragColor = vec4(vec3(hsv.r < highlight ? (hsv.r < animation ? 0.6f : 1f ) * hsv.z : 0f), (hsv.r < highlight ? 0.8f : 0f) * in_Colour.a);
}