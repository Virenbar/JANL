using JANL.Extensions;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace JANL.Forms
{
    public partial class FormFileEdit : Form
    {
        private readonly FileInfo File;
        private Process Editor;
        private SyncEvent Event;
        private FileSystemWatcher FSW;
        private DateTime LastWrite;

        public FormFileEdit(string FilePath)
        {
            InitializeComponent();
            File = new FileInfo(FilePath);
            L_Name.Text = File.Name;
        }

        public bool IsChanged { get; private set; }

        private void Editor_Exited(object sender, EventArgs e)
        {
            if (!Editor.HasExited) { return; }
            Editor = null;
            this.InvokeAction(RefreshUI);
        }

        private void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            this.InvokeAction(RefreshUI);
        }

        private void OpenFile()
        {
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
                L_Process.Text = Editor.ProcessName;
                Editor.EnableRaisingEvents = true;
                Editor.Exited += Editor_Exited;
            }
            else
            {
                var W = Editor.MainWindowHandle;
                NativeMethods.SetForegroundWindow(W);
            }
            RefreshUI();
        }

        private void RefreshUI()
        {
            File.Refresh();
            L_Date.Text = File.LastWriteTime.ToString(CultureInfo.InvariantCulture);
            if (File.LastWriteTime > LastWrite)
            {
                IsChanged = true;
                B_OK.Enabled = true;
            }
        }

        #region UI Events

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            //DialogResult Cancel
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            //DialogResult OK
        }

        private void B_Open_Click(object sender, EventArgs e) => OpenFile();

        private void FormFileEdit_Load(object sender, EventArgs e)
        {
            Event = new SyncEvent(this);
            OpenFile();
        }

        #endregion UI Events
    }
}