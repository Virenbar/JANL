using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JANL.Helpers
{
    /// <summary>
    /// Вспомогательные методы работы с <see cref="string"/>
    /// </summary>
    public static class TextHelper
    {
        private readonly static HashSet<Type> TextControls = new HashSet<Type> { typeof(Button), typeof(Label), typeof(GroupBox), typeof(TabPage), typeof(ToolStripMenuItem), typeof(ToolStripDropDownButton), typeof(CheckBox) };
        private readonly static Regex Vowels = new Regex("[уеыаоэяиюУЕЫАОЭЯИЮ]");

        /// <summary>
        /// Удаляет из строки
        /// </summary>
        /// <param name="str">Строка</param>
        public static string RemoveVowels(string str) => Vowels.Replace(str, "");

        /// <summary>
        /// Удаляет гласные из всех текстов
        /// </summary>
        /// <param name="control"></param>
        public static void VowelsBegone(Control control)
        {
            Type type = control.GetType();
            if (TextControls.Contains(type) || type.IsSubclassOf(typeof(Form)) || type.IsSubclassOf(typeof(ToolStrip)))
            {
                control.Text = RemoveVowels(control.Text);
            }
            if (type.IsSubclassOf(typeof(ToolStrip)))
            {
                foreach (ToolStripItem I in ((ToolStrip)control).Items)
                {
                    VowelsBegone(I);
                }
            }
            if (control.Controls.Count > 0)
            {
                foreach (Control C in control.Controls)
                {
                    VowelsBegone(C);
                }
            }
        }

        /// <summary>
        /// Удаляет гласные из всех текстов
        /// </summary>
        /// <param name="control"></param>
        public static void VowelsBegone(ToolStripItem control)
        {
            control.Text = RemoveVowels(control.Text);
            Type type = control.GetType();
            if (type.IsSubclassOf(typeof(ToolStripDropDownItem)))
            {
                foreach (ToolStripItem I in ((ToolStripDropDownItem)control).DropDownItems)
                {
                    VowelsBegone(I);
                }
            }
        }
    }
}