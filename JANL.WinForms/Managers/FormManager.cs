using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JANL.Managers
{
    public static class FormManager
    {
        private static Dictionary<Form, ToolStripMenuItem> Items = new Dictionary<Form, ToolStripMenuItem>();
        private static ToolStripMenuItem Root;

        public static void Add(Form form)
        {
            if (Items.ContainsKey(form)) { return; }
            var TSMI = new ToolStripMenuItem
            {
                Text = form.Text,
                Image = form.Icon.ToBitmap()
            };
            TSMI.Click += (_, __) => { form.Activate(); };
            form.TextChanged += TextChanged;
            form.FormClosed += FormClosed;

            Root.DropDownItems.Add(TSMI);
            Root.Visible = true;
            Items.Add(form, TSMI);
        }

        public static void SetMenu(ToolStripMenuItem TSMI)
        {
            if (Root != null)
            {
                foreach (var KV in Items)
                {
                    Root.DropDownItems.Remove(KV.Value);
                    TSMI.DropDownItems.Add(KV.Value);
                }
                ChangeVisibility();
            }
            Root = TSMI;
            ChangeVisibility();
        }

        private static void ChangeVisibility() => Root.Visible = Root.DropDownItems.Count != 0;

        private static void FormClosed(object sender, FormClosedEventArgs e) => Remove((Form)sender);

        private static void Remove(Form form)
        {
            if (!Items.ContainsKey(form)) { return; }
            var TSMI = Items[form];
            form.TextChanged -= TextChanged;
            form.FormClosed -= FormClosed;

            Root.DropDownItems.Remove(TSMI);
            Items.Remove(form);
            TSMI.Dispose();
            ChangeVisibility();
        }

        private static void TextChanged(object sender, EventArgs e)
        {
            var Form = (Form)sender;
            Items[Form].Text = Form.Text;
        }
    }
}