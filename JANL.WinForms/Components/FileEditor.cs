using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace JANL.Components
{
    [Obsolete("WIP")]
    internal partial class FileEditor : Component
    {
        private Process Editor;
        private SyncEvent Event;
        private FileSystemWatcher FSW;

        public FileEditor()
        {
            InitializeComponent();
        }

        public FileEditor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public FileInfo File { get; private set; }

        /// <summary>
        /// Изменился ли файл с момента открытия редактора
        /// </summary>
        public bool IsChanged { get; private set; }

        public DateTime LastWrite { get; private set; }

        private void Editor_Exited(object sender, EventArgs e)
        {
            if (!Editor.HasExited) { return; }
            Editor = null;
            CheckFile();
        }

        private void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            CheckFile();
        }

        private void OpenFile(FileInfo file)
        {
            File = file;
            LastWrite = File.LastWriteTime;
            var PSI = new ProcessStartInfo(File.FullName) { UseShellExecute = true };
            if (Editor == null)
            {
                FSW = new FileSystemWatcher(File.DirectoryName, File.Name)
                {
                    EnableRaisingEvents = true
                };
                FSW.Changed += FSW_Changed;

                Editor = Process.Start(PSI);
                // L_Process.Text = Editor.ProcessName;
                Editor.EnableRaisingEvents = true;
                Editor.Exited += Editor_Exited;
            }
            else
            {
                var W = Editor.MainWindowHandle;
                NativeMethods.SetForegroundWindow(W);
            }
            CheckFile();

        }

        private void CheckFile()
        {
            File.Refresh();
            //  L_Date.Text = File.LastWriteTime.ToString(CultureInfo.InvariantCulture);
            if (File.LastWriteTime > LastWrite)
            {
                IsChanged = true;
            }
        }

        public event EventHandler FileChanged;
    }
}