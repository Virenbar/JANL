using System;
using System.Diagnostics;
using System.IO;

namespace JANL.Helpers
{
    [Obsolete("Use IOHelper")]
    public static class FS
    {
        /// <summary>
		/// Creates and opens folder
		/// </summary>
		/// <param name="path"></param>
        public static void OpenFolder(string path) => IOHelper.OpenFolder(path);

        /// <summary>
		/// Opens folder and selects file
		/// </summary>
		/// <param name="file"></param>
        public static void OpenFolderSelect(string file) => IOHelper.OpenFolderSelect(file);

        /// <summary>
        /// Opens folder and selects file
        /// </summary>
        /// <param name="file"></param>
        public static void OpenFolderSelect(FileInfo file) => IOHelper.OpenFolderSelect(file.FullName);
    }
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