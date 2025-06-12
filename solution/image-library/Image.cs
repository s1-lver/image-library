using System.Drawing;
using System.Runtime.Versioning;

namespace image_library;

public static class Image
{
    [SupportedOSPlatform("windows")]
    public static Bitmap ToGreyscale(Bitmap img)
    {
        int x, y;
        for (x = 0; x < img.Width; x++)
        {
            for (y = 0; y < img.Height; y++)
            {
                Color pixel = img.GetPixel(x, y);
                int grey = (pixel.R + pixel.G + pixel.B) / 3;
                Color greyColour = Color.FromArgb(grey, grey, grey);
                img.SetPixel(x, y, greyColour);
            }
        }
        
        return img;
    }
}