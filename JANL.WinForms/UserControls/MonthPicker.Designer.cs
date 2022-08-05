namespace JANL.UserControls
{
    partial class MonthPicker
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.CB_Year, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.CB_Month, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(158, 21);
            this.TableLayoutPanel1.TabIndex = 3;
            // 
            // CB_Year
            // 
            this.CB_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CB_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Location = new System.Drawing.Point(108, 0);
            this.CB_Year.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(50, 21);
            this.CB_Year.TabIndex = 1;
            // 
            // CB_Month
            // 
            this.CB_Month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Location = new System.Drawing.Point(0, 0);
            this.CB_Month.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.CB_Month.MaxDropDownItems = 12;
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(102, 21);
            this.CB_Month.TabIndex = 0;
            // 
            // MonthPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "MonthPicker";
            this.Size = new System.Drawing.Size(158, 21);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.ComboBox CB_Year;
        internal System.Windows.Forms.ComboBox CB_Month;
    }
}
