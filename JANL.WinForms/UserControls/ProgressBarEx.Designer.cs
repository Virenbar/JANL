namespace JANL.UserControls
{
    partial class ProgressBarEx
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
            this.PB = new System.Windows.Forms.ProgressBar();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Estimated = new System.Windows.Forms.Label();
            this.L_Percent = new System.Windows.Forms.Label();
            this.L_Elapsed = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.SetColumnSpan(this.PB, 3);
            this.PB.Location = new System.Drawing.Point(3, 3);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(201, 23);
            this.PB.TabIndex = 0;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel1.Controls.Add(this.L_Estimated, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.PB, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.L_Percent, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.L_Elapsed, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(207, 45);
            this.TableLayoutPanel1.TabIndex = 2;
            // 
            // L_Estimated
            // 
            this.L_Estimated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Estimated.AutoSize = true;
            this.L_Estimated.Location = new System.Drawing.Point(151, 29);
            this.L_Estimated.Name = "L_Estimated";
            this.L_Estimated.Size = new System.Drawing.Size(53, 13);
            this.L_Estimated.TabIndex = 3;
            this.L_Estimated.Text = "Estimated";
            // 
            // L_Percent
            // 
            this.L_Percent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Percent.AutoSize = true;
            this.L_Percent.Location = new System.Drawing.Point(89, 29);
            this.L_Percent.Name = "L_Percent";
            this.L_Percent.Size = new System.Drawing.Size(27, 13);
            this.L_Percent.TabIndex = 1;
            this.L_Percent.Text = "99%";
            // 
            // L_Elapsed
            // 
            this.L_Elapsed.AutoSize = true;
            this.L_Elapsed.Location = new System.Drawing.Point(3, 29);
            this.L_Elapsed.Name = "L_Elapsed";
            this.L_Elapsed.Size = new System.Drawing.Size(45, 13);
            this.L_Elapsed.TabIndex = 2;
            this.L_Elapsed.Text = "Elapsed";
            // 
            // ProgressBarEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "ProgressBarEx";
            this.Size = new System.Drawing.Size(207, 45);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ProgressBar PB;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label L_Estimated;
        internal System.Windows.Forms.Label L_Percent;
        internal System.Windows.Forms.Label L_Elapsed;
    }
}
