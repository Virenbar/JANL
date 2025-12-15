namespace JANL.Forms
{
    partial class ExceptionBox
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionBox));
            this.L_Text = new System.Windows.Forms.Label();
            this.L_Description = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.L_Message = new System.Windows.Forms.Label();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.L_Method = new System.Windows.Forms.Label();
            this.TV_Exceptions = new System.Windows.Forms.TreeView();
            this.L_Type = new System.Windows.Forms.Label();
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.TB_StackTrace = new System.Windows.Forms.TextBox();
            this.FlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Ignore = new System.Windows.Forms.Button();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Copy = new System.Windows.Forms.Button();
            this.B_MailTo = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel3.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Text
            // 
            this.L_Text.AutoSize = true;
            this.L_Text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Text.Location = new System.Drawing.Point(8, 5);
            this.L_Text.Name = "L_Text";
            this.L_Text.Size = new System.Drawing.Size(545, 17);
            this.L_Text.TabIndex = 14;
            this.L_Text.Text = "Произошла непредвиденная ошибка. Стабильная работа приложения не гарантируется.";
            // 
            // L_Description
            // 
            this.L_Description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_Description.AutoSize = true;
            this.L_Description.Location = new System.Drawing.Point(3, 0);
            this.L_Description.Name = "L_Description";
            this.L_Description.Size = new System.Drawing.Size(117, 13);
            this.L_Description.TabIndex = 13;
            this.L_Description.Text = "Дерево исключений";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "StackTrace";
            // 
            // L_Message
            // 
            this.L_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Message.AutoSize = true;
            this.L_Message.Location = new System.Drawing.Point(3, 82);
            this.L_Message.Name = "L_Message";
            this.L_Message.Size = new System.Drawing.Size(70, 13);
            this.L_Message.TabIndex = 3;
            this.L_Message.Text = "Сообщение";
            // 
            // TB_Message
            // 
            this.TB_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Message.Location = new System.Drawing.Point(3, 98);
            this.TB_Message.Multiline = true;
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.ReadOnly = true;
            this.TB_Message.Size = new System.Drawing.Size(288, 107);
            this.TB_Message.TabIndex = 4;
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Name.Location = new System.Drawing.Point(3, 57);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(288, 22);
            this.TB_Name.TabIndex = 6;
            // 
            // L_Method
            // 
            this.L_Method.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Method.AutoSize = true;
            this.L_Method.Location = new System.Drawing.Point(3, 41);
            this.L_Method.Name = "L_Method";
            this.L_Method.Size = new System.Drawing.Size(41, 13);
            this.L_Method.TabIndex = 5;
            this.L_Method.Text = "Метод";
            // 
            // TV_Exceptions
            // 
            this.TV_Exceptions.Location = new System.Drawing.Point(3, 16);
            this.TV_Exceptions.MinimumSize = new System.Drawing.Size(300, 100);
            this.TV_Exceptions.Name = "TV_Exceptions";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Узел1";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Узел0";
            this.TV_Exceptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TV_Exceptions.Size = new System.Drawing.Size(300, 100);
            this.TV_Exceptions.TabIndex = 7;
            this.TV_Exceptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Exceptions_AfterSelect);
            // 
            // L_Type
            // 
            this.L_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Type.AutoSize = true;
            this.L_Type.Location = new System.Drawing.Point(3, 0);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(26, 13);
            this.L_Type.TabIndex = 5;
            this.L_Type.Text = "Тип";
            // 
            // TB_Type
            // 
            this.TB_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Type.Location = new System.Drawing.Point(3, 16);
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.ReadOnly = true;
            this.TB_Type.Size = new System.Drawing.Size(288, 22);
            this.TB_Type.TabIndex = 6;
            // 
            // TB_StackTrace
            // 
            this.TB_StackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_StackTrace.Location = new System.Drawing.Point(3, 16);
            this.TB_StackTrace.Multiline = true;
            this.TB_StackTrace.Name = "TB_StackTrace";
            this.TB_StackTrace.ReadOnly = true;
            this.TB_StackTrace.Size = new System.Drawing.Size(472, 335);
            this.TB_StackTrace.TabIndex = 9;
            // 
            // FlowLayoutPanel3
            // 
            this.FlowLayoutPanel3.AutoSize = true;
            this.FlowLayoutPanel3.Controls.Add(this.L_Text);
            this.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            this.FlowLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.FlowLayoutPanel3.Size = new System.Drawing.Size(784, 27);
            this.FlowLayoutPanel3.TabIndex = 15;
            // 
            // B_Ignore
            // 
            this.B_Ignore.AutoSize = true;
            this.B_Ignore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Ignore.Location = new System.Drawing.Point(3, 3);
            this.B_Ignore.Name = "B_Ignore";
            this.B_Ignore.Padding = new System.Windows.Forms.Padding(1);
            this.B_Ignore.Size = new System.Drawing.Size(87, 25);
            this.B_Ignore.TabIndex = 4;
            this.B_Ignore.Text = "Продолжить";
            this.B_Ignore.UseVisualStyleBackColor = true;
            this.B_Ignore.Click += new System.EventHandler(this.B_Ignore_Click);
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlowLayoutPanel2.AutoSize = true;
            this.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel2.Controls.Add(this.B_Copy);
            this.FlowLayoutPanel2.Controls.Add(this.B_MailTo);
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(256, 31);
            this.FlowLayoutPanel2.TabIndex = 14;
            this.FlowLayoutPanel2.WrapContents = false;
            // 
            // B_Copy
            // 
            this.B_Copy.AutoSize = true;
            this.B_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Copy.Image = ((System.Drawing.Image)(resources.GetObject("B_Copy.Image")));
            this.B_Copy.Location = new System.Drawing.Point(3, 3);
            this.B_Copy.Name = "B_Copy";
            this.B_Copy.Padding = new System.Windows.Forms.Padding(1);
            this.B_Copy.Size = new System.Drawing.Size(99, 25);
            this.B_Copy.TabIndex = 1;
            this.B_Copy.Text = "Копировать";
            this.B_Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Copy.UseVisualStyleBackColor = true;
            this.B_Copy.Click += new System.EventHandler(this.B_Copy_Click);
            // 
            // B_MailTo
            // 
            this.B_MailTo.AutoSize = true;
            this.B_MailTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_MailTo.Image = ((System.Drawing.Image)(resources.GetObject("B_MailTo.Image")));
            this.B_MailTo.Location = new System.Drawing.Point(108, 3);
            this.B_MailTo.Name = "B_MailTo";
            this.B_MailTo.Padding = new System.Windows.Forms.Padding(1);
            this.B_MailTo.Size = new System.Drawing.Size(145, 25);
            this.B_MailTo.TabIndex = 2;
            this.B_MailTo.Text = "Отправить по почте";
            this.B_MailTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_MailTo.UseVisualStyleBackColor = true;
            this.B_MailTo.Click += new System.EventHandler(this.B_MailTo_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.TableLayoutPanel1.Controls.Add(this.FlowLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.FlowLayoutPanel1, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 381);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(784, 31);
            this.TableLayoutPanel1.TabIndex = 14;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.B_Ignore);
            this.FlowLayoutPanel1.Controls.Add(this.B_Exit);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(617, 0);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(167, 31);
            this.FlowLayoutPanel1.TabIndex = 14;
            this.FlowLayoutPanel1.WrapContents = false;
            // 
            // B_Exit
            // 
            this.B_Exit.AutoSize = true;
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.Image = ((System.Drawing.Image)(resources.GetObject("B_Exit.Image")));
            this.B_Exit.Location = new System.Drawing.Point(96, 3);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Padding = new System.Windows.Forms.Padding(1);
            this.B_Exit.Size = new System.Drawing.Size(68, 25);
            this.B_Exit.TabIndex = 3;
            this.B_Exit.Text = "Выход";
            this.B_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TB_StackTrace, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(306, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 354);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.TB_Message, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.L_Message, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.L_Type, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TB_Type, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TB_Name, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.L_Method, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(294, 208);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 229);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание исключения";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.TV_Exceptions, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.L_Description, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(306, 354);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // ExceptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::JANL.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.FlowLayoutPanel3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::JANL.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JANL.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::JANL.Properties.Settings.Default.Font;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ExceptionBox";
            this.Text = "ExceptionBox";
            this.FlowLayoutPanel3.ResumeLayout(false);
            this.FlowLayoutPanel3.PerformLayout();
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.FlowLayoutPanel2.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label L_Text;
        internal System.Windows.Forms.Label L_Description;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label L_Message;
        internal System.Windows.Forms.TextBox TB_Message;
        internal System.Windows.Forms.TextBox TB_Name;
        internal System.Windows.Forms.Label L_Method;
        internal System.Windows.Forms.TreeView TV_Exceptions;
        internal System.Windows.Forms.Label L_Type;
        internal System.Windows.Forms.TextBox TB_Type;
        internal System.Windows.Forms.TextBox TB_StackTrace;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel3;
        internal System.Windows.Forms.Button B_Ignore;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal System.Windows.Forms.Button B_Copy;
        internal System.Windows.Forms.Button B_MailTo;
        internal System.Windows.Forms.Button B_Exit;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}