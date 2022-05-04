using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JANL.Forms
{
    public partial class SelectBox : Form
    {
        public SelectBox()
        {
            InitializeComponent();
            Text = "Окно выбора";
        }

        #region Properties

        public string DisplayMember
        {
            get => LB_Items.DisplayMember;
            set => LB_Items.DisplayMember = value;
        }

        public string Header
        {
            get => L_Select.Text;
            set => L_Select.Text = value;
        }

        public IEnumerable<object> Items { get; set; }
        public object SelectedItem { get; private set; }

        public T Item<T>() => (T)SelectedItem;

        #endregion Properties

        #region UI Events

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void B_Select_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LB_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = LB_Items.SelectedItem;
        }

        private void SelectBox_Load(object sender, EventArgs e)
        {
            var DM = LB_Items.DisplayMember;
            LB_Items.DataSource = Items.ToList();
            LB_Items.DisplayMember = DM;
            B_Select.Enabled = Items.Count() > 0;
        }

        #endregion UI Events
    }
}