#!/bin/bash

# This script fixes "black border" artifacts on transparent edges that occur on PNG exports from figma.
# The script will run on all PNG files in $PWD.
# This script assumes that it is being run on monochrome transparent icon assets and therefore does not attempt to salvage any RGB channel data.
#
# Prerequisites for this script: imagemagick.

for src_file in ./*.png; do
	echo $src_file
	magick $src_file -alpha set -fill white -colorize 100,100,100 -compose CopyOpacity $src_file
done
