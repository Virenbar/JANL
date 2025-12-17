using JANL.Extensions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JANL.Beep
{
    /// <summary>
    /// Нота для <see cref="Song"/>
    /// </summary>
    public struct Note : IEquatable<Note>
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

        /// <summary>
        /// Создаёт новую ноту
        /// </summary>
        /// <param name="value">Длина ноты</param>
        public Note(double value)
        {
            Value = value;
            Frequency = 0;
            Number = 0;
            Octave = 0;
        }

        /// <summary>
        /// Создаёт новую ноту
        /// </summary>
        /// <param name="note">Название ноты</param>
        /// <param name="value">Длина ноты</param>
        public Note(NoteName note, double value) : this((int)note, 4, value) { }

        /// <summary>
        /// Создаёт новую ноту
        /// </summary>
        /// <param name="note">Название ноты</param>
        /// <param name="octave">Октава ноты</param>
        /// <param name="value">Длина ноты</param>
        public Note(NoteName note, int octave, double value) : this((int)note, octave, value) { }

        /// <summary>
        /// Создаёт новую ноту
        /// </summary>
        /// <param name="note">Номер ноты (4 октава)</param>
        /// <param name="octave">Октава ноты</param>
        /// <param name="value">Длина ноты</param>
        public Note(int note, int octave, double value) : this(value)
        {
            if (note == 0) { return; }
            Octave = octave;
            Number = note - 12 * (4 - octave);
            Frequency = (int)(A440 * Math.Pow(2, (Number - 69) / 12d));
        }

        /// <summary>
        /// Частота ноты
        /// </summary>
        public int Frequency { get; private set; }

        /// <summary>
        /// Номер ноты (MIDI)
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Номер октавы ноты
        /// </summary>
        public int Octave { get; private set; }

        /// <summary>
        /// Длина ноты
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        /// Длительность воспроизведения
        /// </summary>
        /// <param name="tempo">Темп воспроизведения</param>
        /// <param name="value">Длина ноты</param>
        /// <returns></returns>
        public static int GetDuration(int tempo, double value) => (int)(GetDuration(tempo) * value * 4);

        /// <summary>
        /// Длительность воспроизведения
        /// </summary>
        /// <param name="tempo">Темп воспроизведения</param>
        public static int GetDuration(int tempo) => 60_000 / tempo;

        /// <summary>
        /// Преобразует текстовое представление ноты в <see cref="Note"/>
        /// </summary>
        /// <param name="note">Текстовое представление ноты</param>
        public static Note Parse(string note)
        {
            var M = RNote.Match(note);
            var pitch = M.Groups["Pitch"].Value;
            var octave = M.Groups["Octave"].Value.NullIfEmpty() ?? "4";
            var value = M.Groups["Value"].Value.NullIfEmpty() ?? "Q";

            var N = new Note(NoteNumber[pitch], int.Parse(octave), NoteValues[value]);
            return N;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static int ParseNumber(string note)
        {
            var M = RNumber.Match(note);
            var pitch = M.Groups["Pitch"].Value;
            var octave = M.Groups["Octave"].Value.NullIfEmpty() ?? "4";

            return NoteNumber[pitch] - 12 * (4 - int.Parse(octave));
        }

        /// <summary>
        /// Длительность ноты
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public int Duration(int tempo) => GetDuration(tempo, Value);

        /// <summary>
        /// Указывает, равен ли текущий объект другому объекту того же типа
        /// </summary>
        /// <param name="other">Объект, который требуется сравнить с данным объектом</param>
        public bool Equals(Note other)
        {
            return Number == other.Number
                && Frequency == other.Frequency
                && Value == other.Value;
        }
    }

    /// <summary>
    /// Названия нот
    /// </summary>
    public enum NoteName
    {
        /// <summary>
        /// Пропуск ноты
        /// </summary>
        REST = 0,

        /// <summary>
        /// B♯/C
        /// </summary>
        C = 60,

        /// <summary>
        /// C♯/D♭
        /// </summary>
        C_D = 61,

        /// <summary>
        /// D
        /// </summary>
        D = 62,

        /// <summary>
        /// D♯/E♭
        /// </summary>
        D_E = 63,

        /// <summary>
        /// E/F♭
        /// </summary>
        E = 64,

        /// <summary>
        /// E♯/F
        /// </summary>
        F = 65,

        /// <summary>
        /// F♯/G♭
        /// </summary>
        F_G = 66,

        /// <summary>
        /// G
        /// </summary>
        G = 67,

        /// <summary>
        /// G♯/A♭
        /// </summary>
        G_A = 68,

        /// <summary>
        /// A
        /// </summary>
        A = 69,

        /// <summary>
        /// A♯/B♭
        /// </summary>
        A_B = 70,

        /// <summary>
        /// B/C♭
        /// </summary>
        B = 71
    }
}