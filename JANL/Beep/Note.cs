using JANL.Extensions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JANL.Beep
{
    public struct Note
    {
        private const int A440 = 440;
        private static readonly Dictionary<string, int> NoteNumber = new Dictionary<string, int>();
        private static readonly Dictionary<string, double> NoteValues = new Dictionary<string, double>();
        private static readonly Regex RNote = new Regex(@"(?<Pitch>[A-G][#b]?|R)(?<Octave>[0-8])?(?<Value>[WHQES]\.{0,3})?", RegexOptions.IgnoreCase);
        private static readonly Regex RNoteSS = new Regex(@"(?<Notes>(?>[A-GR][#bn]?[0-8]?-?)+)\/?(?<Value>\d.\d+)?", RegexOptions.IgnoreCase);
        private static readonly Regex RNumber = new Regex(@"(?<Pitch>[A-G][#bn]?|R)(?<Octave>[0-8])?", RegexOptions.IgnoreCase & RegexOptions.Compiled);
        //(?<Note>((?<Pitch>[A-G][#b]?|R)(?<Octave>[0-8])?-?)+)(?<Value>\/\d.\d+)?

        static Note()
        {
            NoteNumber.Add("R", 0);
            NoteNumber.Add("C", 60);
            NoteNumber.Add("C#", 61); NoteNumber.Add("Db", 61);
            NoteNumber.Add("D", 62);
            NoteNumber.Add("D#", 63); NoteNumber.Add("Eb", 63);
            NoteNumber.Add("E", 64);
            NoteNumber.Add("F", 65);
            NoteNumber.Add("F#", 66); NoteNumber.Add("Gb", 66);
            NoteNumber.Add("G", 67);
            NoteNumber.Add("G#", 68); NoteNumber.Add("Ab", 68);
            NoteNumber.Add("A", 69);
            NoteNumber.Add("A#", 70); NoteNumber.Add("Bb", 70);
            NoteNumber.Add("B", 71);

            var names = new[] { "W", "H", "Q", "E", "S" };
            var initial = 1d;
            foreach (var name in names)
            {
                var value = 0d;
                for (int i = 0; i <= 3; i++)
                {
                    value += initial / Math.Pow(2, i);
                    NoteValues.Add(name + new string('.', i), value);
                }
                initial /= 2;
            }
        }

        public Note(double value)
        {
            Value = value;
            Frequency = 0;
            Number = 0;
            Octave = 0;
        }

        public Note(NoteName note, double value) : this((int)note, 4, value) { }

        public Note(NoteName note, int octave, double value) : this((int)note, octave, value) { }

        public Note(int note, int octave, double value) : this(value)
        {
            if (note == 0) { return; }
            Octave = octave;
            Number = note - 12 * (4 - octave);
            Frequency = (int)(A440 * Math.Pow(2, (Number - 69) / 12d));
        }

        public int Frequency { get; private set; }
        public int Number { get; private set; }
        public int Octave { get; private set; }
        public double Value { get; private set; }

        public static int GetDuration(int tempo, double value) => (int)(GetDuration(tempo) * value * 4);

        public static int GetDuration(int tempo) => 60_000 / tempo;

        public static Note Parse(string note)
        {
            var M = RNote.Match(note);
            var pitch = M.Groups["Pitch"].Value;
            var octave = M.Groups["Octave"].Value.NullIfEmpty() ?? "4";
            var value = M.Groups["Value"].Value.NullIfEmpty() ?? "Q";

            var N = new Note(NoteNumber[pitch], int.Parse(octave), NoteValues[value]);
            return N;
        }

        public static int ParseNumber(string note)
        {
            var M = RNumber.Match(note);
            var pitch = M.Groups["Pitch"].Value;
            var octave = M.Groups["Octave"].Value.NullIfEmpty() ?? "4";

            return NoteNumber[pitch] - 12 * (4 - int.Parse(octave));
        }

        public int Duration(int tempo) => GetDuration(tempo, Value);
    }

    public enum NoteName
    {
        REST = 0,
        C = 60,
        C_D = 61,
        D = 62,
        D_E = 63,
        E = 64,
        F = 65,
        F_G = 66,
        G = 67,
        G_A = 68,
        A = 69,
        A_B = 70,
        B = 71
    }
}