using System;
using System.Windows.Forms;

namespace JANL.Forms
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        public FormTextBox(string header) : this()
        {
            Header = header;
        }

        public FormTextBox(string header, string input) : this(header)
        {
            Input = input;
        }

        public string Header
        {
            get => Text;
            set => Text = value;
        }

        public string Input
        {
            get => TB.Text;
            set => TB.Text = value;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}