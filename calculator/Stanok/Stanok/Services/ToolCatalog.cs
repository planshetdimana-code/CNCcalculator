using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Stanok.Models;

namespace Stanok.Services;

public static class ToolCatalog
{
    private static readonly double[] Diameters =
    {
        1, 1.1, 1.2, 1.3, 1.5, 1.6, 2, 2.5, 3, 4, 5, 6, 8, 10, 12, 14, 16, 18, 20, 22
    };

    public static IReadOnlyList<Tool> GetTools()
    {
        var list = new List<Tool>();
        var dir = EnsureImagesDirectory();

        foreach (var d in Diameters)
        {
            var flutes = d switch
            {
                <= 2.0 => 2,
                <= 5.0 => 3,
                < 22.0 => 4,
                _ => 6
            };

            var imgPath = Path.Combine(dir, $"tool_{d.ToString("0.0").Replace(',', '.')}.png");
            if (!File.Exists(imgPath))
            {
                GenerateIcon(imgPath, d, flutes);
            }
            list.Add(new Tool { Diameter = d, Flutes = flutes, ImagePath = imgPath });
        }

        return list;
    }

    private static string EnsureImagesDirectory()
    {
        var dir = Path.Combine(AppContext.BaseDirectory, "Data", "Tools");
        Directory.CreateDirectory(dir);
        return dir;
    }

    private static void GenerateIcon(string path, double diameter, int flutes)
    {
        using var bmp = new Bitmap(128, 128);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.White);

        var randHue = (int)(diameter * 25) % 360;
        var color = HsvToColor(randHue, 0.4, 0.95);
        using var brush = new SolidBrush(color);
        using var pen = new Pen(Color.DimGray, 2);

        var rect = new Rectangle(12, 12, 104, 104);
        g.FillEllipse(brush, rect);
        g.DrawEllipse(pen, rect);

        // Draw flutes as small arcs
        using var flutePen = new Pen(Color.White, 3);
        var step = 360.0 / flutes;
        for (int i = 0; i < flutes; i++)
        {
            float startAngle = (float)(i * step - 10);
            g.DrawArc(flutePen, rect, startAngle, 20);
        }

        // Text Ø and value
        using var f = new Font("Segoe UI", 12, FontStyle.Bold);
        var text = $"Ø{diameter:0.0}".Replace(',', '.');
        var size = g.MeasureString(text, f);
        g.DrawString(text, f, Brushes.Black, (bmp.Width - size.Width) / 2, 48);

        bmp.Save(path, ImageFormat.Png);
    }

    private static Color HsvToColor(double h, double s, double v)
    {
        h = (h % 360 + 360) % 360;
        double c = v * s;
        double x = c * (1 - Math.Abs((h / 60) % 2 - 1));
        double m = v - c;
        double r1=0, g1=0, b1=0;
        if (h < 60) { r1 = c; g1 = x; }
        else if (h < 120) { r1 = x; g1 = c; }
        else if (h < 180) { g1 = c; b1 = x; }
        else if (h < 240) { g1 = x; b1 = c; }
        else if (h < 300) { r1 = x; b1 = c; }
        else { r1 = c; b1 = x; }
        return Color.FromArgb(
            255,
            (int)((r1 + m) * 255),
            (int)((g1 + m) * 255),
            (int)((b1 + m) * 255));
    }
}

