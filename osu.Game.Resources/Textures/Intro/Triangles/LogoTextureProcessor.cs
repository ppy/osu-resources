// Post-process for logo animation path textures, moving alpha information away from the alpha channel
// for the shader to produce correct animation without losing information from textures being alpha-premultiplied.
// Input: textures with colours in the form: (x, x, x, y), in which x represents current progress and y represents alpha.
// Output: textures with colours in the form: (x, y, 0, 255).

// Code is commented to not cause compile errors on osu-resources.

/*
const string path = "<osu-resources>/osu.Game.Resources/Textures/Intro/Triangles";
processImage(Path.Combine(path, "logo-background.png"));
processImage(Path.Combine(path, "logo-highlight.png"));

void processImage(string filename)
{
    using var image = Image.Load<Rgba32>(filename);

    image.ProcessPixelRows(p =>
    {
        for (int i = 0; i < p.Height; i++)
        {
            foreach (ref var pixel in p.GetRowSpan(i))
                pixel = new Rgba32(pixel.R, pixel.A, 0, 255);
        }
    });

    image.SaveAsPng(filename);
}
*/