using JANL.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JANL.Types
{
    public class DGVTemplateColumn
    {
        public DGVTemplateColumn()
        {
            Name = "Column";
            Header = "Header";
            Width = 100;
            AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            Visible = true;
            ForeColor = ColorTranslator.ToHtml(Color.Black);
            Font = new FontConverter().ConvertToInvariantString(Settings.Default.Font);
        }

        public DGVTemplateColumn(string name, string header, int width, DataGridViewAutoSizeColumnMode autoSizeMode, bool visible) : this()
        {
            Name = name;
            Header = header;
            Width = width;
            AutoSizeMode = autoSizeMode;
            Visible = visible;
        }

        public DGVTemplateColumn(string name, string header, int width) : this(name, header, width, DataGridViewAutoSizeColumnMode.NotSet, true) { }

        public DGVTemplateColumn(string name, string header, DataGridViewAutoSizeColumnMode autoSizeMode) : this(name, header, 100, autoSizeMode, true) { }

        #region Properties
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }
        public string Font { get; set; }
        public string ForeColor { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public int Width { get; set; }
        #endregion Properties

        public static DGVTemplateColumn FromXML(string XML)
        {
            XmlSerializer XS = new XmlSerializer(typeof(DGVTemplateColumn));
            using (var SR = new StringReader(XML))
            {
                var T = (DGVTemplateColumn)XS.Deserialize(SR);
                return T;
            }
        }

        public static string ToXML(DGVTemplateColumn T)
        {
            var XS = new XmlSerializer(typeof(DGVTemplateColumn));
            using (var SW = new StringWriter())
            {
                XS.Serialize(SW, T);
                return SW.ToString();
            }
        }
    }
}