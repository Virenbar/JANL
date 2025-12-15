using System;
using System.Runtime.InteropServices;

namespace JANL
{
    internal static class NativeMethods
    {
        /// <summary>
        /// Уничтожает значок и освобождает память, занятую значком.
        /// </summary>
        /// <param name="handle">Дескриптор значка, который необходимо уничтожить. Значок не должен использоваться.</param>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool DestroyIcon(IntPtr handle);

        /// <summary>
        /// Переносит поток, который создал указанное окно на переднем плане и активирует окно
        /// </summary>
        /// <param name="handle">Дескриптор окна, который должен быть активирован и доставлен на передний план.</param>
        [DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr handle);
    }
}