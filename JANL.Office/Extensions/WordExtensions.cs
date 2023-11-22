using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using JANL.Helpers;
using System.Collections.Generic;
using System.Linq;
using WordText = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace JANL.Extensions
{
    public static class WordExtensions
    {
        /// <summary>
        /// Удалить параграф с указанным текстом
        /// </summary>
        public static void RemoveParagraph(this WordprocessingDocument package, string text) => WordHelper.RemoveParagraph(package, text);

        /// <summary>
        /// Заменить text на replacement
        /// </summary>
        public static void ReplaceText(this WordprocessingDocument package, string text, string replacement) => WordHelper.ReplaceText(package, text, replacement);

        /// <summary>
        /// Заменить text на replacement
        /// </summary>
        public static void ReplaceText(this WordprocessingDocument package, string text, object replacement) => WordHelper.ReplaceText(package, text, replacement);

        /// <summary>
		///
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		public static List<TableCell> Cells(this TableRow row)
        {
            return row?.Descendants<TableCell>().ToList();
        }

        /// <summary>
        /// Получить текст ячейки
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static List<WordText> CellTexts(this TableRow row)
        {
            return row?.Descendants<WordText>().ToList();
        }

        /// <summary>
        /// Найти таблицу по <see cref="TableProperties.TableCaption"/>
        /// </summary>
        public static Table FindTable(this WordprocessingDocument document, string name)
        {
            var tables = Tables(document);
            var table = tables.FirstOrDefault(T => T.Descendants<TableProperties>().FirstOrDefault()?.TableCaption?.Val == name);
            return table;
        }

        /// <summary>
        /// Получить строки таблицы
        /// </summary>
        public static List<TableRow> Rows(this Table table)
        {
            return table?.Descendants<TableRow>().ToList();
        }

        /// <summary>
        /// Получить таблицы документа
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public static List<Table> Tables(this WordprocessingDocument document)
        {
            return document?.MainDocumentPart.Document.Body.Descendants<Table>().ToList();
        }

        /// <summary>
        /// Получить текст ячейки
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public static WordText Text(this TableCell cell)
        {
            return cell?.Descendants<WordText>().FirstOrDefault();
        }
    }
}