#!/bin/bash

# ==============================================================================
# osu! Emoji Generator Script
# ==============================================================================
# This script generates emoji images for use with osu!, based on emoji from 
# the Google Noto Color Emoji project: https://github.com/googlefonts/noto-emoji
#
# REQUIREMENTS:
# - This script should be copied into the root directory of the noto-emoji 
#   repository after cloning
# - vips image processing library from https://www.libvips.org/install.html
#   is required to run this script
#
# OUTPUT:
# - Generates an Emoji.zip file containing emoji images
# - Each emoji image is 50x50 pixels, stored as raw RGBA32 image data
# - Image filename format: emoji unicode hex sequence with _ as separator
#
# EXAMPLES:
# - "👍" (U+1F44D) -> "1f44d.raw"
# - "👨‍👩‍👧‍👦" (U+1F468 U+200D U+1F469 U+200D U+1F467 U+200D U+1F466) -> "1f468_200d_1f469_200d_1f467_200d_1f466.raw"
# ==============================================================================

# Exit immediately if any command fails
set -e

# Validate that we're running from the correct directory
if [[ ! -d "svg" ]] || [[ ! -d "third_party/region-flags/waved-svg" ]]; then
    echo "Could not find required directories. Are you sure you're running this script from the noto-emoji root directory?"
    exit 1
fi

# Create output directory for processed emoji images
mkdir -p "osu"

# Target image size for all emoji outputs
TARGET_SIZE=50x50

# Function to convert SVG files to RAW RGBA Image
convert_svg_files() {
    local pattern="$1"
    local prefix_to_remove="$2"
    
    for svg_file in ${pattern}; do
        # Skip if no files match the pattern
        [[ ! -f "$svg_file" ]] && continue
        
        # Check if the file contains a reference to another file
        actual_svg_file="$svg_file"
        if [[ -f "$svg_file" ]]; then
            # Read the first line to check if it's a file reference
            first_line=$(head -n 1 "$svg_file")
            # If the first line doesn't start with '<', it might be a file reference
            if [[ ! "$first_line" =~ ^[[:space:]]*\< ]]; then
                # Treat it as a file reference
                referenced_file=$(echo "$first_line" | tr -d '\r\n')
                # Check if the referenced file exists (try relative to the original file's directory)
                base_dir=$(dirname "$svg_file")
                if [[ -f "$base_dir/$referenced_file" ]]; then
                    actual_svg_file="$base_dir/$referenced_file"
                    echo "Following reference: $svg_file -> $actual_svg_file"
                fi
            fi
        fi
        
        # Get filename without path and extension
        filename=$(basename "$svg_file" .svg)
        
        # Remove specified prefix from filename (e.g., "emoji_u1f44d" -> "1f44d")
        filename=${filename#$prefix_to_remove}
        target_path="osu/${filename}.raw"
        
        echo "Converting ${svg_file} -> ${target_path}"
        vips thumbnail "${actual_svg_file}" "${target_path}" ${TARGET_SIZE}
    done
}

# ==============================================================================
# Main Processing
# ==============================================================================

# Convert all standard emoji SVG files from the main svg directory
echo "Processing standard emoji files..."
convert_svg_files "svg/emoji_u*.svg" "emoji_u"

# Convert all region flag emoji SVG files from the third-party directory
echo "Processing region flag emoji files..."
convert_svg_files "third_party/region-flags/waved-svg/emoji_u*.svg" "emoji_u"

# Create final compressed archive containing all processed emoji images
echo "Creating Emoji.zip archive..."
zip -r -j Emoji.zip osu/

echo "✅ Emoji.zip created successfully!"
echo "📊 Archive contains $(ls osu/*.raw 2>/dev/null | wc -l) emoji images"