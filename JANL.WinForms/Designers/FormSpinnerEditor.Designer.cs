namespace JANL.Designers
{
    partial class FormSpinnerEditor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "-"}, -1);
            this.LV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LV.Location = new System.Drawing.Point(88, 56);
            this.LV.MultiSelect = false;
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(264, 279);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.ItemActivate += new System.EventHandler(this.LV_ItemActivate);
            this.LV.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.LV_ItemMouseHover);
            // 
            // FormSpinnerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LV);
            this.Name = "FormSpinnerEditor";
            this.Text = "FormSpinnerEditor";
            this.Load += new System.EventHandler(this.FormSpinnerEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}