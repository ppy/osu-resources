# How to create binary font files

There are two options:

## When generating

When using the official BMFont generator, there is a setting in "Export Options" that specifies the output file format. Just set that to "binary" to get the correct file format. Remember to use the file extension ".bin".

## Converting existing fonts

```csharp
using SharpFNT;

string filename = "MyFont.fnt";

var font = BitmapFont.FromFile(filename);

// This value is ignored for Unicode fonts, but serializing will fail
// if this is empty so just set it to ANSI (0 in binary)
if (font.Info.Charset == string.Empty)
{
    font.Info.Charset = "ANSI";
}

font.Save(Path.ChangeExtension(filename, "bin"), FormatHint.Binary);
```