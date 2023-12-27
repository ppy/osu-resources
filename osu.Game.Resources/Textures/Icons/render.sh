#!/bin/bash

# This is a skeleton of a script used to generate these assets from figma correctly.
# To start using it, export your desired assets from figma *in SVG format*.
#
# Prerequisites for this script: inkscape, imagemagick.
#
# Presumed folder structure:
# - source .svgs in ./src
# - output .pngs will be placed in ./out
# - directories must exist
#
# Presumed image format:
# - svgs must contain icons in BLACK
#   otherwise the `convert -negate` step will not do the right thing
#   the goal is to have RGB channels of the output PNG all white
#   and only masked by the alpha channel

for src_file in ./src/*.svg; do
	src_filename=$(basename ${src_file})
	dst_file="./out/${src_filename%.svg}.png"
	echo "${src_file} -> ${dst_file}"

	inkscape -w 100 ${src_file} -o ${dst_file} > /dev/null 2>&1
	convert ${dst_file} -negate ${dst_file}
done
