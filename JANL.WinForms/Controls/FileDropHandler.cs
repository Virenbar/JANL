using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JANL.Controls

{
    /// <summary>
    /// Обработчик перетаскивания файла/папки
    /// </summary>
    public class FileDropHandler
    {
        private readonly HashSet<Control> Controls;

        /// <summary>
        /// Создаёт новый обработчик перетаскивания
        /// </summary>
        public FileDropHandler()
        {
            Controls = new HashSet<Control>();
        }

        /// <summary>
        /// Создаёт новый обработчик перетаскивания
        /// </summary>
        /// <param name="controls"></param>
        public FileDropHandler(IEnumerable<Control> controls) : this()
        {
            foreach (var control in controls)
            {
                AddControl(control);
            }
        }

        /// <summary>
        /// Создаёт новый обработчик перетаскивания
        /// </summary>
        /// <param name="control"></param>
        public FileDropHandler(Control control) : this()
        {
            AddControl(control);
        }

        /// <summary>
        /// Разрешить перетаскивание папок
        /// </summary>
        public bool AllowDirectories { get; set; }

        /// <summary>
        /// Разрешить перетаскивание файлов
        /// </summary>
        public bool AllowFiles { get; set; } = true;

        /// <summary>
        /// Добавляет элемент управления
        /// </summary>
        /// <param name="control"></param>
        public void AddControl(Control control)
        {
            if (Controls.Contains(control)) { return; }

            AddHandlers(control);
            Controls.Add(control);
        }

        /// <summary>
        /// Удаляет элемент управления
        /// </summary>
        /// <param name="control"></param>
        public void RemoveControl(Control control)
        {
            if (!Controls.Contains(control)) { return; }

            RemoveHandlers(control);
            Controls.Remove(control);
        }

        private void AddHandlers(Control control)
        {
            control.AllowDrop = true;
            control.DragEnter += Control_DragEnter;
            control.DragOver += Control_DragOver;

            control.DragDrop += Control_DragDrop;
        }

        private List<string> GetDirectories(DragEventArgs e)
        {
            if (!AllowDirectories) { return new List<string>(); }
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            return paths.Where(Directory.Exists).ToList();
        }

        private List<string> GetFiles(DragEventArgs e)
        {
            if (!AllowFiles) { return new List<string>(); }
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            return paths.Where(File.Exists).ToList();
        }

        private void RemoveHandlers(Control control)
        {
            control.AllowDrop = false;
            control.DragEnter -= Control_DragEnter;
            control.DragOver -= Control_DragOver;

            control.DragDrop -= Control_DragDrop;
        }

        #region Handlers

        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null) { return; }
            var files = GetFiles(e);
            var dirs = GetDirectories(e);
            if (files.Count + dirs.Count == 0) { return; }

            var args = new FileDropEventArgs((Control)sender)
            {
                Files = files,
                Directories = dirs
            };
            OnFileDrop(args);
        }

        private void Control_DragEnter(object sender, DragEventArgs e) => ProcessDrag(e);

        private void Control_DragOver(object sender, DragEventArgs e) => ProcessDrag(e);

        private void ProcessDrag(DragEventArgs e)
        {
            var Effect = DragDropEffects.None;
            if (e.Data is null) { return; }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = GetFiles(e);
                var dirs = GetDirectories(e);

                if (files.Count > 0 || dirs.Count > 0) { Effect = DragDropEffects.Link; }
            }
            e.Effect = Effect;
        }

        #endregion Handlers

        #region Events

        /// <summary>
        /// Вызывает событие <see cref="FileDrop"/>
        /// </summary>
        /// <param name="e"></param>
        protected void OnFileDrop(FileDropEventArgs e) => FileDrop?.Invoke(this, e);

        /// <summary>
        /// Происходит при успешном перетаскивании
        /// </summary>
        public event EventHandler<FileDropEventArgs> FileDrop;

        #endregion Events
    }
}