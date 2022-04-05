namespace JANL.Forms
{
    partial class FormStoreView<K>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoreView));
            this.TSMI_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.DGV_Select = new System.Windows.Forms.DataGridView();
            this.BS_Select = new System.Windows.Forms.BindingSource();
            this.BNB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.TLP_Select = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Reset = new System.Windows.Forms.Button();
            this.B_Select = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BNB_Edit = new System.Windows.Forms.ToolStripButton();
            this.BNB_New = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BN_Select = new System.Windows.Forms.BindingNavigator();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BNB_Delete = new System.Windows.Forms.ToolStripButton();
            this.DGV_Filter = new JANL.DGVFilter();
            this.TLP_Filter = new System.Windows.Forms.TableLayoutPanel();
            this.CMS_Select = new System.Windows.Forms.ContextMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Select)).BeginInit();
            this.TLP_Select.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BN_Select)).BeginInit();
            this.BN_Select.SuspendLayout();
            this.TLP_Filter.SuspendLayout();
            this.CMS_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMI_Refresh
            // 
            this.TSMI_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Refresh.Image")));
            this.TSMI_Refresh.Name = "TSMI_Refresh";
            this.TSMI_Refresh.Size = new System.Drawing.Size(128, 22);
            this.TSMI_Refresh.Text = "Обновить";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(705, 5);
            this.Label1.Margin = new System.Windows.Forms.Padding(5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "<-Place for fliter";
            this.Label1.Visible = false;
            // 
            // DGV_Select
            // 
            this.DGV_Select.AllowUserToAddRows = false;
            this.DGV_Select.AllowUserToDeleteRows = false;
            this.DGV_Select.AllowUserToResizeRows = false;
            this.DGV_Select.AutoGenerateColumns = false;
            this.DGV_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Select.DataSource = this.BS_Select;
            this.DGV_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Select.Location = new System.Drawing.Point(0, 48);
            this.DGV_Select.MultiSelect = false;
            this.DGV_Select.Name = "DGV_Select";
            this.DGV_Select.ReadOnly = true;
            this.DGV_Select.RowHeadersVisible = false;
            this.DGV_Select.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Select.Size = new System.Drawing.Size(800, 365);
            this.DGV_Select.TabIndex = 13;
            // 
            // BNB_Refresh
            // 
            this.BNB_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("BNB_Refresh.Image")));
            this.BNB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BNB_Refresh.Name = "BNB_Refresh";
            this.BNB_Refresh.Size = new System.Drawing.Size(81, 22);
            this.BNB_Refresh.Text = "Обновить";
            // 
            // TLP_Select
            // 
            this.TLP_Select.AutoSize = true;
            this.TLP_Select.ColumnCount = 2;
            this.TLP_Select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Select.Controls.Add(this.FlowLayoutPanel1, 1, 0);
            this.TLP_Select.Controls.Add(this.FlowLayoutPanel2, 0, 0);
            this.TLP_Select.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLP_Select.Location = new System.Drawing.Point(0, 413);
            this.TLP_Select.Name = "TLP_Select";
            this.TLP_Select.RowCount = 1;
            this.TLP_Select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Select.Size = new System.Drawing.Size(800, 37);
            this.TLP_Select.TabIndex = 15;
            this.TLP_Select.Visible = false;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.B_Reset);
            this.FlowLayoutPanel1.Controls.Add(this.B_Select);
            this.FlowLayoutPanel1.Controls.Add(this.B_Cancel);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(498, 3);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(299, 31);
            this.FlowLayoutPanel1.TabIndex = 3;
            this.FlowLayoutPanel1.WrapContents = false;
            // 
            // B_Reset
            // 
            this.B_Reset.AutoSize = true;
            this.B_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Reset.Image = ((System.Drawing.Image)(resources.GetObject("B_Reset.Image")));
            this.B_Reset.Location = new System.Drawing.Point(3, 3);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Padding = new System.Windows.Forms.Padding(1);
            this.B_Reset.Size = new System.Drawing.Size(124, 25);
            this.B_Reset.TabIndex = 5;
            this.B_Reset.Text = "Очистить выбор";
            this.B_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Reset.UseVisualStyleBackColor = true;
            // 
            // B_Select
            // 
            this.B_Select.AutoSize = true;
            this.B_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Select.Image = ((System.Drawing.Image)(resources.GetObject("B_Select.Image")));
            this.B_Select.Location = new System.Drawing.Point(133, 3);
            this.B_Select.Name = "B_Select";
            this.B_Select.Padding = new System.Windows.Forms.Padding(1);
            this.B_Select.Size = new System.Drawing.Size(81, 25);
            this.B_Select.TabIndex = 4;
            this.B_Select.Text = "Выбрать";
            this.B_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Select.UseVisualStyleBackColor = true;
            // 
            // B_Cancel
            // 
            this.B_Cancel.AutoSize = true;
            this.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("B_Cancel.Image")));
            this.B_Cancel.Location = new System.Drawing.Point(220, 3);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Padding = new System.Windows.Forms.Padding(1);
            this.B_Cancel.Size = new System.Drawing.Size(76, 25);
            this.B_Cancel.TabIndex = 0;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlowLayoutPanel2.AutoSize = true;
            this.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.FlowLayoutPanel2.TabIndex = 4;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BNB_Edit
            // 
            this.BNB_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("BNB_Edit.Image")));
            this.BNB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BNB_Edit.Name = "BNB_Edit";
            this.BNB_Edit.Size = new System.Drawing.Size(23, 22);
            this.BNB_Edit.Text = "Редактировать";
            // 
            // BNB_New
            // 
            this.BNB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNB_New.Image = ((System.Drawing.Image)(resources.GetObject("BNB_New.Image")));
            this.BNB_New.Name = "BNB_New";
            this.BNB_New.RightToLeftAutoMirrorImage = true;
            this.BNB_New.Size = new System.Drawing.Size(23, 22);
            this.BNB_New.Text = "Добавить";
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
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Переместить вперед";
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
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // BN_Select
            // 
            this.BN_Select.AddNewItem = null;
            this.BN_Select.BindingSource = this.BS_Select;
            this.BN_Select.CountItem = this.BindingNavigatorCountItem;
            this.BN_Select.DeleteItem = null;
            this.BN_Select.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BN_Select.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.DGV_Filter,
            this.ToolStripSeparator1,
            this.BNB_Refresh});
            this.BN_Select.Location = new System.Drawing.Point(0, 23);
            this.BN_Select.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.BN_Select.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.BN_Select.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.BN_Select.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.BN_Select.Name = "BN_Select";
            this.BN_Select.PositionItem = this.BindingNavigatorPositionItem;
            this.BN_Select.Size = new System.Drawing.Size(800, 25);
            this.BN_Select.TabIndex = 14;
            this.BN_Select.Text = "BindingNavigator1";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.BindingNavigatorCountItem.Text = "для {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // 
            // DGV_Filter
            // 
            this.DGV_Filter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DGV_Filter.Name = "DGV_Filter";
            this.DGV_Filter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DGV_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_Filter.Size = new System.Drawing.Size(300, 25);
            // 
            // TLP_Filter
            // 
            this.TLP_Filter.AutoSize = true;
            this.TLP_Filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Filter.ColumnCount = 2;
            this.TLP_Filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Filter.Controls.Add(this.Label1, 1, 0);
            this.TLP_Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLP_Filter.Location = new System.Drawing.Point(0, 0);
            this.TLP_Filter.Name = "TLP_Filter";
            this.TLP_Filter.RowCount = 1;
            this.TLP_Filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Filter.Size = new System.Drawing.Size(800, 23);
            this.TLP_Filter.TabIndex = 16;
            this.TLP_Filter.Visible = false;
            // 
            // CMS_Select
            // 
            this.CMS_Select.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Refresh});
            this.CMS_Select.Name = "CMS_Select";
            this.CMS_Select.Size = new System.Drawing.Size(129, 26);
            // 
            // FormStoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::JANL.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_Select);
            this.Controls.Add(this.TLP_Select);
            this.Controls.Add(this.BN_Select);
            this.Controls.Add(this.TLP_Filter);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::JANL.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JANL.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JANL.Properties.Settings.Default, "ForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::JANL.Properties.Settings.Default.Font;
            this.ForeColor = global::JANL.Properties.Settings.Default.ForeColor;
            this.Name = "FormStoreView";
            this.Text = "FormStoreView";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Select)).EndInit();
            this.TLP_Select.ResumeLayout(false);
            this.TLP_Select.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BN_Select)).EndInit();
            this.BN_Select.ResumeLayout(false);
            this.BN_Select.PerformLayout();
            this.TLP_Filter.ResumeLayout(false);
            this.TLP_Filter.PerformLayout();
            this.CMS_Select.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem TSMI_Refresh;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DGV_Select;
        internal System.Windows.Forms.BindingSource BS_Select;
        internal System.Windows.Forms.ToolStripButton BNB_Refresh;
        internal System.Windows.Forms.TableLayoutPanel TLP_Select;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Button B_Reset;
        internal System.Windows.Forms.Button B_Select;
        internal System.Windows.Forms.Button B_Cancel;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton BNB_Edit;
        internal System.Windows.Forms.ToolStripButton BNB_New;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.BindingNavigator BN_Select;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton BNB_Delete;
        internal DGVFilter DGV_Filter;
        internal System.Windows.Forms.TableLayoutPanel TLP_Filter;
        internal System.Windows.Forms.ContextMenuStrip CMS_Select;
    }
}