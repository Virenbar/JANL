using System;
using System.Collections.Generic;

namespace JANL.Animators
{
    /// <summary>
    /// Spinner
    /// </summary>
    public abstract class Spinner
    {
        /// <summary>
        /// Frames
        /// </summary>
        public abstract IReadOnlyList<string> Frames { get; }

        /// <summary>
        /// Interval between frames
        /// </summary>
        public abstract TimeSpan Interval { get; }

        /// <summary>
        /// Contains all predefined spinners.
        /// </summary>
        public static class Predefined
        {
            /// <summary>
            /// Gets the "Aesthetic" spinner.
            /// </summary>
            public static Spinner Aesthetic { get; } = new AestheticSpinner();

            /// <summary>
            /// Gets the "Arc" spinner.
            /// </summary>
            public static Spinner Arc { get; } = new ArcSpinner();

            /// <summary>
            /// Gets the "Ascii" spinner.
            /// </summary>
            public static Spinner Ascii { get; } = new AsciiSpinner();

            /// <summary>
            /// Gets the "Binary" spinner.
            /// </summary>
            public static Spinner Binary { get; } = new BinarySpinner();

            /// <summary>
            /// Gets the "circleHalves" spinner.
            /// </summary>
            public static Spinner CircleHalves { get; } = new CircleHalvesSpinner();

            /// <summary>
            /// Gets the "Clock" spinner.
            /// </summary>
            public static Spinner Clock { get; } = new ClockSpinner();

            /// <summary>
            /// Gets the "Default" spinner.
            /// </summary>
            public static Spinner Default { get; } = new DefaultSpinner();

            /// <summary>
            /// Gets the "dots" spinner.
            /// </summary>
            public static Spinner Dots { get; } = new DotsSpinner();

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
            /// Gets the "dots8Bit" spinner.
            /// </summary>
            public static Spinner Dots8Bit { get; } = new Dots8BitSpinner();

            /// <summary>
            /// Gets the "dots9" spinner.
            /// </summary>
            public static Spinner Dots9 { get; } = new Dots9Spinner();

            /// <summary>
            /// Gets the "Earth" spinner.
            /// </summary>
            public static Spinner Earth { get; } = new EarthSpinner();

            /// <summary>
            /// Gets the "Mindblown" spinner.
            /// </summary>
            public static Spinner Mindblown { get; } = new MindblownSpinner();
        }
    }
}