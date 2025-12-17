using System;
using System.Diagnostics;
using System.IO;

namespace JANL.Helpers
{
    /// <summary>
    /// IO helper
    /// </summary>
    public static class IOHelper
    {
        /// <summary>
        /// Creates and opens folder
        /// </summary>
        /// <param name="path"></param>
        public static void OpenFolder(string path)
        {
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            Process.Start(path);
        }

        /// <summary>
		/// Opens folder and selects file
		/// </summary>
		/// <param name="file"></param>
        public static void OpenFolderSelect(string file) => Process.Start("explorer.exe", "/select,\"" + file + "\"");

        /// <summary>
        /// Opens folder and selects file
        /// </summary>
        /// <param name="file"></param>
        public static void OpenFolderSelect(FileInfo file) => OpenFolderSelect(file.FullName);
    }
}