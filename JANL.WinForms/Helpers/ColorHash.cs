using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JANL.Helpers
{
    /// <summary>
    /// Generate color based on the given string
    /// </summary>
    /// <remarks>
    /// https://github.com/zenozeng/color-hash
    /// </remarks>
    public class ColorHash
    {
        private readonly Func<string, uint> hash;

        public ColorHash()
        {
            hash = SHA256Hash;

            HueRanges = new List<HueRange>();
            Saturations = new List<double> { 0.35, 0.5, 0.65 };
            Luminositiess = new List<double> { 0.35, 0.5, 0.65 };
        }

        public ColorHash(Func<string, uint> hash) : this()
        {
            this.hash = hash;
        }

        public List<HueRange> HueRanges { get; set; }

        public List<double> Luminositiess { get; set; }

        public List<double> Saturations { get; set; }

        public Color Compute(string str)
        {
            double H, S, L;
            double hash = this.hash(str);

            if (HueRanges.Count > 0)
            {
                var hueResolution = 727; // note that 727 is a prime
                var range = HueRanges[(int)hash % HueRanges.Count];
                H = ((hash / HueRanges.Count) % hueResolution) * (range.Max - range.Min) / hueResolution + range.Min;
            }
            else
            {
                H = hash % 359; // note that 359 is a prime
            }

            hash = Math.Ceiling(hash / 360d);
            S = Saturations[(int)hash % Saturations.Count];
            hash = Math.Ceiling(hash / Luminositiess.Count);
            L = Luminositiess[(int)hash % Luminositiess.Count];

            return ColorHelper.HSLToColor(H, S, L);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// https://github.com/zenozeng/color-hash/blob/main/lib/bkdr-hash.ts
        /// </remarks>
        static public uint BKDRHash(string str)
        {
            var seed = 131u;
            var seed2 = 137u;
            var hash = 0u;
            // make hash more sensitive for short string like 'a', 'b', 'c'
            str += 'x';
            // Note: Number.MAX_SAFE_INTEGER equals 9007199254740991
            var MAX_SAFE_INTEGER = 9007199254740991 / seed2;
            for (var i = 0; i < str.Length; i++)
            {
                if (hash > MAX_SAFE_INTEGER)
                {
                    hash = hash / seed2;
                }
                hash = hash * seed + str[i];
            }
            return hash;
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// https://github.com/zenozeng/color-hash/blob/main/lib/sha256.ts
        /// </remarks>
        static public uint SHA256Hash(string str)
        {
            using (var hash = SHA256.Create())
            {
                var bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                var hex = string.Concat(bytes.Select(item => item.ToString("x2")));
                return Convert.ToUInt32($"0x{hex.Substring(0, 8)}", 16);
            }
        }

        static public uint HashCode(string str) => (uint)str.GetHashCode();

        public struct HueRange

        {
            public int Max { get; set; }
            public int Min { get; set; }
        }
    }
}