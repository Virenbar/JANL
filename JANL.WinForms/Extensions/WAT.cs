using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JANL.Extensions
{
    public static class WAT
    {
        private readonly static HashSet<Type> Txt = new HashSet<Type> { typeof(Button), typeof(Label), typeof(GroupBox), typeof(TabPage), typeof(ToolStripMenuItem), typeof(ToolStripDropDownButton), typeof(CheckBox) };
        private readonly static char[] Vowels;
        private readonly static char[] VowelsHalf = new[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю' };

        static WAT()
        {
            Vowels = VowelsHalf.Concat(VowelsHalf.AsEnumerable().Select(x => char.ToUpperInvariant(x))).ToArray();
        }

        public static void VowelsBegone(this Control cont)
        {
            if (Txt.Contains(cont.GetType()) | cont.GetType().IsSubclassOf(typeof(Form)) | cont.GetType().IsSubclassOf(typeof(ToolStrip)))
            {
                cont.Text = string.Join("", cont.Text.Split(Vowels));
            }
            if (cont.GetType().IsSubclassOf(typeof(ToolStrip)))
            {
                foreach (ToolStripItem I in ((ToolStrip)cont).Items)
                {
                    VowelsBegone(I);
                }
            }
            if (cont.Controls.Count > 0)
            {
                foreach (Control C in cont.Controls)
                {
                    VowelsBegone(C);
                }
            }
        }

        private static void VowelsBegone(ToolStripItem cont)
        {
            cont.Text = string.Join("", cont.Text.Split(Vowels));
            if (cont.GetType().IsSubclassOf(typeof(ToolStripDropDownItem)))
            {
                foreach (ToolStripItem I in ((ToolStripDropDownItem)cont).DropDownItems)
                {
                    VowelsBegone(I);
                }
            }
        }
    }
}