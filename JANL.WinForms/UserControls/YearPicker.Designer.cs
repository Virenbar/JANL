namespace JANL.UserControls
{
    partial class YearPicker
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Year = new System.Windows.Forms.CheckBox();
            this.NUD_Year = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CB_Year, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NUD_Year, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(65, 20);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CB_Year
            // 
            this.CB_Year.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_Year.AutoSize = true;
            this.CB_Year.Location = new System.Drawing.Point(0, 3);
            this.CB_Year.Margin = new System.Windows.Forms.Padding(0);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(15, 14);
            this.CB_Year.TabIndex = 0;
            this.CB_Year.UseVisualStyleBackColor = true;
            this.CB_Year.CheckedChanged += new System.EventHandler(this.CB_Year_CheckedChanged);
            // 
            // NUD_Year
            // 
            this.NUD_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Year.Location = new System.Drawing.Point(15, 0);
            this.NUD_Year.Margin = new System.Windows.Forms.Padding(0);
            this.NUD_Year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUD_Year.Name = "NUD_Year";
            this.NUD_Year.Size = new System.Drawing.Size(50, 20);
            this.NUD_Year.TabIndex = 1;
            this.NUD_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NUD_Year.ValueChanged += new System.EventHandler(this.NUD_Year_ValueChanged);
            // 
            // YearPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(65, 0);
            this.Name = "YearPicker";
            this.Size = new System.Drawing.Size(65, 20);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown NUD_Year;
        private System.Windows.Forms.CheckBox CB_Year;
    }
}
