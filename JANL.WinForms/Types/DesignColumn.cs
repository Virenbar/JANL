using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Types
{
    internal class DesignColumn
    {
        private static int Count = 0;

        public DesignColumn()
        {
            Name = $"Column{Count}";
            Header = Name;
            Width = 100;
            AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            Visible = true;
            ForeColor = Color.Black;
            Count += 1;
        }

        public DesignColumn(DGVTemplateColumn C)
        {
            Name = C.Name;
            Header = C.Header;
            Width = C.Width;
            AutoSizeMode = C.AutoSizeMode;
            Visible = C.Visible;
            ForeColor = ColorTranslator.FromHtml(C.ForeColor);
        }

        public DGVTemplateColumn ToTemplate()
        {
            return new DGVTemplateColumn()
            {
                Name = Name,
                Header = Header,
                Width = Width,
                AutoSizeMode = AutoSizeMode,
                Visible = Visible,
                ForeColor = ColorTranslator.ToHtml(ForeColor)
            };
        }

        [Description("Имя столбца")]
        public string Name { get; set; }

        [Description("Заголовок столбца")]
        public string Header { get; set; }

        [Description("Ширина столбца")]
        [DefaultValue(100)]
        public int Width { get; set; }

        [Description("Способ регулирования ширины столбца")]
        [DefaultValue(typeof(DataGridViewAutoSizeColumnMode), "NotSet")]
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }

        [Description("Видимость столбца")]
        [DefaultValue(true)]
        public bool Visible { get; set; }

        [Description("Цвет текста")]
        [DefaultValue(typeof(Color), "0x000000")]
        public Color ForeColor { get; set; }

        // <Description("Шрифт текста"), DefaultValue(GetType(Color), "0x000000"), Category("У")>
        // Public Property Font As Font
        public override string ToString() => $"{Name}({Header}, {Width})";
    }
}