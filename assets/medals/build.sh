#!/usr/bin/env bash

# requires imagemagick(-full) >= 7.1.2

set -eu

mkdir -p output/client output/web output/tmp

colours=('purple' 'pink' 'red' 'bronze' 'silver' 'gold' 'blue' 'grey' 'green')
offset='+10+4'

for base_colour in "${colours[@]}"; do
    echo "Processing $base_colour medals..."

    magick -background none "base/medal-$base_colour.svg" $"output/tmp/client-$base_colour.png"
    magick base/dropshadow.png -resize 408x439 -background none "base/medal-$base_colour.svg" -geometry "$offset" -composite "output/tmp/web-$base_colour.png"
    for file_path in "$base_colour"/*.svg; do
        echo "* $file_path"
        file=$(basename "$file_path")
        magick "output/tmp/client-$base_colour.png" -background none "$file_path" -composite -resize 385x417 "output/client/${file%.*}@2x.png"
        magick "output/tmp/client-$base_colour.png" -background none "$file_path" -composite -resize 193x209 "output/client/${file%.*}.png"
        magick "output/tmp/web-$base_colour.png" -background none "$file_path" -geometry "$offset" -composite -resize 248x248 "output/web/${file%.*}@2x.png"
        magick "output/tmp/web-$base_colour.png" -background none "$file_path" -geometry "$offset" -composite -resize 111x119 "output/web/${file%.*}.png"
    done
done

rm -r output/tmp
