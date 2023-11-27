using System;
using System.Collections.Generic;

namespace JANL.Animators
{
    public abstract partial class Spinner
    {
        public sealed class DefaultSpinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⣷",
                "⣯",
                "⣟",
                "⡿",
                "⢿",
                "⣻",
                "⣽",
                "⣾",
            };
        }
        private sealed class AsciiSpinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                @"-",
                @"\",
                @"|",
                @"/",
                @"-",
                @"\",
                @"|",
                @"/",
            };
        }
        private sealed class DotsSpinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠋",
                "⠙",
                "⠹",
                "⠸",
                "⠼",
                "⠴",
                "⠦",
                "⠧",
                "⠇",
                "⠏",
            };
        }
        private sealed class Dots2Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⣾",
                "⣽",
                "⣻",
                "⢿",
                "⡿",
                "⣟",
                "⣯",
                "⣷",
            };
        }
        private sealed class Dots3Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠋",
                "⠙",
                "⠚",
                "⠞",
                "⠖",
                "⠦",
                "⠴",
                "⠲",
                "⠳",
                "⠓",
            };
        }
        private sealed class Dots4Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠄",
                "⠆",
                "⠇",
                "⠋",
                "⠙",
                "⠸",
                "⠰",
                "⠠",
                "⠰",
                "⠸",
                "⠙",
                "⠋",
                "⠇",
                "⠆",
            };
        }
        private sealed class Dots5Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠋",
                "⠙",
                "⠚",
                "⠒",
                "⠂",
                "⠂",
                "⠒",
                "⠲",
                "⠴",
                "⠦",
                "⠖",
                "⠒",
                "⠐",
                "⠐",
                "⠒",
                "⠓",
                "⠋",
            };
        }
        private sealed class Dots6Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠁",
                "⠉",
                "⠙",
                "⠚",
                "⠒",
                "⠂",
                "⠂",
                "⠒",
                "⠲",
                "⠴",
                "⠤",
                "⠄",
                "⠄",
                "⠤",
                "⠴",
                "⠲",
                "⠒",
                "⠂",
                "⠂",
                "⠒",
                "⠚",
                "⠙",
                "⠉",
                "⠁",
            };
        }
        private sealed class Dots7Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠈",
                "⠉",
                "⠋",
                "⠓",
                "⠒",
                "⠐",
                "⠐",
                "⠒",
                "⠖",
                "⠦",
                "⠤",
                "⠠",
                "⠠",
                "⠤",
                "⠦",
                "⠖",
                "⠒",
                "⠐",
                "⠐",
                "⠒",
                "⠓",
                "⠋",
                "⠉",
                "⠈",
            };
        }
        private sealed class Dots8Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠁",
                "⠁",
                "⠉",
                "⠙",
                "⠚",
                "⠒",
                "⠂",
                "⠂",
                "⠒",
                "⠲",
                "⠴",
                "⠤",
                "⠄",
                "⠄",
                "⠤",
                "⠠",
                "⠠",
                "⠤",
                "⠦",
                "⠖",
                "⠒",
                "⠐",
                "⠐",
                "⠒",
                "⠓",
                "⠋",
                "⠉",
                "⠈",
                "⠈",
            };
        }
        private sealed class Dots9Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⢹",
                "⢺",
                "⢼",
                "⣸",
                "⣇",
                "⡧",
                "⡗",
                "⡏",
            };
        }
        private sealed class Dots10Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⢄",
                "⢂",
                "⢁",
                "⡁",
                "⡈",
                "⡐",
                "⡠",
            };
        }
        private sealed class Dots11Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠁",
                "⠂",
                "⠄",
                "⡀",
                "⢀",
                "⠠",
                "⠐",
                "⠈",
            };
        }
        private sealed class Dots12Spinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⢀⠀",
                "⡀⠀",
                "⠄⠀",
                "⢂⠀",
                "⡂⠀",
                "⠅⠀",
                "⢃⠀",
                "⡃⠀",
                "⠍⠀",
                "⢋⠀",
                "⡋⠀",
                "⠍⠁",
                "⢋⠁",
                "⡋⠁",
                "⠍⠉",
                "⠋⠉",
                "⠋⠉",
                "⠉⠙",
                "⠉⠙",
                "⠉⠩",
                "⠈⢙",
                "⠈⡙",
                "⢈⠩",
                "⡀⢙",
                "⠄⡙",
                "⢂⠩",
                "⡂⢘",
                "⠅⡘",
                "⢃⠨",
                "⡃⢐",
                "⠍⡐",
                "⢋⠠",
                "⡋⢀",
                "⠍⡁",
                "⢋⠁",
                "⡋⠁",
                "⠍⠉",
                "⠋⠉",
                "⠋⠉",
                "⠉⠙",
                "⠉⠙",
                "⠉⠩",
                "⠈⢙",
                "⠈⡙",
                "⠈⠩",
                "⠀⢙",
                "⠀⡙",
                "⠀⠩",
                "⠀⢘",
                "⠀⡘",
                "⠀⠨",
                "⠀⢐",
                "⠀⡐",
                "⠀⠠",
                "⠀⢀",
                "⠀⡀",
            };
        }
        private sealed class Dots8BitSpinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "⠀",
                "⠁",
                "⠂",
                "⠃",
                "⠄",
                "⠅",
                "⠆",
                "⠇",
                "⡀",
                "⡁",
                "⡂",
                "⡃",
                "⡄",
                "⡅",
                "⡆",
                "⡇",
                "⠈",
                "⠉",
                "⠊",
                "⠋",
                "⠌",
                "⠍",
                "⠎",
                "⠏",
                "⡈",
                "⡉",
                "⡊",
                "⡋",
                "⡌",
                "⡍",
                "⡎",
                "⡏",
                "⠐",
                "⠑",
                "⠒",
                "⠓",
                "⠔",
                "⠕",
                "⠖",
                "⠗",
                "⡐",
                "⡑",
                "⡒",
                "⡓",
                "⡔",
                "⡕",
                "⡖",
                "⡗",
                "⠘",
                "⠙",
                "⠚",
                "⠛",
                "⠜",
                "⠝",
                "⠞",
                "⠟",
                "⡘",
                "⡙",
                "⡚",
                "⡛",
                "⡜",
                "⡝",
                "⡞",
                "⡟",
                "⠠",
                "⠡",
                "⠢",
                "⠣",
                "⠤",
                "⠥",
                "⠦",
                "⠧",
                "⡠",
                "⡡",
                "⡢",
                "⡣",
                "⡤",
                "⡥",
                "⡦",
                "⡧",
                "⠨",
                "⠩",
                "⠪",
                "⠫",
                "⠬",
                "⠭",
                "⠮",
                "⠯",
                "⡨",
                "⡩",
                "⡪",
                "⡫",
                "⡬",
                "⡭",
                "⡮",
                "⡯",
                "⠰",
                "⠱",
                "⠲",
                "⠳",
                "⠴",
                "⠵",
                "⠶",
                "⠷",
                "⡰",
                "⡱",
                "⡲",
                "⡳",
                "⡴",
                "⡵",
                "⡶",
                "⡷",
                "⠸",
                "⠹",
                "⠺",
                "⠻",
                "⠼",
                "⠽",
                "⠾",
                "⠿",
                "⡸",
                "⡹",
                "⡺",
                "⡻",
                "⡼",
                "⡽",
                "⡾",
                "⡿",
                "⢀",
                "⢁",
                "⢂",
                "⢃",
                "⢄",
                "⢅",
                "⢆",
                "⢇",
                "⣀",
                "⣁",
                "⣂",
                "⣃",
                "⣄",
                "⣅",
                "⣆",
                "⣇",
                "⢈",
                "⢉",
                "⢊",
                "⢋",
                "⢌",
                "⢍",
                "⢎",
                "⢏",
                "⣈",
                "⣉",
                "⣊",
                "⣋",
                "⣌",
                "⣍",
                "⣎",
                "⣏",
                "⢐",
                "⢑",
                "⢒",
                "⢓",
                "⢔",
                "⢕",
                "⢖",
                "⢗",
                "⣐",
                "⣑",
                "⣒",
                "⣓",
                "⣔",
                "⣕",
                "⣖",
                "⣗",
                "⢘",
                "⢙",
                "⢚",
                "⢛",
                "⢜",
                "⢝",
                "⢞",
                "⢟",
                "⣘",
                "⣙",
                "⣚",
                "⣛",
                "⣜",
                "⣝",
                "⣞",
                "⣟",
                "⢠",
                "⢡",
                "⢢",
                "⢣",
                "⢤",
                "⢥",
                "⢦",
                "⢧",
                "⣠",
                "⣡",
                "⣢",
                "⣣",
                "⣤",
                "⣥",
                "⣦",
                "⣧",
                "⢨",
                "⢩",
                "⢪",
                "⢫",
                "⢬",
                "⢭",
                "⢮",
                "⢯",
                "⣨",
                "⣩",
                "⣪",
                "⣫",
                "⣬",
                "⣭",
                "⣮",
                "⣯",
                "⢰",
                "⢱",
                "⢲",
                "⢳",
                "⢴",
                "⢵",
                "⢶",
                "⢷",
                "⣰",
                "⣱",
                "⣲",
                "⣳",
                "⣴",
                "⣵",
                "⣶",
                "⣷",
                "⢸",
                "⢹",
                "⢺",
                "⢻",
                "⢼",
                "⢽",
                "⢾",
                "⢿",
                "⣸",
                "⣹",
                "⣺",
                "⣻",
                "⣼",
                "⣽",
                "⣾",
                "⣿",
            };
        }
        private sealed class CircleHalvesSpinner : Spinner
        {
            public override TimeSpan Interval => TimeSpan.FromMilliseconds(50);

            public override IReadOnlyList<string> Frames => new List<string>
            {
                "◐",
                "◓",
                "◑",
                "◒",
            };
        }
        /// <summary>
        /// Contains all predefined spinners.
        /// </summary>
        public static class Predefined
        {
            /// <summary>
            /// Gets the "Default" spinner.
            /// </summary>
            public static Spinner Default { get; } = new DefaultSpinner();

            /// <summary>
            /// Gets the "Ascii" spinner.
            /// </summary>
            public static Spinner Ascii { get; } = new AsciiSpinner();

            /// <summary>
            /// Gets the "dots" spinner.
            /// </summary>
            public static Spinner Dots { get; } = new DotsSpinner();

            /// <summary>
            /// Gets the "dots2" spinner.
            /// </summary>
            public static Spinner Dots2 { get; } = new Dots2Spinner();

            /// <summary>
            /// Gets the "dots3" spinner.
            /// </summary>
            public static Spinner Dots3 { get; } = new Dots3Spinner();

            /// <summary>
            /// Gets the "dots4" spinner.
            /// </summary>
            public static Spinner Dots4 { get; } = new Dots4Spinner();

            /// <summary>
            /// Gets the "dots5" spinner.
            /// </summary>
            public static Spinner Dots5 { get; } = new Dots5Spinner();

            /// <summary>
            /// Gets the "dots6" spinner.
            /// </summary>
            public static Spinner Dots6 { get; } = new Dots6Spinner();

            /// <summary>
            /// Gets the "dots7" spinner.
            /// </summary>
            public static Spinner Dots7 { get; } = new Dots7Spinner();

            /// <summary>
            /// Gets the "dots8" spinner.
            /// </summary>
            public static Spinner Dots8 { get; } = new Dots8Spinner();

            /// <summary>
            /// Gets the "dots9" spinner.
            /// </summary>
            public static Spinner Dots9 { get; } = new Dots9Spinner();

            /// <summary>
            /// Gets the "dots10" spinner.
            /// </summary>
            public static Spinner Dots10 { get; } = new Dots10Spinner();

            /// <summary>
            /// Gets the "dots11" spinner.
            /// </summary>
            public static Spinner Dots11 { get; } = new Dots11Spinner();

            /// <summary>
            /// Gets the "dots12" spinner.
            /// </summary>
            public static Spinner Dots12 { get; } = new Dots12Spinner();

            /// <summary>
            /// Gets the "dots8Bit" spinner.
            /// </summary>
            public static Spinner Dots8Bit { get; } = new Dots8BitSpinner();

            /// <summary>
            /// Gets the "circleHalves" spinner.
            /// </summary>
            public static Spinner CircleHalves { get; } = new CircleHalvesSpinner();
        }
    }
}