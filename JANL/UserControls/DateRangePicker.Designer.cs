namespace JANL.UserControls
{
    partial class DateRangePicker
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DTP_Begin = new System.Windows.Forms.DateTimePicker();
            this.L_Begin = new System.Windows.Forms.Label();
            this.L_End = new System.Windows.Forms.Label();
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.L_Begin);
            this.flowLayoutPanel1.Controls.Add(this.DTP_Begin);
            this.flowLayoutPanel1.Controls.Add(this.L_End);
            this.flowLayoutPanel1.Controls.Add(this.DTP_End);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 20);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DTP_Begin
            // 
            this.DTP_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Begin.Location = new System.Drawing.Point(23, 0);
            this.DTP_Begin.Margin = new System.Windows.Forms.Padding(0);
            this.DTP_Begin.Name = "DTP_Begin";
            this.DTP_Begin.Size = new System.Drawing.Size(92, 20);
            this.DTP_Begin.TabIndex = 0;
            this.DTP_Begin.ValueChanged += new System.EventHandler(this.DTP_Begin_ValueChanged);
            // 
            // L_Begin
            // 
            this.L_Begin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_Begin.AutoSize = true;
            this.L_Begin.Location = new System.Drawing.Point(0, 3);
            this.L_Begin.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.L_Begin.Name = "L_Begin";
            this.L_Begin.Size = new System.Drawing.Size(20, 13);
            this.L_Begin.TabIndex = 1;
            this.L_Begin.Text = "От";
            // 
            // L_End
            // 
            this.L_End.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_End.AutoSize = true;
            this.L_End.Location = new System.Drawing.Point(118, 3);
            this.L_End.Name = "L_End";
            this.L_End.Size = new System.Drawing.Size(19, 13);
            this.L_End.TabIndex = 1;
            this.L_End.Text = "по";
            // 
            // DTP_End
            // 
            this.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_End.Location = new System.Drawing.Point(140, 0);
            this.DTP_End.Margin = new System.Windows.Forms.Padding(0);
            this.DTP_End.Name = "DTP_End";
            this.DTP_End.Size = new System.Drawing.Size(92, 20);
            this.DTP_End.TabIndex = 0;
            this.DTP_End.ValueChanged += new System.EventHandler(this.DTP_End_ValueChanged);
            // 
            // DateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DateRange";
            this.Size = new System.Drawing.Size(232, 20);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label L_Begin;
        private System.Windows.Forms.DateTimePicker DTP_Begin;
        private System.Windows.Forms.Label L_End;
        private System.Windows.Forms.DateTimePicker DTP_End;
    }
}
