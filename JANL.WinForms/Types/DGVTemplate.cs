using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace JANL.Types
{
    public class DGVTemplate
    {
        public DGVTemplate()
        {
            Columns = new List<DGVTemplateColumn>();
        }

        public DGVTemplate(IEnumerable<DGVTemplateColumn> DGVColumns)
        {
            Columns = new List<DGVTemplateColumn>(DGVColumns);
        }

        public List<DGVTemplateColumn> Columns { get; set; }

        public static DGVTemplate FromXML(string XML)
        {
            XmlSerializer XS = new XmlSerializer(typeof(DGVTemplate));
            using (var SR = new StringReader(XML))
            {
                var T = (DGVTemplate)XS.Deserialize(SR);
                return T;
            }
        }

        public static string ToXML(DGVTemplate T)
        {
            var XS = new XmlSerializer(typeof(DGVTemplate));
            using (var SW = new StringWriter())
            {
                XS.Serialize(SW, T);
                return SW.ToString();
            }
        }
    }
}