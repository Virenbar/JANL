using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using JANL.Animators;
using JANL.Controls;
using JANL.Extensions;

namespace JANL.Designers
{
    [Obsolete("WIP")]
    internal partial class FormSpinnerEditor : Form
    {
        public FormSpinnerEditor()
        {
            InitializeComponent();

            this.BindSettings();
        }

        private static Dictionary<Type, Spinner> FindSpinners()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(T => T.IsClass && !T.IsAbstract && T.IsSubclassOf(typeof(Spinner)))
                .ToDictionary(T => T, T => (Spinner)Activator.CreateInstance(T));
        }

        public Spinner Value { get; set; }

        private void FormSpinnerEditor_Load(object sender, EventArgs e)
        {
            var t = FindSpinners();

            var items = t.Values.Select(S => new SpinnerLVI(S)).ToArray();
            LV.Items.Clear();
            LV.Items.AddRange(items);
        }

        private void LV_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            var spinner = (SpinnerLVI)e.Item;
            spinner.Start();
        }

        private void LV_ItemActivate(object sender, EventArgs e)
        {

        }

    }
}