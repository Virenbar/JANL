using System;
using System.Windows.Forms;

namespace JANL.Forms
{
    /// <summary>
    /// Форма ввода текста
    /// </summary>
    public partial class FormTextBox : Form
    {
        /// <summary>
        /// Создаёт новый экземпляр
        /// </summary>
        public FormTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создаёт новый экземпляр c указанным заголовком
        /// </summary>
        public FormTextBox(string header) : this()
        {
            Header = header;
        }

        /// <summary>
        /// Создаёт новый экземпляр c указанным заголовком и текстом
        /// </summary>
        public FormTextBox(string header, string input) : this(header)
        {
            Input = input;
        }

        /// <summary>
        /// Текст заголовка
        /// </summary>
        public string Header
        {
            get => Text;
            set => Text = value;
        }

        /// <summary>
        /// Введённый текст
        /// </summary>
        public string Input
        {
            get => TB.Text;
            set => TB.Text = value;
        }

        private void FormTextBox_Load(object sender, EventArgs e)
        {
            Icon = Owner?.Icon;
        }

        #region UI Events

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

        #endregion UI Events

    }
}