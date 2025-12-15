using System.Drawing;

namespace JANL.Helpers
{
    public static class ColorHelper
    {
        /// <summary>
        /// .NET Color to HEX string
        /// </summary>
        public static string ColorToHEX(Color color) => $"#{color.R:X2}{color.G:X2}{color.B:X2}";

        /// <summary>
        /// HSL color to .NET color
        /// </summary>
        /// <param name="H">hue</param>
        /// <param name="S">saturation</param>
        /// <param name="L">luminosity</param>
        public static Color HSLToColor(double H, double S, double L)
        {
            if (S == 0) { return ColorFromComponent(L); }

            H /= 360;

            var q = L < 0.5 ? L * (1 + S) : L + S - (L * S);
            var p = L * 2 - q;

            var r = ColorComponent(p, q, H + 1.0 / 3.0);
            var g = ColorComponent(p, q, H);
            var b = ColorComponent(p, q, H - 1.0 / 3.0);

            return ColorFromComponent(r, g, b);
        }

        private static double ColorComponent(double p, double q, double t)
        {
            if (t < 0) t++;
            if (t > 1) t--;

            if (t < 1.0 / 6.0) return p + (q - p) * 6.0 * t;
            if (t < 0.5) return q;
            if (t < 2.0 / 3.0) return p + ((q - p) * ((2.0 / 3.0) - t) * 6.0);
            return p;
        }

        private static Color ColorFromComponent(double L) => ColorFromComponent(L, L, L);

        private static Color ColorFromComponent(double R, double G, double B) => Color.FromArgb((int)(255 * R), (int)(255 * G), (int)(255 * B));
    }
}