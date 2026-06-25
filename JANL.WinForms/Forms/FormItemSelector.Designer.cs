namespace JANL.Forms
{
    partial class FormItemSelector
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
            this.LV_Items = new System.Windows.Forms.ListView();
            this.C_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TS_Page = new System.Windows.Forms.ToolStrip();
            this.B_First = new System.Windows.Forms.ToolStripButton();
            this.B_Previous = new System.Windows.Forms.ToolStripButton();
            this.L_Page = new System.Windows.Forms.ToolStripLabel();
            this.B_Next = new System.Windows.Forms.ToolStripButton();
            this.B_Last = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Reset = new System.Windows.Forms.Button();
            this.B_OK = new System.Windows.Forms.Button();
            this.TS_Page.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Items
            // 
            this.LV_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.C_Name});
            this.LV_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Items.FullRowSelect = true;
            this.LV_Items.GridLines = true;
            this.LV_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LV_Items.HideSelection = false;
            this.LV_Items.Location = new System.Drawing.Point(0, 25);
            this.LV_Items.Name = "LV_Items";
            this.LV_Items.Size = new System.Drawing.Size(284, 355);
            this.LV_Items.TabIndex = 4;
            this.LV_Items.UseCompatibleStateImageBehavior = false;
            this.LV_Items.View = System.Windows.Forms.View.Details;
            this.LV_Items.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_Items_ItemSelectionChanged);
            // 
            // C_Name
            // 
            this.C_Name.Text = "Name";
            // 
            // TS_Page
            // 
            this.TS_Page.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B_First,
            this.B_Previous,
            this.L_Page,
            this.B_Next,
            this.B_Last});
            this.TS_Page.Location = new System.Drawing.Point(0, 0);
            this.TS_Page.Name = "TS_Page";
            this.TS_Page.Size = new System.Drawing.Size(284, 25);
            this.TS_Page.TabIndex = 5;
            this.TS_Page.Text = "TS_Page";
            // 
            // B_First
            // 
            this.B_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_First.Image = global::My.Resources.icons8.DoubleLeft16;
            this.B_First.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_First.Name = "B_First";
            this.B_First.Size = new System.Drawing.Size(23, 22);
            this.B_First.Text = "Первая";
            this.B_First.Click += new System.EventHandler(this.B_First_Click);
            // 
            // B_Previous
            // 
            this.B_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Previous.Image = global::My.Resources.icons8.Left16;
            this.B_Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Previous.Name = "B_Previous";
            this.B_Previous.Size = new System.Drawing.Size(23, 22);
            this.B_Previous.Text = "Предедущая";
            this.B_Previous.Click += new System.EventHandler(this.B_Previous_Click);
            // 
            // L_Page
            // 
            this.L_Page.Name = "L_Page";
            this.L_Page.Size = new System.Drawing.Size(44, 22);
            this.L_Page.Text = "L_Page";
            // 
            // B_Next
            // 
            this.B_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Next.Image = global::My.Resources.icons8.Right16;
            this.B_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(23, 22);
            this.B_Next.Text = "Следующая";
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // B_Last
            // 
            this.B_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Last.Image = global::My.Resources.icons8.DoubleRight16;
            this.B_Last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Last.Name = "B_Last";
            this.B_Last.Size = new System.Drawing.Size(23, 22);
            this.B_Last.Text = "Последняя";
            this.B_Last.Click += new System.EventHandler(this.B_Last_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.B_Reset);
            this.flowLayoutPanel1.Controls.Add(this.B_OK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 380);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 31);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // B_Reset
            // 
            this.B_Reset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_Reset.AutoSize = true;
            this.B_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Reset.Image = global::My.Resources.icons8.Cancel16;
            this.B_Reset.Location = new System.Drawing.Point(201, 3);
            this.B_Reset.MinimumSize = new System.Drawing.Size(80, 0);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Padding = new System.Windows.Forms.Padding(1);
            this.B_Reset.Size = new System.Drawing.Size(80, 25);
            this.B_Reset.TabIndex = 9;
            this.B_Reset.Text = "Сброс";
            this.B_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Reset.UseVisualStyleBackColor = true;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // B_OK
            // 
            this.B_OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_OK.AutoSize = true;
            this.B_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_OK.Image = global::My.Resources.icons8.Ok16;
            this.B_OK.Location = new System.Drawing.Point(115, 3);
            this.B_OK.MinimumSize = new System.Drawing.Size(80, 0);
            this.B_OK.Name = "B_OK";
            this.B_OK.Padding = new System.Windows.Forms.Padding(1);
            this.B_OK.Size = new System.Drawing.Size(80, 25);
            this.B_OK.TabIndex = 10;
            this.B_OK.Text = "Выбрать";
            this.B_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // FormItemSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.LV_Items);
            this.Controls.Add(this.TS_Page);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "FormItemSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormItemSelector";
            this.Load += new System.EventHandler(this.FormItemSelector_Load);
            this.TS_Page.ResumeLayout(false);
            this.TS_Page.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Items;
        private System.Windows.Forms.ColumnHeader C_Name;
        private System.Windows.Forms.ToolStrip TS_Page;
        private System.Windows.Forms.ToolStripButton B_First;
        private System.Windows.Forms.ToolStripButton B_Previous;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.ToolStripLabel L_Page;
        private System.Windows.Forms.ToolStripButton B_Next;
        private System.Windows.Forms.ToolStripButton B_Last;
    }
}