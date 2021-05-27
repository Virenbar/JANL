namespace DGVTemplateEditor
{
	partial class FormEditor
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
			this.DGV_Template = new System.Windows.Forms.DataGridView();
			this.B_Import = new System.Windows.Forms.Button();
			this.B_Export = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.PG_Column = new System.Windows.Forms.PropertyGrid();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.B_MoveLeft = new System.Windows.Forms.Button();
			this.B_MoveRight = new System.Windows.Forms.Button();
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
			this.FCTB_Template = new FastColoredTextBoxNS.FastColoredTextBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Template)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_Columns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BN_Columns)).BeginInit();
			this.BN_Columns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FCTB_Template)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DGV_Template
			// 
			this.DGV_Template.AllowUserToAddRows = false;
			this.DGV_Template.AllowUserToDeleteRows = false;
			this.DGV_Template.AllowUserToResizeColumns = false;
			this.DGV_Template.AllowUserToResizeRows = false;
			this.DGV_Template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Template.Dock = System.Windows.Forms.DockStyle.Top;
			this.DGV_Template.Location = new System.Drawing.Point(0, 25);
			this.DGV_Template.MultiSelect = false;
			this.DGV_Template.Name = "DGV_Template";
			this.DGV_Template.ReadOnly = true;
			this.DGV_Template.Size = new System.Drawing.Size(1128, 88);
			this.DGV_Template.TabIndex = 0;
			this.DGV_Template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Template_CellClick);
			this.DGV_Template.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Template_ColumnHeaderMouseClick);
			this.DGV_Template.CurrentCellChanged += new System.EventHandler(this.DGV_Template_CurrentCellChanged);
			this.DGV_Template.SelectionChanged += new System.EventHandler(this.DGV_Template_SelectionChanged);
			// 
			// B_Import
			// 
			this.B_Import.Location = new System.Drawing.Point(3, 3);
			this.B_Import.Name = "B_Import";
			this.B_Import.Size = new System.Drawing.Size(75, 23);
			this.B_Import.TabIndex = 2;
			this.B_Import.Text = "Import";
			this.B_Import.UseVisualStyleBackColor = true;
			this.B_Import.Click += new System.EventHandler(this.B_Import_Click);
			// 
			// B_Export
			// 
			this.B_Export.Location = new System.Drawing.Point(84, 3);
			this.B_Export.Name = "B_Export";
			this.B_Export.Size = new System.Drawing.Size(75, 23);
			this.B_Export.TabIndex = 3;
			this.B_Export.Text = "Export";
			this.B_Export.UseVisualStyleBackColor = true;
			this.B_Export.Click += new System.EventHandler(this.B_Export_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PG_Column);
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Columns, "Header", true));
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 438);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// PG_Column
			// 
			this.PG_Column.ContextMenuStrip = this.contextMenuStrip1;
			this.PG_Column.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PG_Column.Location = new System.Drawing.Point(3, 45);
			this.PG_Column.Name = "PG_Column";
			this.PG_Column.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.PG_Column.Size = new System.Drawing.Size(388, 390);
			this.PG_Column.TabIndex = 7;
			this.PG_Column.Leave += new System.EventHandler(this.PG_Column_Leave);
			this.PG_Column.Validated += new System.EventHandler(this.PG_Column_Validated);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.B_MoveLeft);
			this.flowLayoutPanel1.Controls.Add(this.B_MoveRight);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 29);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// B_MoveLeft
			// 
			this.B_MoveLeft.Location = new System.Drawing.Point(3, 3);
			this.B_MoveLeft.Name = "B_MoveLeft";
			this.B_MoveLeft.Size = new System.Drawing.Size(75, 23);
			this.B_MoveLeft.TabIndex = 6;
			this.B_MoveLeft.Text = "Move Left";
			this.B_MoveLeft.UseVisualStyleBackColor = true;
			this.B_MoveLeft.Click += new System.EventHandler(this.B_MoveLeft_Click);
			// 
			// B_MoveRight
			// 
			this.B_MoveRight.Location = new System.Drawing.Point(84, 3);
			this.B_MoveRight.Name = "B_MoveRight";
			this.B_MoveRight.Size = new System.Drawing.Size(75, 23);
			this.B_MoveRight.TabIndex = 7;
			this.B_MoveRight.Text = "Move Right";
			this.B_MoveRight.UseVisualStyleBackColor = true;
			this.B_MoveRight.Click += new System.EventHandler(this.B_MoveRight_Click);
			// 
			// BS_Columns
			// 
			this.BS_Columns.DataSource = typeof(DGVTemplateEditor.Types.DGVTemplate);
			this.BS_Columns.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.BS_Columns_AddingNew);
			this.BS_Columns.CurrentChanged += new System.EventHandler(this.BS_Columns_CurrentChanged);
			this.BS_Columns.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BS_Columns_ListChanged);
			// 
			// BN_Columns
			// 
			this.BN_Columns.AddNewItem = this.bindingNavigatorAddNewItem;
			this.BN_Columns.BindingSource = this.BS_Columns;
			this.BN_Columns.CountItem = this.bindingNavigatorCountItem;
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
			this.BN_Columns.Location = new System.Drawing.Point(0, 0);
			this.BN_Columns.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.BN_Columns.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.BN_Columns.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.BN_Columns.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.BN_Columns.Name = "BN_Columns";
			this.BN_Columns.PositionItem = this.bindingNavigatorPositionItem;
			this.BN_Columns.Size = new System.Drawing.Size(1128, 25);
			this.BN_Columns.TabIndex = 6;
			this.BN_Columns.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
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
			// FCTB_Template
			// 
			this.FCTB_Template.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.FCTB_Template.AutoScrollMinSize = new System.Drawing.Size(179, 14);
			this.FCTB_Template.BackBrush = null;
			this.FCTB_Template.CharHeight = 14;
			this.FCTB_Template.CharWidth = 8;
			this.FCTB_Template.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.FCTB_Template.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.FCTB_Template.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FCTB_Template.IsReplaceMode = false;
			this.FCTB_Template.Location = new System.Drawing.Point(3, 45);
			this.FCTB_Template.Name = "FCTB_Template";
			this.FCTB_Template.Paddings = new System.Windows.Forms.Padding(0);
			this.FCTB_Template.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.FCTB_Template.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FCTB_Template.ServiceColors")));
			this.FCTB_Template.Size = new System.Drawing.Size(710, 390);
			this.FCTB_Template.TabIndex = 7;
			this.FCTB_Template.Text = "fastColoredTextBox1";
			this.FCTB_Template.Zoom = 100;
			this.FCTB_Template.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FCTB_Template_TextChanged);
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
			this.flowLayoutPanel2.Size = new System.Drawing.Size(710, 29);
			this.flowLayoutPanel2.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.FCTB_Template);
			this.groupBox2.Controls.Add(this.flowLayoutPanel2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(406, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(716, 438);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Import/Export";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1128, 450);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// FormEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 563);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.DGV_Template);
			this.Controls.Add(this.BN_Columns);
			this.Name = "FormEditor";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DGV_Template)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BS_Columns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BN_Columns)).EndInit();
			this.BN_Columns.ResumeLayout(false);
			this.BN_Columns.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FCTB_Template)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGV_Template;
		private System.Windows.Forms.Button B_Import;
		private System.Windows.Forms.Button B_Export;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingNavigator BN_Columns;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.BindingSource BS_Columns;
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
		private System.Windows.Forms.PropertyGrid PG_Column;
		private FastColoredTextBoxNS.FastColoredTextBox FCTB_Template;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button B_MoveLeft;
		private System.Windows.Forms.Button B_MoveRight;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
	}
}

