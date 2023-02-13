#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"

varying highp vec2 v_TexCoord;

uniform highp float relativeHeight;

void main(void)
{
    lowp vec4 col = getRoundedColor(vec4(vec3(0.0), 1.0), v_TexCoord);

    highp vec2 pixelPos = v_TexCoord / (v_TexRect.zw - v_TexRect.xy);
    
    lowp float alpha = 1.0 - (clamp(0.5 - abs(pixelPos.y - 0.5), 0.0, relativeHeight) / relativeHeight);
    
    gl_FragColor = vec4(col.rgb, col.a * alpha);
}
