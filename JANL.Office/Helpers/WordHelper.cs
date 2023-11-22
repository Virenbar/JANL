using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;
using System.Linq;

namespace JANL.Helpers
{
    public static class WordHelper
    {
        /// <summary>
        /// Удалить параграф с указанным текстом
        /// </summary>
        /// <param name="text"></param>
        public static void RemoveParagraph(WordprocessingDocument package, string text)
        {
            var Body = package.MainDocumentPart.Document.Body;
            foreach (var run in Body.Descendants<Run>().Where(R => R.InnerText.Contains(text)))
            {
                run.Parent.Remove();
            }
        }

        /// <summary>
        /// Заменить text на replacement
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replacement"></param>
        public static void ReplaceText(WordprocessingDocument package, string text, string replacement)
        {
            TextReplacer.SearchAndReplace(package, text, replacement, false);
        }

        /// <summary>
        /// Заменить text на replacement
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replacement"></param>
        public static void ReplaceText(WordprocessingDocument package, string text, object replacement)
        {
            if (replacement is string str) { ReplaceText(package, text, str); }
            else { ReplaceText(package, text, ""); }
        }
    }
}