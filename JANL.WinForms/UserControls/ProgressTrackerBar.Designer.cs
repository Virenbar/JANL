namespace JANL.UserControls
{
    partial class ProgressTrackerBar
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
            this.L_Elapsed = new System.Windows.Forms.Label();
            this.L_Count = new System.Windows.Forms.Label();
            this.PB_Bar = new System.Windows.Forms.ProgressBar();
            this.L_Percent = new System.Windows.Forms.Label();
            this.L_Total = new System.Windows.Forms.Label();
            this.L_Remaining = new System.Windows.Forms.Label();
            this.L_Average = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.L_Elapsed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_Count, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PB_Bar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Percent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Total, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Remaining, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_Average, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_Elapsed
            // 
            this.L_Elapsed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_Elapsed.AutoSize = true;
            this.L_Elapsed.Location = new System.Drawing.Point(3, 42);
            this.L_Elapsed.Name = "L_Elapsed";
            this.L_Elapsed.Size = new System.Drawing.Size(10, 13);
            this.L_Elapsed.TabIndex = 2;
            this.L_Elapsed.Text = "-";
            // 
            // L_Count
            // 
            this.L_Count.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_Count.AutoSize = true;
            this.L_Count.Location = new System.Drawing.Point(3, 0);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(10, 13);
            this.L_Count.TabIndex = 3;
            this.L_Count.Text = "-";
            // 
            // PB_Bar
            // 
            this.PB_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.PB_Bar, 3);
            this.PB_Bar.Location = new System.Drawing.Point(3, 16);
            this.PB_Bar.Name = "PB_Bar";
            this.PB_Bar.Size = new System.Drawing.Size(351, 23);
            this.PB_Bar.TabIndex = 1;
            // 
            // L_Percent
            // 
            this.L_Percent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Percent.AutoSize = true;
            this.L_Percent.Location = new System.Drawing.Point(173, 0);
            this.L_Percent.Name = "L_Percent";
            this.L_Percent.Size = new System.Drawing.Size(10, 13);
            this.L_Percent.TabIndex = 3;
            this.L_Percent.Text = "-";
            // 
            // L_Total
            // 
            this.L_Total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Total.AutoSize = true;
            this.L_Total.Location = new System.Drawing.Point(344, 0);
            this.L_Total.Name = "L_Total";
            this.L_Total.Size = new System.Drawing.Size(10, 13);
            this.L_Total.TabIndex = 3;
            this.L_Total.Text = "-";
            // 
            // L_Remaining
            // 
            this.L_Remaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Remaining.AutoSize = true;
            this.L_Remaining.Location = new System.Drawing.Point(344, 42);
            this.L_Remaining.Name = "L_Remaining";
            this.L_Remaining.Size = new System.Drawing.Size(10, 13);
            this.L_Remaining.TabIndex = 3;
            this.L_Remaining.Text = "-";
            // 
            // L_Average
            // 
            this.L_Average.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Average.AutoSize = true;
            this.L_Average.Location = new System.Drawing.Point(173, 42);
            this.L_Average.Name = "L_Average";
            this.L_Average.Size = new System.Drawing.Size(10, 13);
            this.L_Average.TabIndex = 3;
            this.L_Average.Text = "-";
            this.L_Average.Visible = false;
            // 
            // ProgressTrackerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 50);
            this.Name = "ProgressTrackerBar";
            this.Size = new System.Drawing.Size(357, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Elapsed;
        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.ProgressBar PB_Bar;
        private System.Windows.Forms.Label L_Percent;
        private System.Windows.Forms.Label L_Total;
        private System.Windows.Forms.Label L_Remaining;
        private System.Windows.Forms.Label L_Average;
    }
}
