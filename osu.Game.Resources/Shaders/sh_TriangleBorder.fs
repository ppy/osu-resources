﻿#define HIGH_PRECISION_VERTEX

#include "sh_Utils.h"
#include "sh_Masking.h"

varying highp vec2 v_TexCoord;

uniform mediump float thickness;
uniform highp float texelSize;

void main(void)
{
    highp vec2 pixelPos = v_TexCoord / (v_TexRect.zw - v_TexRect.xy);

    // return if outside the triangle
    if (abs(pixelPos.x - 0.5) > 0.5 * pixelPos.y)
    {
        gl_FragColor = vec4(0.0);
        return;
    }

    highp float dst1 = dstToLine(vec2(0.0, 1.0), vec2(1.0), pixelPos);
    highp float dst2 = dstToLine(vec2(1.0), vec2(0.5, 0.0), pixelPos);
    highp float dst3 = dstToLine(vec2(0.0, 1.0), vec2(0.5, 0.0), pixelPos);
    highp float dst = min(min(dst1, dst2), dst3);

    lowp float alpha = dst < texelSize ? dst / texelSize : smoothstep(texelSize, 0.0, dst - thickness);

    lowp vec4 col = getRoundedColor(vec4(1.0), v_TexCoord);

    gl_FragColor = vec4(col.rgb, col.a * alpha);
}
