namespace JANL.UserControls
{
    partial class DGVTemplateEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGVTemplateEditor));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_XML = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Import = new System.Windows.Forms.Button();
            this.B_Export = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.BS_Columns = new System.Windows.Forms.BindingSource(this.components);
            this.BN_Columns = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.PG_Column = new System.Windows.Forms.PropertyGrid();
            this.CMS_PG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Template = new System.Windows.Forms.DataGridView();
            this.BS_Design = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_Columns)).BeginInit();
            this.BN_Columns.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.CMS_PG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Template)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Design)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.GroupBox1, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.GroupBox3, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.GroupBox2, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1193, 516);
            this.TableLayoutPanel1.TabIndex = 108;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TB_XML);
            this.GroupBox1.Controls.Add(this.flowLayoutPanel2);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(760, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(430, 510);
            this.GroupBox1.TabIndex = 100;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "XML";
            // 
            // TB_XML
            // 
            this.TB_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_XML.Location = new System.Drawing.Point(3, 47);
            this.TB_XML.Margin = new System.Windows.Forms.Padding(10);
            this.TB_XML.Multiline = true;
            this.TB_XML.Name = "TB_XML";
            this.TB_XML.Size = new System.Drawing.Size(424, 460);
            this.TB_XML.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.B_Import);
            this.flowLayoutPanel2.Controls.Add(this.B_Export);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(424, 31);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // B_Import
            // 
            this.B_Import.AutoSize = true;
            this.B_Import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Import.Image = ((System.Drawing.Image)(resources.GetObject("B_Import.Image")));
            this.B_Import.Location = new System.Drawing.Point(3, 3);
            this.B_Import.Name = "B_Import";
            this.B_Import.Padding = new System.Windows.Forms.Padding(1);
            this.B_Import.Size = new System.Drawing.Size(74, 25);
            this.B_Import.TabIndex = 2;
            this.B_Import.Text = "Импорт";
            this.B_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Import.UseVisualStyleBackColor = true;
            this.B_Import.Click += new System.EventHandler(this.B_Import_Click);
            // 
            // B_Export
            // 
            this.B_Export.AutoSize = true;
            this.B_Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Export.Image = ((System.Drawing.Image)(resources.GetObject("B_Export.Image")));
            this.B_Export.Location = new System.Drawing.Point(83, 3);
            this.B_Export.Name = "B_Export";
            this.B_Export.Padding = new System.Windows.Forms.Padding(1);
            this.B_Export.Size = new System.Drawing.Size(77, 25);
            this.B_Export.TabIndex = 3;
            this.B_Export.Text = "Экспорт";
            this.B_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Export.UseVisualStyleBackColor = true;
            this.B_Export.Click += new System.EventHandler(this.B_Export_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ListBox1);
            this.GroupBox3.Controls.Add(this.BN_Columns);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(430, 510);
            this.GroupBox3.TabIndex = 105;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Столбцы";
            // 
            // ListBox1
            // 
            this.ListBox1.DataSource = this.BS_Columns;
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(3, 41);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(424, 466);
            this.ListBox1.TabIndex = 104;
            // 
            // BS_Columns
            // 
            this.BS_Columns.DataSource = typeof(JANL.Types.DesignColumn);
            this.BS_Columns.CurrentChanged += new System.EventHandler(this.BS_Columns_CurrentChanged);
            this.BS_Columns.CurrentItemChanged += new System.EventHandler(this.BS_Columns_CurrentItemChanged);
            this.BS_Columns.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BS_Columns_ListChanged);
            // 
            // BN_Columns
            // 
            this.BN_Columns.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BN_Columns.BindingSource = this.BS_Columns;
            this.BN_Columns.CountItem = this.bindingNavigatorCountItem;
            this.BN_Columns.CountItemFormat = "/{0}";
            this.BN_Columns.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BN_Columns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.BN_Columns.Location = new System.Drawing.Point(3, 16);
            this.BN_Columns.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN_Columns.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN_Columns.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN_Columns.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN_Columns.Name = "BN_Columns";
            this.BN_Columns.PositionItem = this.bindingNavigatorPositionItem;
            this.BN_Columns.Size = new System.Drawing.Size(424, 25);
            this.BN_Columns.TabIndex = 103;
            this.BN_Columns.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(26, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.PG_Column);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(439, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(315, 510);
            this.GroupBox2.TabIndex = 101;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Свойства столбца";
            // 
            // PG_Column
            // 
            this.PG_Column.ContextMenuStrip = this.CMS_PG;
            this.PG_Column.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PG_Column.Location = new System.Drawing.Point(3, 16);
            this.PG_Column.Name = "PG_Column";
            this.PG_Column.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.PG_Column.Size = new System.Drawing.Size(309, 491);
            this.PG_Column.TabIndex = 7;
            // 
            // CMS_PG
            // 
            this.CMS_PG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Reset});
            this.CMS_PG.Name = "contextMenuStrip1";
            this.CMS_PG.Size = new System.Drawing.Size(110, 26);
            // 
            // TSMI_Reset
            // 
            this.TSMI_Reset.Name = "TSMI_Reset";
            this.TSMI_Reset.Size = new System.Drawing.Size(109, 22);
            this.TSMI_Reset.Text = "Сброс";
            this.TSMI_Reset.Click += new System.EventHandler(this.TSMI_Reset_Click);
            // 
            // DGV_Template
            // 
            this.DGV_Template.AllowUserToAddRows = false;
            this.DGV_Template.AllowUserToDeleteRows = false;
            this.DGV_Template.AllowUserToOrderColumns = true;
            this.DGV_Template.AllowUserToResizeColumns = false;
            this.DGV_Template.AllowUserToResizeRows = false;
            this.DGV_Template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Template.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Template.Location = new System.Drawing.Point(0, 0);
            this.DGV_Template.MultiSelect = false;
            this.DGV_Template.Name = "DGV_Template";
            this.DGV_Template.ReadOnly = true;
            this.DGV_Template.RowHeadersVisible = false;
            this.DGV_Template.Size = new System.Drawing.Size(1193, 67);
            this.DGV_Template.TabIndex = 107;
            this.DGV_Template.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Template_CellMouseClick);
            this.DGV_Template.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Template_CellMouseDown);
            this.DGV_Template.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Template_CellMouseUp);
            this.DGV_Template.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DGV_Template_ColumnDisplayIndexChanged);
            this.DGV_Template.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Template_ColumnHeaderMouseClick);
            // 
            // BS_Design
            // 
            this.BS_Design.DataSource = typeof(JANL.Types.Design);
            // 
            // DGVTemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.DGV_Template);
            this.Name = "DGVTemplateEditor";
            this.Size = new System.Drawing.Size(1193, 583);
            this.Load += new System.EventHandler(this.DGVTemplateEditor_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_Columns)).EndInit();
            this.BN_Columns.ResumeLayout(false);
            this.BN_Columns.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.CMS_PG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Template)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Design)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TB_XML;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button B_Import;
        private System.Windows.Forms.Button B_Export;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.BindingSource BS_Columns;
        private System.Windows.Forms.BindingNavigator BN_Columns;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.PropertyGrid PG_Column;
        private System.Windows.Forms.ContextMenuStrip CMS_PG;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Reset;
        private System.Windows.Forms.DataGridView DGV_Template;
        private System.Windows.Forms.BindingSource BS_Design;
    }
}
