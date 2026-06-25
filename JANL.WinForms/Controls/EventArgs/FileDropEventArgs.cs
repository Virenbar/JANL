using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JANL.Controls

{
    /// <summary>
    /// Данные события <see cref="FileDropHandler.FileDrop"/>
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="control"></param>
        public FileDropEventArgs(Control control)
        {
            Control = control;
        }

        /// <summary>
        /// Элемент управления
        /// </summary>
        public Control Control { get; set; }

        /// <summary>
        /// Перетасканные папки
        /// </summary>
        public List<string> Directories { get; set; }

        /// <summary>
        /// Перетасканные файлы
        /// </summary>
        public List<string> Files { get; set; }
    }
}