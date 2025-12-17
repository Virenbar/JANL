using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace JANL.Types
{
    /// <summary>
    /// Шаблон <see cref="System.Windows.Forms.DataGridView"/>
    /// </summary>
    public class DGVTemplate
    {
        /// <summary>
        ///
        /// </summary>
        public DGVTemplate()
        {
            Columns = new List<DGVTemplateColumn>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="DGVColumns">Столбцы шаблона</param>
        public DGVTemplate(IEnumerable<DGVTemplateColumn> DGVColumns)
        {
            Columns = new List<DGVTemplateColumn>(DGVColumns);
        }

        /// <summary>
        /// Столбцы шаблона
        /// </summary>
        public List<DGVTemplateColumn> Columns { get; set; }

        /// <summary>
        /// Преобразует XML в шаблон
        /// </summary>
        /// <param name="xml">XML</param>
        /// <returns></returns>
        public static DGVTemplate FromXML(string xml)
        {
            XmlSerializer XS = new XmlSerializer(typeof(DGVTemplate));
            using (var SR = new StringReader(xml))
            {
                var T = (DGVTemplate)XS.Deserialize(SR);
                return T;
            }
        }

        /// <summary>
        /// Преобразует шаблон в XML
        /// </summary>
        /// <param name="template">Шаблон</param>
        /// <returns></returns>
        public static string ToXML(DGVTemplate template)
        {
            var XS = new XmlSerializer(typeof(DGVTemplate));
            using (var SW = new StringWriter())
            {
                XS.Serialize(SW, template);
                return SW.ToString();
            }
        }
    }
}