namespace JANL.Forms
{
    partial class SelectBox
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
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.L_Select = new System.Windows.Forms.Label();
            this.LB_Items = new System.Windows.Forms.ListBox();
            this.B_Select = new System.Windows.Forms.Button();
            this.TableLayoutPanel2.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Controls.Add(this.FlowLayoutPanel1, 0, 2);
            this.TableLayoutPanel2.Controls.Add(this.L_Select, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.LB_Items, 0, 1);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 3;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.Size = new System.Drawing.Size(314, 239);
            this.TableLayoutPanel2.TabIndex = 6;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.B_Select);
            this.FlowLayoutPanel1.Controls.Add(this.B_Cancel);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(146, 205);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(165, 31);
            this.FlowLayoutPanel1.TabIndex = 3;
            // 
            // B_Cancel
            // 
            this.B_Cancel.AutoSize = true;
            this.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Cancel.Image = global::My.Resources.icons8.Cancel16;
            this.B_Cancel.Location = new System.Drawing.Point(88, 3);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Padding = new System.Windows.Forms.Padding(1);
            this.B_Cancel.Size = new System.Drawing.Size(74, 25);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // L_Select
            // 
            this.L_Select.AutoSize = true;
            this.L_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Select.Location = new System.Drawing.Point(3, 0);
            this.L_Select.Name = "L_Select";
            this.L_Select.Size = new System.Drawing.Size(78, 15);
            this.L_Select.TabIndex = 6;
            this.L_Select.Text = "Выберите ";
            // 
            // LB_Items
            // 
            this.LB_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Items.FormattingEnabled = true;
            this.LB_Items.Location = new System.Drawing.Point(5, 20);
            this.LB_Items.Margin = new System.Windows.Forms.Padding(5);
            this.LB_Items.Name = "LB_Items";
            this.LB_Items.Size = new System.Drawing.Size(304, 177);
            this.LB_Items.TabIndex = 0;
            this.LB_Items.SelectedIndexChanged += new System.EventHandler(this.LB_Items_SelectedIndexChanged);
            // 
            // B_Select
            // 
            this.B_Select.AutoSize = true;
            this.B_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Select.Image = global::My.Resources.icons8.Ok16;
            this.B_Select.Location = new System.Drawing.Point(3, 3);
            this.B_Select.Name = "B_Select";
            this.B_Select.Padding = new System.Windows.Forms.Padding(1);
            this.B_Select.Size = new System.Drawing.Size(79, 25);
            this.B_Select.TabIndex = 1;
            this.B_Select.Text = "Выбрать";
            this.B_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Select.UseVisualStyleBackColor = true;
            this.B_Select.Click += new System.EventHandler(this.B_Select_Click);
            // 
            // SelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 239);
            this.Controls.Add(this.TableLayoutPanel2);
            this.Name = "SelectBox";
            this.Text = "SelectBox";
            this.Load += new System.EventHandler(this.SelectBox_Load);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Button B_Select;
        internal System.Windows.Forms.Button B_Cancel;
        internal System.Windows.Forms.Label L_Select;
        internal System.Windows.Forms.ListBox LB_Items;
    }
}