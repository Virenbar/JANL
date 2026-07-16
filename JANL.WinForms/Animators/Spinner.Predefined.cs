using System;
using System.Collections.Generic;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
// Spinners from https://github.com/sindresorhus/cli-spinners
namespace JANL.Animators
{
    public sealed class AestheticSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "▰▱▱▱▱▱▱",
            "▰▰▱▱▱▱▱",
            "▰▰▰▱▱▱▱",
            "▰▰▰▰▱▱▱",
            "▰▰▰▰▰▱▱",
            "▰▰▰▰▰▰▱",
            "▰▰▰▰▰▰▰",
            "▰▱▱▱▱▱▱"
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class ArcSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "◜",
            "◠",
            "◝",
            "◞",
            "◡",
            "◟"
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);
    }
    public sealed class AsciiSpinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);
    }
    public sealed class BinarySpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "010010",
            "001100",
            "100101",
            "111010",
            "111101",
            "010111",
            "101011",
            "111000",
            "110011",
            "110101"
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class CircleHalvesSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "◐",
            "◓",
            "◑",
            "◒",
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(50);
    }
    public sealed class ClockSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "🕛 ",
            "🕐 ",
            "🕑 ",
            "🕒 ",
            "🕓 ",
            "🕔 ",
            "🕕 ",
            "🕖 ",
            "🕗 ",
            "🕘 ",
            "🕙 ",
            "🕚 "
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);
    }
    public sealed class DefaultSpinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);
    }
    public sealed class Dots10Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots11Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(100);
    }
    public sealed class Dots12Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots2Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots3Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots4Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots5Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots6Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots7Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots8BitSpinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots8Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class Dots9Spinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class DotsSpinner : Spinner
    {
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

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(80);
    }
    public sealed class EarthSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "🌍 ",
            "🌎 ",
            "🌏 "
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(180);
    }
    public sealed class MindblownSpinner : Spinner
    {
        public override IReadOnlyList<string> Frames => new List<string>
        {
            "😐 ",
            "😐 ",
            "😮 ",
            "😮 ",
            "😦 ",
            "😦 ",
            "😧 ",
            "😧 ",
            "🤯 ",
            "💥 ",
            "✨ ",
            "\u3000 ",
            "\u3000 ",
            "\u3000 "
        };

        public override TimeSpan Interval => TimeSpan.FromMilliseconds(160);
    }
}