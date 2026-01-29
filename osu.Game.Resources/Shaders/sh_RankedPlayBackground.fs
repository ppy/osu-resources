#include "sh_Utils.h"
#include "sh_Masking.h"
#include "sh_TextureWrapping.h"

layout (location = 2) in mediump vec2 v_TexCoord;

layout (set = 0, binding = 0) uniform lowp texture2D m_Texture;
layout (set = 0, binding = 1) uniform lowp sampler m_Sampler;

layout (std140, set = 1, binding = 0) uniform m_RankedPlayBackgroundParameters
{
    highp vec2 g_DrawSize;
    highp float g_Time;
    highp float g_GridSize;
    lowp vec4 g_GradientOutside;
    lowp vec4 g_GradientInside;
    lowp vec4 g_DotsColour;
};


layout (location = 0) out vec4 o_Colour;

const vec2 hexSide = vec2(1, 1.7320508);

vec4 calcHexInfo(vec2 uv)
{
    vec4 hexCenter = round(vec4(uv, uv - vec2(0.5, 1.0)) / hexSide.xyxy);
    vec4 offset = vec4(uv - hexCenter.xy * hexSide, uv - (hexCenter.zw + 0.5) * hexSide);

    return dot(offset.xy, offset.xy) < dot(offset.zw, offset.zw) 
        ? vec4(offset.xy, hexCenter.xy)
        : vec4(offset.zw, (hexCenter.zw + 0.5));
}

float sdHexagon(in vec2 p, in float r)
{
    const vec3 k = vec3(-0.866025404, 0.5, 0.577350269);
    p = abs(p);
    p -= 2.0 * min(dot(k.xy, p), 0.0) * k.xy;
    p -= vec2(clamp(p.x, -k.z * r, k.z * r), r);
    return length(p) * sign(p.y);
}

vec2 rotate(vec2 v, float a) {
    float s = sin(a);
    float c = cos(a);
    mat2 m = mat2(c, s, -s, c);
    return m * v;
}

void main(void)
{
    const float minRadius = 0.1;
    const vec2 gradientCenter = vec2(0.5, 0.4);
    
    float angle = g_Time * 0.01;

    vec2 hexSamplePos = rotate((v_TexCoord - 0.5) * g_DrawSize, angle) / g_GridSize;

    vec4 hexGrid = calcHexInfo(hexSamplePos);

    vec2 texCoords = rotate(hexGrid.zw * g_GridSize * hexSide, -angle) / g_DrawSize + 0.5;

    vec4 bg = texture(sampler2D(m_Texture, m_Sampler), texCoords);

    mediump float radius = (minRadius + smoothstep(0.0, 1.0, bg.r) * 0.4) * g_GridSize;

    mediump float dist = sdHexagon(hexGrid.yx * g_GridSize, radius); // swapping the x/y axis is equivalent to rotating the hexagons by 30 degrees
    mediump float alpha = clamp(-dist * g_GridSize, 0.0, 1.0) * (0.1 * bg.r + 0.4);

    lowp float gradientProgress = clamp(length(v_TexCoord - gradientCenter) * 1.3, 0.0, 1.0);

    lowp vec3 col = mix(g_GradientOutside.rgb, g_GradientInside.rgb, gradientProgress);

    col = mix(col, col * g_DotsColour.rgb, alpha * g_DotsColour.a);

    o_Colour = vec4(col.rgb, 1.0);
}