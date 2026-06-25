using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JANL.Extensions;

namespace JANL.Forms
{
    public partial class FormItemSelector : Form
    {
        private int page = 1;
        private int pageCount;

        public FormItemSelector()
        {
            InitializeComponent();
            this.BindSettings();
            Text = "Окно выбора";
        }

        /// <summary>
        /// Выбранные элементы указанного типа
        /// </summary>
        /// <typeparam name="T">Тип <see cref="ListViewItem"/></typeparam>
        /// <returns></returns>
        public IEnumerable<T> Selected<T>() where T : ListViewItem => LV_Items.SelectedItems.OfType<T>();

        private void FormItemSelector_Load(object sender, EventArgs e)
        {
            var columnCount = Items.Max(I => I.SubItems.Count) - 1;
            var columns = Enumerable.Range(1, columnCount).Select(N => new ColumnHeader() { Name = $"SubItem {N}" }).ToArray();
            LV_Items.Columns.AddRange(columns);
            //pageCount = (int)Math.Ceiling((double)Items.Count() / ItemsPerPage);
            pageCount = ((Items.Count() - 1) / ItemsPerPage) + 1;
            TS_Page.Visible = pageCount > 1; ;
            RefreshList();
        }

        private void RefreshList()
        {
            LV_Items.BeginUpdate();
            LV_Items.Items.Clear();
            var items = Items.Skip(ItemsPerPage * (page - 1)).Take(ItemsPerPage);
            LV_Items.Items.AddRange(items.ToArray());
            LV_Items.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LV_Items.EndUpdate();

            RefreshUI();
        }

        private void RefreshUI()
        {
            B_OK.Enabled = LV_Items.SelectedItems.Count > 0;
            L_Page.Text = $"{page}/{pageCount}";

            B_First.Enabled = page != 1;
            B_Previous.Enabled = page != 1;
            B_Next.Enabled = page != pageCount;
            B_Last.Enabled = page != pageCount;
        }

        #region Properties

        /// <summary>
        /// Перечисление элементов для выбора
        /// </summary>
        public IEnumerable<ListViewItem> Items { get; set; }

        /// <summary>
        /// Количество элементов на странице
        /// </summary>
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Выбранные элементы
        /// </summary>
        public IEnumerable<ListViewItem> SelectedItems => LV_Items.SelectedItems.Cast<ListViewItem>().ToList();

        #endregion Properties

        #region UI Events

        #region Page

        private void B_First_Click(object sender, EventArgs e)
        {
            page = 1;
            RefreshList();
        }

        private void B_Last_Click(object sender, EventArgs e)
        {
            page = pageCount;
            RefreshList();
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            page += 1;
            RefreshList();
        }

        private void B_Previous_Click(object sender, EventArgs e)
        {
            page -= 1;
            RefreshList();
        }

        #endregion Page

        private void B_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            LV_Items.SelectedItems.Clear();
            DialogResult = DialogResult.OK;
        }

        private void LV_Items_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RefreshUI();
        }

        //private void LV_Items_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    RefreshUI();
        //}

        #endregion UI Events
    }
}