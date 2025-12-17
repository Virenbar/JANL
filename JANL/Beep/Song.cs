using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace JANL.Beep
{
    /// <summary>
    ///
    /// </summary>
    public class Song
    {
        private static readonly Regex RBPM = new Regex(@"(?>BPM=)\d+", RegexOptions.IgnoreCase);

        /// <summary>
        /// Запущенно ли воспроизведение
        /// </summary>
        public bool Playing { get; protected set; }

        /// <summary>
        /// Список нот для воспроизведения
        /// </summary>
        public List<Note> Notes { get; } = new List<Note>();

        /// <summary>
        /// Текущий темп воспроизведения
        /// </summary>
        public int Tempo { get; private set; } = 150;

        /// <summary>
        ///
        /// </summary>
        /// <param name="song"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public static Song Parse(string song, int tempo)
        {
            var S = Parse(song);
            S.Tempo = tempo;
            return S;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
        public static Song Parse(IEnumerable<string> song) => Parse(string.Join(",", song));

        /// <summary>
        ///
        /// </summary>
        /// <param name="song"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public static Song Parse(IEnumerable<string> song, int tempo) => Parse(string.Join(",", song), tempo);

        /// <summary>
        /// Запускает воспроизведение
        /// </summary>
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

        /// <summary>
        /// Асинхронно запускает воспроизведение
        /// </summary>
        /// <param name="CT"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Останавливает воспроизведение
        /// </summary>
        public void Stop() => Playing = false;
    }
}