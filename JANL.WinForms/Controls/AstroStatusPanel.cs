using JANL.Drawing;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Controls
{
    /// <summary>
    /// Панели для отображения цвета на основе статуса <see cref="Status"/>
    /// </summary>
    public class AstroStatusPanel : Panel
    {
        private readonly Panel Internal;

        /// <summary>
        /// Создаёт новую панель
        /// </summary>
        public AstroStatusPanel()
        {
            Size = new Size(150, 50);
            Padding = new Padding(3);

            Internal = new Panel() { Dock = DockStyle.Fill };
            Controls.Add(Internal);
            UpdatePanel();
        }

        /// <summary>
        /// Создаёт новую панель с указанным статусом
        /// </summary>
        /// <param name="status">Статус</param>
        public AstroStatusPanel(AstroStatus status) : this()
        {
            Status = status;
        }

        private void UpdatePanel()
        {
            var status = Status;
            if (DarkMode)
            {
                base.BackColor = AstroColor.GetDark(status);
                Internal.Visible = false;
            }
            else
            {
                base.BackColor = AstroColor.GetLightBorder(status);
                Internal.BackColor = AstroColor.GetLight(status);
                Internal.Visible = true;
            }
        }

        #region Properties

        /// <summary>
        /// Цвет фона панели
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor => base.BackColor;

        #region Designer

        private bool _darkMode;
        private AstroStatus _status = AstroStatus.Off;

        /// <summary>
        /// Тёмный режим панели
        /// </summary>
        [Browsable(true), Category("Appearance"), Description("Тёмный режим"), DefaultValue(false)]
        public bool DarkMode
        {
            get => _darkMode;
            set
            {
                if (_darkMode == value) { return; }
                _darkMode = value;
                UpdatePanel();
            }
        }

        /// <summary>
        /// Статус
        /// </summary>
        [Browsable(true), Category("Appearance"), Description("Статус"), DefaultValue(typeof(AstroStatus), "Off")]
        public AstroStatus Status
        {
            get => _status;
            set
            {
                if (_status == value) { return; }
                _status = value;
                UpdatePanel();
            }
        }

        #endregion Designer

        #endregion Properties
    }
}