using JANL.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Types
{
    internal class DesignColumn
    {
        private static int Count;

        public DesignColumn()
        {
            Name = $"Column{Count}";
            Header = Name;
            Width = 100;
            AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            Visible = true;
            ForeColor = Color.Black;
            Font = Settings.Default.Font;
            Count++;
        }

        public DesignColumn(DGVTemplateColumn C)
        {
            Name = C.Name;
            Header = C.Header;
            Width = C.Width;
            AutoSizeMode = C.AutoSizeMode;
            Visible = C.Visible;
            ForeColor = ColorTranslator.FromHtml(C.ForeColor);
            Font = (Font)new FontConverter().ConvertFromInvariantString(C.Font);
        }

        public override string ToString() => $"{Name}({Header}, {Width})";

        public DGVTemplateColumn ToTemplate()
        {
            return new DGVTemplateColumn()
            {
                Name = Name,
                Header = Header,
                Width = Width,
                AutoSizeMode = AutoSizeMode,
                Visible = Visible,
                ForeColor = ColorTranslator.ToHtml(ForeColor),
                Font = new FontConverter().ConvertToInvariantString(Font)
            };
        }

        #region Properties

        [Description("Способ регулирования ширины столбца")]
        [DefaultValue(typeof(DataGridViewAutoSizeColumnMode), "NotSet")]
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }

        [Description("Шрифт текста")]
        [DefaultValue(typeof(Font), "Segoe UI, 8.25pt")]
        public Font Font { get; set; }

        [Description("Цвет текста")]
        [DefaultValue(typeof(Color), "0x000000")]
        public Color ForeColor { get; set; }

        [Description("Заголовок столбца")]
        public string Header { get; set; }

        [Description("Имя столбца")]
        public string Name { get; set; }

        [Description("Видимость столбца")]
        [DefaultValue(true)]
        public bool Visible { get; set; }

        [Description("Ширина столбца")]
        [DefaultValue(100)]
        public int Width { get; set; }

        #endregion Properties
    }
}