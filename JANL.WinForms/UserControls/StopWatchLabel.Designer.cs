namespace JANL.UserControls
{
    partial class StopWatchLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatchLabel));
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.L_Prefix = new System.Windows.Forms.Label();
            this.L_Time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Image
            // 
            this.PB_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Image.BackColor = System.Drawing.Color.Transparent;
            this.PB_Image.Image = ((System.Drawing.Image)(resources.GetObject("PB_Image.Image")));
            this.PB_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Image.InitialImage")));
            this.PB_Image.Location = new System.Drawing.Point(0, 13);
            this.PB_Image.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Image.MaximumSize = new System.Drawing.Size(32, 32);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(32, 32);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image.TabIndex = 0;
            this.PB_Image.TabStop = false;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.PB_Image, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.FlowLayoutPanel1, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(287, 59);
            this.TableLayoutPanel1.TabIndex = 2;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.L_Prefix);
            this.FlowLayoutPanel1.Controls.Add(this.L_Time);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(32, 23);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(66, 13);
            this.FlowLayoutPanel1.TabIndex = 2;
            // 
            // L_Prefix
            // 
            this.L_Prefix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Prefix.AutoSize = true;
            this.L_Prefix.Location = new System.Drawing.Point(0, 0);
            this.L_Prefix.Margin = new System.Windows.Forms.Padding(0);
            this.L_Prefix.Name = "L_Prefix";
            this.L_Prefix.Size = new System.Drawing.Size(36, 13);
            this.L_Prefix.TabIndex = 2;
            this.L_Prefix.Text = "Prefix:";
            // 
            // L_Time
            // 
            this.L_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Time.AutoSize = true;
            this.L_Time.Location = new System.Drawing.Point(36, 0);
            this.L_Time.Margin = new System.Windows.Forms.Padding(0);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(30, 13);
            this.L_Time.TabIndex = 1;
            this.L_Time.Text = "Time";
            // 
            // StopWatchLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "StopWatchLabel";
            this.Size = new System.Drawing.Size(287, 59);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PB_Image;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Label L_Prefix;
        internal System.Windows.Forms.Label L_Time;
    }
}
