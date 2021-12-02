namespace JANL
{
	partial class UC_Loader
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
			this.PB_Image = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// PB_Image
			// 
			this.PB_Image.BackColor = System.Drawing.Color.Transparent;
			this.PB_Image.Image = global::JANL.Properties.Resources.partner64;
			this.PB_Image.Location = new System.Drawing.Point(393, 114);
			this.PB_Image.Name = "PB_Image";
			this.PB_Image.Size = new System.Drawing.Size(64, 64);
			this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PB_Image.TabIndex = 0;
			this.PB_Image.TabStop = false;
			// 
			// UC_Loader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.PB_Image);
			this.Name = "UC_Loader";
			this.Size = new System.Drawing.Size(702, 360);
			this.Load += new System.EventHandler(this.UC_Loader_Load);
			this.Resize += new System.EventHandler(this.UC_Loader_Resize);
			((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PB_Image;
	}
}
