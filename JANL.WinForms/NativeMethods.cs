using System;
using System.Runtime.InteropServices;

namespace JANL
{
    internal static class NativeMethods
    {
        /// <summary>
        /// Уничтожить иконку
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DestroyIcon(IntPtr handle);

        [DllImport("User32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr handle);
    }
}