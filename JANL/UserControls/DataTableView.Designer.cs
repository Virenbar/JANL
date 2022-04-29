namespace JANL.UserControls
{
    partial class DataTableView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTableView));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BN_View = new System.Windows.Forms.BindingNavigator(this.components);
            this.BS_View = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BNB_New = new System.Windows.Forms.ToolStripButton();
            this.BNB_Edit = new System.Windows.Forms.ToolStripButton();
            this.BNB_Delete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BNB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.TB_Filter = new JANL.ToolStripTextBoxLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_View)).BeginInit();
            this.BN_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_View)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 25);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV.Size = new System.Drawing.Size(819, 544);
            this.DGV.TabIndex = 15;
            // 
            // BN_View
            // 
            this.BN_View.AddNewItem = null;
            this.BN_View.BindingSource = this.BS_View;
            this.BN_View.CountItem = this.BindingNavigatorCountItem;
            this.BN_View.CountItemFormat = "/{0}";
            this.BN_View.DeleteItem = null;
            this.BN_View.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BN_View.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.BNB_New,
            this.BNB_Edit,
            this.BNB_Delete,
            this.ToolStripSeparator1,
            this.BNB_Refresh,
            this.TB_Filter});
            this.BN_View.Location = new System.Drawing.Point(0, 0);
            this.BN_View.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.BN_View.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.BN_View.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.BN_View.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.BN_View.Name = "BN_View";
            this.BN_View.PositionItem = this.BindingNavigatorPositionItem;
            this.BN_View.Size = new System.Drawing.Size(819, 25);
            this.BN_View.TabIndex = 16;
            this.BN_View.Text = "BindingNavigator1";
            // 
            // BS_View
            // 
            this.BS_View.CurrentChanged += new System.EventHandler(this.BS_View_CurrentChanged);
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(26, 22);
            this.BindingNavigatorCountItem.Text = "/{0}";
            this.BindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Положение";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BNB_New
            // 
            this.BNB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNB_New.Enabled = false;
            this.BNB_New.Image = ((System.Drawing.Image)(resources.GetObject("BNB_New.Image")));
            this.BNB_New.Name = "BNB_New";
            this.BNB_New.RightToLeftAutoMirrorImage = true;
            this.BNB_New.Size = new System.Drawing.Size(23, 22);
            this.BNB_New.Text = "Добавить";
            this.BNB_New.Click += new System.EventHandler(this.BNB_New_Click);
            // 
            // BNB_Edit
            // 
            this.BNB_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNB_Edit.Enabled = false;
            this.BNB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("BNB_Edit.Image")));
            this.BNB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BNB_Edit.Name = "BNB_Edit";
            this.BNB_Edit.Size = new System.Drawing.Size(23, 22);
            this.BNB_Edit.Text = "Редактировать";
            this.BNB_Edit.Click += new System.EventHandler(this.BNB_Edit_Click);
            // 
            // BNB_Delete
            // 
            this.BNB_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNB_Delete.Enabled = false;
            this.BNB_Delete.Image = ((System.Drawing.Image)(resources.GetObject("BNB_Delete.Image")));
            this.BNB_Delete.Name = "BNB_Delete";
            this.BNB_Delete.RightToLeftAutoMirrorImage = true;
            this.BNB_Delete.Size = new System.Drawing.Size(23, 22);
            this.BNB_Delete.Text = "Удалить";
            this.BNB_Delete.Click += new System.EventHandler(this.BNB_Delete_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BNB_Refresh
            // 
            this.BNB_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("BNB_Refresh.Image")));
            this.BNB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BNB_Refresh.Name = "BNB_Refresh";
            this.BNB_Refresh.Size = new System.Drawing.Size(81, 22);
            this.BNB_Refresh.Text = "Обновить";
            this.BNB_Refresh.Click += new System.EventHandler(this.BNB_Refresh_Click);
            // 
            // TB_Filter
            // 
            this.TB_Filter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TB_Filter.Label = "Фильтр";
            this.TB_Filter.MaxLength = 1000;
            this.TB_Filter.Name = "TB_Filter";
            this.TB_Filter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TB_Filter.Size = new System.Drawing.Size(300, 25);
            this.TB_Filter.ToolTipText = "Esc";
            // 
            // DataTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.BN_View);
            this.Name = "DataTableView";
            this.Size = new System.Drawing.Size(819, 569);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_View)).EndInit();
            this.BN_View.ResumeLayout(false);
            this.BN_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DGV;
        internal System.Windows.Forms.BindingNavigator BN_View;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton BNB_New;
        internal System.Windows.Forms.ToolStripButton BNB_Edit;
        internal System.Windows.Forms.ToolStripButton BNB_Delete;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton BNB_Refresh;
        private ToolStripTextBoxLabel TB_Filter;
        private System.Windows.Forms.BindingSource BS_View;
    }
}
