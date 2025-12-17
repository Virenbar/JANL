using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JANL.Forms
{
    /// <summary>
    /// Форма выбора элемента
    /// </summary>
    public partial class SelectBox : Form
    {
        /// <summary>
        ///
        /// </summary>
        public SelectBox()
        {
            InitializeComponent();
            Text = "Окно выбора";
        }

        #region Properties

        /// <summary>
        /// Свойство для отображения
        /// </summary>
        public string DisplayMember
        {
            get => LB_Items.DisplayMember;
            set => LB_Items.DisplayMember = value;
        }

        /// <summary>
        /// Заголовок списка
        /// </summary>
        public string Header
        {
            get => L_Select.Text;
            set => L_Select.Text = value;
        }

        /// <summary>
        /// Список элементов
        /// </summary>
        public IEnumerable<object> Items { get; set; }

        /// <summary>
        /// Выбранный элемент
        /// </summary>
        public object SelectedItem { get; private set; }

        /// <summary>
        /// Выбранный элемент
        /// </summary>
        /// <typeparam name="T">Тип элемента</typeparam>
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