using System.Drawing;
using System.Runtime.Versioning;
using Image = image_library.Image;

namespace test_project;

internal static class Program
{
    [SupportedOSPlatform("windows")]
    static void Main(string[] args)
    {
        var new_img = Image.ToGreyscale(new Bitmap(@"C:\Users\angel\Pictures\Screenshots\Screenshot 2025-04-02 132810.png"));
        new_img.Save(@"C:\Users\angel\Pictures\new_img.png");
    }
}