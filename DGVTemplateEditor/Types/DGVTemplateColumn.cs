using System.Drawing;
using System.Windows.Forms;

namespace DGVTemplateEditor.Types
{
	public class DGVTemplateColumn
	{
		public DGVTemplateColumn()
		{
			Width = 100;
			AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			Visible = true;
			ForeColor = ColorTranslator.ToHtml(Color.Black);
		}

		public DGVTemplateColumn(string name, string header, int width, DataGridViewAutoSizeColumnMode autoSizeMode, bool visible) : this()
		{
			Name = name;
			Header = header;
			Width = width;
			AutoSizeMode = autoSizeMode;
			Visible = visible;
		}

		public string Name { get; set; }

		public string Header { get; set; }

		public int Width { get; set; }

		public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }

		public bool Visible { get; set; }
		public string ForeColor { get; set; }
	}
}