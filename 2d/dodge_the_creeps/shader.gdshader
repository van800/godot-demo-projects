shader_type spatial;
render_mode cull_back;

#include "shader_include/color_convert.gdshaderinc"

global uniform float threshold;

void light() {
	float dot_result = dot(NORMAL,LIGHT);
	if (LIGHT_IS_DIRECTIONAL)
	{
		DIFFUSE_LIGHT += step(threshold, dot_result) * ATTENUATION * LIGHT_COLOR;
	}
	else
	{
		float v = rgb_to_hsv(DIFFUSE_LIGHT).z;
		vec3 color = DIFFUSE_LIGHT + ATTENUATION * LIGHT_COLOR;
		color = vec3(rgb_to_hsv(color).rg,v);
		DIFFUSE_LIGHT = hsv_to_rgb(color);
	}
}