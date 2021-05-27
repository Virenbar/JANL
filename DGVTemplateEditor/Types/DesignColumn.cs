using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DGVTemplateEditor.Types
{
	public class DesignColumn
	{
		private static int Count = 0;

		public DesignColumn()
		{
			Name = $"Column{Count++}";
			Header = Name;
			Width = 100;
			AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			Visible = true;
			ForeColor = Color.Black;
		}

		public DesignColumn(string name, string header, int width, DataGridViewAutoSizeColumnMode autoSizeMode, bool visible) : this()
		{
			Name = name;
			Header = header;
			Width = width;
			AutoSizeMode = autoSizeMode;
			Visible = visible;
		}

		public DesignColumn(DGVTemplateColumn C) : this()
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
		public int Width { get; set; }

		[Description("Способ регулирования ширины столбца"), DefaultValue(typeof(DataGridViewAutoSizeColumnMode), "NotSet")]
		public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }

		[Description("Видимость столбца"), DefaultValue(true)]
		public bool Visible { get; set; }

		[Description("Цвет текста"), DefaultValue(typeof(Color), "0x000000")]
		public Color ForeColor { get; set; }
	}
}