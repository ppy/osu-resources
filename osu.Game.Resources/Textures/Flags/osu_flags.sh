#!/bin/bash

# This script generates PNG flag images for use with osu!, basing on flags from the twemoji project: https://github.com/twitter/twemoji
# The script should be copied into the root directory of the twemoji repository after cloning, and ran from there.
# inkscape, imagemagick, and pngcrush are required to run this script.

set -e

if [[ ! -d "assets/svg" ]]; then
    echo "Could not find assets/svg directory. Are you sure you're running this script from the twemoji root directory?"
    exit 1
fi

mkdir -p "assets/osu"

# The twemoji assets are named using the Unicode code point sequence that they are represented by.
# Unicode flags are represented by sequences of 26 so-called "regional indicator symbols".
# Each one of them can be thought of as roughly equivalent to an ASCII letter,
# and the combination for a given flag corresponds to the country's ISO-3166-2 acronym.
# To proceed, let's rename the assets to a user-readable name first.

regional_indicator_a=$((16#1f1e6))
regional_indicator_z=$((16#1f1ff))

ascii_a=$((16#41))

# We will be testing every possible sequence of two indicator symbols, to future-proof against future countries.
for first_indicator in $(seq $regional_indicator_a $regional_indicator_z); do
    for second_indicator in $(seq $regional_indicator_a $regional_indicator_z); do

        # Glue together the filename of the original SVG file from twemoji.
        original_filename="$(printf %x $first_indicator)-$(printf %x $second_indicator)"
        original_path="assets/svg/${original_filename}.svg"

        # Unmap the regional indicators to ASCII letters.
        first_letter=$(($first_indicator - $regional_indicator_a + $ascii_a))
        second_letter=$(($second_indicator - $regional_indicator_a + $ascii_a))

        # Glue together the filename of the intermediate and target PNG file.
        target_filename=$(printf "\x$(printf %x ${first_letter})\x$(printf %x ${second_letter})")

        intermediate_path="assets/osu/${target_filename}-intermediate.png"
        target_path="assets/osu/${target_filename}.png"

        if [[ -e ${original_path} ]]; then
            echo "Rendering ${original_path} -> ${target_path}"

            # For the initial rasterisation, generate images of 10x the target size of 150px width.
            # This is done in order to alleviate transparent gaps between shapes that happen if rasterisation is done at a lower resolution.
            inkscape -w 1500 ${original_path} -o ${target_path} > /dev/null 2>&1

            # Unfortunately for us, osu-web does not use twemoji's flags raw, it also applies some CSS effects to it.
            # The exported image also has some transparent pixels that are not needed.
            # To eliminate both we will have to run post-processing, using imagemagick.
            #
            # Taking it one by one:
            #
            # - `-trim +repage` is used to trim the transparent area that is not needed.
            # - The rest is supposed to emulate two transformations that web applies to the image.
            #   The relevant CSS source file can be found here: https://github.com/ppy/osu-web/blob/master/resources/assets/less/bem/flag-country.less
            #
            #   - First, the `filter: saturate(1.1);` rule is emulated using the imagemagick `-color-matrix` operator.
            #     The matrix coefficients were derived from the W3C spec for filters, which can be found here: https://www.w3.org/TR/filter-effects-1/#feColorMatrixElement
            #     At the time of writing, imagemagick's results were perfectly accurate when compared to the output of Firefox 93.
            #
            #   - Secondly, the `::after` element also has an applied `filter: brightness(2);` with `opacity: 0.25;`.
            #     Not exactly sure what is supposed to happen there, but upon experimentation using Firefox's Inspect Element,
            #     it turned out that the `::after` element had a solid #FEFEFE colour.
            #     Therefore, this imagemagick command emulates that by adding a solid #FEFEFE fill and using `-colorize` with the desired alpha value of 25%.
            #     This is not 100% accurate for dark colours, but it looks to be close enough.
            #
            # - After all that, we still have to get the image to a reasonable size.
            #   Unfortunately the world is cruel and flags have differing aspect ratio, and lazer expects to be able to fill the flag area with the sprite horizontally.
            #   So sometimes, on square flags (Switzerland, Vatican) or worse (Nepal), we need to pad the sprite on the left & right to a common constant size.
            #   That dimension is set to 150x108.
            convert ${target_path} -trim +repage -color-matrix \
                " 1.0787 -0.0715 -0.0072, 0.0, 0.0 \
                 -0.0213  1.0285 -0.0072, 0.0, 0.0 \
                 -0.0213 -0.0715  1.0928, 0.0, 0.0 \
                  0.0000  0.0000  0.0000, 1.0, 0.0 \
                  0.0000  0.0000  0.0000, 0.0, 0.1" \
                -fill "#FEFEFE" -colorize 25% \
                -resize x108 \
                -gravity center -background none -extent 150x108 ${intermediate_path}

            # The output of imagemagick tends to be a bit on the larger side, so run pngcrush on the result to knock that down some.
            pngcrush ${intermediate_path} ${target_path} > /dev/null 2>&1
        fi

    done
done

echo "Removing intermediate files..."
rm assets/osu/*-intermediate.png

echo "All assets generated to ./assets/osu."
