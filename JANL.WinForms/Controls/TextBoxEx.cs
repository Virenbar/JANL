using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// TextBox with Label
    /// </summary>
    [Obsolete("WIP")]
    public class TextBoxEx : TextBoxLabel
    {
        internal PictureBox PB_Clear;

        public TextBoxEx()
        {
            InitializeComponent();

            //Controls.Add(PB_Clear);
            //  PB_Clear.Location = new Point(0, 0); // = New Point((Height \ 2) - (PB_Clear.Height \ 2), Width - PB_Clear.Width - 2)
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //  _button.Size = new Size(_button.Width, this.ClientSize.Height + 2);
            PB_Clear.Location = new Point(this.ClientSize.Width - PB_Clear.Width, -1);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            //SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(_button.Width << 16));
        }

        #region Properties

        #region Designer

        //j

        #endregion Designer

        #endregion Properties

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(TextBoxEx));
            PB_Clear = new PictureBox();
            ((ISupportInitialize)PB_Clear).BeginInit();
            SuspendLayout();
            //
            // PB_Clear
            //
            PB_Clear.Anchor = AnchorStyles.Right;
            PB_Clear.BackColor = Color.Transparent;
            PB_Clear.Image = (Image)(resources.GetObject("PB_Clear.Image"));
            PB_Clear.Location = new Point(this.ClientSize.Width - PB_Clear.Width, -1);// new Point(0, 0);
            PB_Clear.Name = "PB_Clear";
            PB_Clear.Size = new Size(16, 16);
            PB_Clear.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Clear.TabIndex = 0;
            PB_Clear.TabStop = false;
            //
            // TextBoxEx
            //
            Controls.Add(PB_Clear);
            ((ISupportInitialize)PB_Clear).EndInit();
            ResumeLayout(false);
        }
    }
}