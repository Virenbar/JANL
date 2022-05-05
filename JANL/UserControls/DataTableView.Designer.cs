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
            this.BNS1 = new System.Windows.Forms.ToolStripSeparator();
            this.B_Create = new System.Windows.Forms.ToolStripButton();
            this.B_Edit = new System.Windows.Forms.ToolStripButton();
            this.B_Delete = new System.Windows.Forms.ToolStripButton();
            this.BNS2 = new System.Windows.Forms.ToolStripSeparator();
            this.B_Refresh = new System.Windows.Forms.ToolStripButton();
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
 
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
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
            this.BNS1,
            this.B_Create,
            this.B_Edit,
            this.B_Delete,
            this.BNS2,
            this.B_Refresh,
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
            // BNS1
            // 
            this.BNS1.Name = "BNS1";
            this.BNS1.Size = new System.Drawing.Size(6, 25);
            // 
            // B_Create
            // 
            this.B_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Create.Image = ((System.Drawing.Image)(resources.GetObject("B_Create.Image")));
            this.B_Create.Name = "B_Create";
            this.B_Create.RightToLeftAutoMirrorImage = true;
            this.B_Create.Size = new System.Drawing.Size(23, 22);
            this.B_Create.Text = "Добавить";
            this.B_Create.Click += new System.EventHandler(this.BNB_New_Click);
            // 
            // B_Edit
            // 
            this.B_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Edit.Image = ((System.Drawing.Image)(resources.GetObject("B_Edit.Image")));
            this.B_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(23, 22);
            this.B_Edit.Text = "Редактировать";
            this.B_Edit.Click += new System.EventHandler(this.BNB_Edit_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Delete.Image = ((System.Drawing.Image)(resources.GetObject("B_Delete.Image")));
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.RightToLeftAutoMirrorImage = true;
            this.B_Delete.Size = new System.Drawing.Size(23, 22);
            this.B_Delete.Text = "Удалить";
            this.B_Delete.Click += new System.EventHandler(this.BNB_Delete_Click);
            // 
            // BNS2
            // 
            this.BNS2.Name = "BNS2";
            this.BNS2.Size = new System.Drawing.Size(6, 25);
            // 
            // B_Refresh
            // 
            this.B_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("B_Refresh.Image")));
            this.B_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Refresh.Name = "B_Refresh";
            this.B_Refresh.Size = new System.Drawing.Size(81, 22);
            this.B_Refresh.Text = "Обновить";
            this.B_Refresh.Click += new System.EventHandler(this.BNB_Refresh_Click);
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
        internal System.Windows.Forms.ToolStripSeparator BNS1;
        internal System.Windows.Forms.ToolStripButton B_Create;
        internal System.Windows.Forms.ToolStripButton B_Edit;
        internal System.Windows.Forms.ToolStripButton B_Delete;
        internal System.Windows.Forms.ToolStripSeparator BNS2;
        internal System.Windows.Forms.ToolStripButton B_Refresh;
        private ToolStripTextBoxLabel TB_Filter;
        private System.Windows.Forms.BindingSource BS_View;
    }
}
