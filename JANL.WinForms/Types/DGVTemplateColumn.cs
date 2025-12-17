using JANL.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JANL.Types
{
    /// <summary>
    /// Шаблон столбца
    /// </summary>
    public class DGVTemplateColumn
    {
        /// <summary>
        ///
        /// </summary>
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="header"></param>
        /// <param name="width"></param>
        /// <param name="autoSizeMode"></param>
        /// <param name="visible"></param>
        public DGVTemplateColumn(string name, string header, int width, DataGridViewAutoSizeColumnMode autoSizeMode, bool visible) : this()
        {
            Name = name;
            Header = header;
            Width = width;
            AutoSizeMode = autoSizeMode;
            Visible = visible;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="header"></param>
        /// <param name="width"></param>
        public DGVTemplateColumn(string name, string header, int width) : this(name, header, width, DataGridViewAutoSizeColumnMode.NotSet, true) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="header"></param>
        /// <param name="autoSizeMode"></param>
        public DGVTemplateColumn(string name, string header, DataGridViewAutoSizeColumnMode autoSizeMode) : this(name, header, 100, autoSizeMode, true) { }

        #region Properties

        /// <summary>
        ///
        /// </summary>
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Font { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string ForeColor { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int Width { get; set; }

        #endregion Properties

        /// <summary>
        ///
        /// </summary>
        /// <param name="XML"></param>
        /// <returns></returns>
        public static DGVTemplateColumn FromXML(string XML)
        {
            XmlSerializer XS = new XmlSerializer(typeof(DGVTemplateColumn));
            using (var SR = new StringReader(XML))
            {
                var T = (DGVTemplateColumn)XS.Deserialize(SR);
                return T;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
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