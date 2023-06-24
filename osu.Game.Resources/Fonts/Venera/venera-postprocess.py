#!/usr/bin/fontforge

# This is a python script leveraging fontforge.
# The purpose of this script is to process files for the Venera font in a way that fixes several issues
# with osu!'s usage of the font.

# This script implicitly assumes the folder structure:
# - The original font files should be in `./venera` relative to the script.
# - The modified font files will be output to `./venera-modified` relative to the script.
#   The directory must exist beforehand.

import fontforge
import psMat
import os

for filename in os.listdir("venera"):
    in_path = f"venera/{filename}"

    if os.path.splitext(in_path)[1] != ".otf":
        continue

    print(f"Processing {in_path}...")
    font = fontforge.open(in_path)

    print("Getting backtick glyph...")
    backtick = font[0x60]

    (_, _, _, ymax) = backtick.boundingBox()
    ascent = font.ascent
    print(f"Backtick has ymax = {ymax}. Font ascent is {ascent}.")
    if ymax > ascent:
        difference = ymax - ascent
        print(f"Moving glyph down by {difference} to fit.")
        backtick.transform(psMat.translate(0, -difference))

    if 0xA0 not in font:
        print("U+00A0 NO-BREAK SPACE glyph is missing. Filling with U+0020 SPACE.")
        font.selection.select(0x20)
        font.copy()
        font.selection.select(0xA0)
        font.paste()

    if 0x202F not in font:
        print("U+202F NARROW NO-BREAK SPACE glyph is missing. Filling with U+0020 SPACE.")
        font.selection.select(0x20)
        font.copy()
        font.selection.select(0x202F)
        font.paste()

    out_path = f"venera-modified/{filename}"
    print(f"Saving to {out_path}...")
    font.generate(out_path)
