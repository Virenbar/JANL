using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace JANL.Beep
{
    public class Song
    {
        private static readonly Regex RBPM = new Regex(@"(?>BPM=)\d+", RegexOptions.IgnoreCase);
        public bool Playing { get; protected set; }
        public List<Note> Notes { get; } = new List<Note>();
        public int Tempo { get; private set; } = 150;

        public static Song Parse(string song, int tempo)
        {
            var S = Parse(song);
            S.Tempo = tempo;
            return S;
        }

        public static Song Parse(string song)
        {
            var S = new Song();
            var notes = song.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var note in notes)
            {
                var BPM = RBPM.Match(note);
                if (BPM.Success)
                {
                    S.Tempo = int.Parse(BPM.Groups[0].Value);
                    continue;
                }
                S.Notes.Add(Note.Parse(note));
            }
            return S;
        }

        public static Song Parse(IEnumerable<string> song) => Parse(string.Join(",", song));

        public static Song Parse(IEnumerable<string> song, int tempo) => Parse(string.Join(",", song), tempo);

        public void Play()
        {
            if (Playing) { return; }
            Playing = true;
            foreach (var note in Notes)
            {
                if (!Playing) { return; }
                if (note.Frequency < 37)
                {
                    Thread.Sleep(note.Duration(Tempo));
                }
                else
                {
                    Console.Beep(note.Frequency, note.Duration(Tempo));
                }
            }
            Playing = false;
        }

        public async Task PlayAsync(CancellationToken CT)
        {
            if (Playing) { return; }
            Playing = true;
            foreach (var note in Notes)
            {
                if (!Playing) { return; }
                CT.ThrowIfCancellationRequested();
                if (note.Frequency < 37)
                {
                    await Task.Delay(note.Duration(Tempo));
                }
                else
                {
                    await Task.Run(() => Console.Beep(note.Frequency, note.Duration(Tempo)));
                }
            }
            Playing = false;
        }

        public void Stop() => Playing = false;
    }
}