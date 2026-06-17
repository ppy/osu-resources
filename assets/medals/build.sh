#!/usr/bin/env bash

# requires imagemagick(-full) >= 7.1.2

set -eu

mkdir -p client web tmp

colours=('purple' 'pink' 'red' 'bronze' 'silver' 'gold' 'blue' 'grey' 'green')
offset='+10+4'

for base_colour in "${colours[@]}"; do
    magick -background none "base/medal-$base_colour.svg" $"tmp/client-$base_colour.png"
    magick base/dropshadow.png -resize 408x439 -background none "base/medal-$base_colour.svg" -geometry "$offset" -composite "tmp/web-$base_colour.png"
    for file_path in "$base_colour"/*.svg; do
        file=$(basename "$file_path")
        magick "tmp/client-$base_colour.png" -background none "$file_path" -composite -resize 385x417 "client/${file%.*}@2x.png"
        magick "tmp/client-$base_colour.png" -background none "$file_path" -composite -resize 193x209 "client/${file%.*}.png"
        magick "tmp/web-$base_colour.png" -background none "$file_path" -geometry "$offset" -composite -resize 248x248 "web/${file%.*}@2x.png"
        magick "tmp/web-$base_colour.png" -background none "$file_path" -geometry "$offset" -composite -resize 111x119 "web/${file%.*}.png"
    done
done

rm -r tmp
