#ifdef GL_ES
    precision mediump float;
#endif

varying vec2 v_Position;
varying vec4 v_Colour;

uniform bool rectangular;
uniform vec2 flashlightPos;
uniform float circularFlashlightSize;
uniform vec2 rectangularFlashlightSize;

const float smoothness = 1.1;

void main(void)
{
    if(rectangular)
    {
        vec2 diff = abs(v_Position - flashlightPos);

        float alpha = 1.0 - smoothstep(rectangularFlashlightSize.x, rectangularFlashlightSize.x * smoothness, diff.x);
        alpha *= 1.0 - smoothstep(rectangularFlashlightSize.y, rectangularFlashlightSize.y * smoothness, diff.y);

        gl_FragColor  = v_Colour * vec4(1.0, 1.0, 1.0, 1.0 - alpha);
    }
    else
    {
        vec2 diff = flashlightPos - v_Position;

        float dist = sqrt(diff.x * diff.x + diff.y * diff.y);

        gl_FragColor = v_Colour * vec4(1.0, 1.0, 1.0, smoothstep(circularFlashlightSize, circularFlashlightSize * smoothness, dist));
    }
}