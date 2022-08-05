using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL
{
    /// <summary>
    /// TextBox with Label
    /// </summary>
    public class TextBoxEx : TextBox
    {
        internal PictureBox PB_Clear;
        private const string LabelPrefix = "\x200b\x200b";
        private string LabelStr;

        public TextBoxEx() : base()
        {
            InitializeComponent();

            Controls.Add(PB_Clear);
            PB_Clear.Location = new Point(-10, 0); // = New Point((Height \ 2) - (PB_Clear.Height \ 2), Width - PB_Clear.Width - 2)

            base.Text = LabelPrefix;
            ForeColor = Color.Black;
            LabelColor = Color.SlateGray;
            Label = "";
        }

        #region Properties

        #region Designer

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "0x000000")]
        public new Color ForeColor { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Description("Label")]
        public string Label
        {
            get => LabelStr.Substring(2);
            set
            {
                LabelStr = LabelPrefix + value;
                if (IsLabel) { base.Text = LabelStr; }
                UpdateColor();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "0x708090")]
        [Description("Label color")]
        public Color LabelColor { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        public new string Text
        {
            get => IsLabel ? "" : base.Text;
            set
            {
                base.Text = value?.Length == 0 ? LabelStr : value;
                UpdateColor();
            }
        }

        #endregion Designer

        [Browsable(false)]
        public bool IsLabel => base.Text.Length >= 2 && base.Text.Substring(0, 2) == LabelPrefix;

        #endregion Properties

        protected override void OnGotFocus(EventArgs e)
        {
            if (IsLabel) { Clear(); }
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (base.Text.Length == 0)
                base.Text = LabelStr;
            base.OnLostFocus(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            UpdateColor();
            base.OnTextChanged(e);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBoxEx));
            this.PB_Clear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.PB_Clear).BeginInit();
            this.SuspendLayout();
            //
            // PB_Clear
            //
            this.PB_Clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PB_Clear.BackColor = System.Drawing.Color.Transparent;
            this.PB_Clear.Image = (System.Drawing.Image)resources.GetObject("PB_Clear.Image");
            this.PB_Clear.Location = new System.Drawing.Point(0, 0);
            this.PB_Clear.Name = "PB_Clear";
            this.PB_Clear.Size = new System.Drawing.Size(16, 16);
            this.PB_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Clear.TabIndex = 0;
            this.PB_Clear.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)this.PB_Clear).EndInit();
            this.ResumeLayout(false);

            Controls.Add(PB_Clear);
        }

        private void PB_Clear_Click(object sender, EventArgs e)
        {
        }

        private void UpdateColor()
        {
            base.ForeColor = IsLabel ? LabelColor : ForeColor;
        }
    }
}