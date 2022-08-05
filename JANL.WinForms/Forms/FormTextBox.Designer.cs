namespace JANL.Forms
{
    partial class FormTextBox
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
            this.TB = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.L_Header = new System.Windows.Forms.Label();
            this.TableLayoutPanel2.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB.Location = new System.Drawing.Point(3, 18);
            this.TB.Multiline = true;
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(386, 127);
            this.TB.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Controls.Add(this.FlowLayoutPanel1, 0, 2);
            this.TableLayoutPanel2.Controls.Add(this.TB, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.L_Header, 0, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 3;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.Size = new System.Drawing.Size(392, 185);
            this.TableLayoutPanel2.TabIndex = 7;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.B_OK);
            this.FlowLayoutPanel1.Controls.Add(this.B_Cancel);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(251, 151);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(138, 31);
            this.FlowLayoutPanel1.TabIndex = 3;
            // 
            // B_OK
            // 
            this.B_OK.AutoSize = true;
            this.B_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_OK.Image = global::My.Resources.icons8.Ok16;
            this.B_OK.Location = new System.Drawing.Point(3, 3);
            this.B_OK.Name = "B_OK";
            this.B_OK.Padding = new System.Windows.Forms.Padding(1);
            this.B_OK.Size = new System.Drawing.Size(50, 25);
            this.B_OK.TabIndex = 1;
            this.B_OK.Text = "ОК";
            this.B_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.AutoSize = true;
            this.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Cancel.Image = global::My.Resources.icons8.Cancel16;
            this.B_Cancel.Location = new System.Drawing.Point(59, 3);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Padding = new System.Windows.Forms.Padding(1);
            this.B_Cancel.Size = new System.Drawing.Size(76, 25);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // L_Header
            // 
            this.L_Header.AutoSize = true;
            this.L_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Header.Location = new System.Drawing.Point(3, 0);
            this.L_Header.Name = "L_Header";
            this.L_Header.Size = new System.Drawing.Size(106, 15);
            this.L_Header.TabIndex = 6;
            this.L_Header.Text = "Введите текст";
            this.L_Header.Visible = false;
            // 
            // FormTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::JANL.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(392, 185);
            this.Controls.Add(this.TableLayoutPanel2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::JANL.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JANL.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JANL.Properties.Settings.Default, "ForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::JANL.Properties.Settings.Default.Font;
            this.ForeColor = global::JANL.Properties.Settings.Default.ForeColor;
            this.Name = "FormTextBox";
            this.Text = "FormTextBox";
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox TB;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Button B_OK;
        internal System.Windows.Forms.Button B_Cancel;
        internal System.Windows.Forms.Label L_Header;
    }
}