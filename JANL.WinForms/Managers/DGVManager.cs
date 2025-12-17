using JANL.Extensions;
using JANL.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JANL.Managers
{
    /// <summary>
    ///
    /// </summary>
    public static class DGVManager
    {
        /// <summary>
        /// Formats for DGV columns by name(lowercase)
        /// </summary>
        public static Dictionary<string, DGVTemplateColumn> Columns { get; set; } = new Dictionary<string, DGVTemplateColumn>();

        /// <summary>
        /// Templates for DGV by name(lowercase)
        /// </summary>
        public static Dictionary<string, DGVTemplate> Templates { get; set; } = new Dictionary<string, DGVTemplate>();

        /// <summary>
        /// Apply Template to DGV
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="template">Template Name</param>
        /// <param name="settings"></param>
        public static void ApplyTemplate(DataGridView dgv, string template, DGVSettings settings)
        {
            EditDGV(dgv, settings);
            var Name = template.ToLowerInvariant();
            if (Templates.ContainsKey(Name))
            {
                EditDGVColumns(dgv, Templates[Name]);
            }
        }

        /// <summary>
        /// Apply Template to DGV
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="template">Template Name</param>
        public static void ApplyTemplate(DataGridView dgv, string template) => ApplyTemplate(dgv, template, new DGVSettings());

        /// <summary>
        /// Apply Template to DGV
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="template">Template</param>
        /// <param name="settings"></param>
        public static void ApplyTemplate(DataGridView dgv, DGVTemplate template, DGVSettings settings)
        {
            EditDGV(dgv, settings);
            EditDGVColumns(dgv, template);
        }

        /// <summary>
        /// Apply Template to DGV
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="template">Template</param>
        public static void ApplyTemplate(DataGridView dgv, DGVTemplate template) => ApplyTemplate(dgv, template, new DGVSettings());

        /// <summary>
        ///
        /// </summary>
        /// <param name="XML"></param>
        /// <returns></returns>
        public static DGVTemplateColumn ColumnFromXML(string XML) => DGVTemplateColumn.FromXML(XML);

        /// <summary>
        /// Format columns using <see cref="Columns"/>
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="settings"></param>
        public static void FormatColumns(DataGridView dgv, DGVSettings settings)
        {
            EditDGV(dgv, settings);
            EditDGVColumns(dgv);
        }

        /// <summary>
        /// Format columns using <see cref="Columns"/>
        /// </summary>
        /// <param name="dgv"></param>
        public static void FormatColumns(DataGridView dgv) => FormatColumns(dgv, new DGVSettings());

        /// <summary>
        ///
        /// </summary>
        /// <param name="XML"></param>
        /// <returns></returns>
        [Obsolete("Use TemplateFromXML()")]
        public static DGVTemplate FromXML(string XML) => TemplateFromXML(XML);

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static DGVTemplate GetItem(string Name)
        {
            Name = Name.ToLowerInvariant();
            if (!Templates.ContainsKey(Name)) { return null; }
            return Templates[Name];
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Template"></param>
        public static void SetItem(string Name, DGVTemplate Template) => Templates[Name.ToLowerInvariant()] = Template;

        /// <summary>
        ///
        /// </summary>
        /// <param name="XML"></param>
        /// <returns></returns>
        public static DGVTemplate TemplateFromXML(string XML) => DGVTemplate.FromXML(XML);

        /// <summary>
        ///
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public static string ToXML(DGVTemplate T) => DGVTemplate.ToXML(T);

        /// <summary>
        ///
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public static string ToXML(DGVTemplateColumn T) => DGVTemplateColumn.ToXML(T);

        private static void EditDGV(DataGridView dgv, DGVSettings settings)
        {
            dgv.DoubleBuffered(true);
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = settings.AllowRowsResize;
            dgv.AllowUserToOrderColumns = settings.AllowUserToOrderColumns;
        }

        private static void EditDGVColumns(DataGridView dgv, DGVTemplate T)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            foreach (var C in T.Columns)
            {
                var DGVC = new DataGridViewTextBoxColumn
                {
                    Name = C.Name,
                    HeaderText = C.Header,
                    AutoSizeMode = C.AutoSizeMode,
                    Width = C.Width,
                    DataPropertyName = C.Name,
                    Visible = C.Visible
                };
                DGVC.DefaultCellStyle.Font = (Font)new FontConverter().ConvertFromInvariantString(C.Font);
                DGVC.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(C.ForeColor);
                dgv.Columns.Add(DGVC);
            }
        }

        private static void EditDGVColumns(DataGridView DGV)
        {
            DGV.AutoGenerateColumns = false;
            foreach (DataGridViewColumn C in DGV.Columns)
            {
                var Name = C.Name.ToLowerInvariant();
                if (Columns.ContainsKey(Name))
                {
                    var Column = Columns[Name];
                    C.HeaderText = Column.Header;
                    C.AutoSizeMode = Column.AutoSizeMode;
                    C.Width = Column.Width;
                    C.DataPropertyName = Column.Name;
                    C.Visible = Column.Visible;
                    C.DefaultCellStyle.Font = (Font)new FontConverter().ConvertFromInvariantString(Column.Font);
                    C.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(Column.ForeColor);
                }
            }
        }
    }
    /// <summary>
    /// Настройки
    /// </summary>
    public class DGVSettings
    {
        /// <summary>
        ///
        /// </summary>
        public DGVSettings()
        {
            AllowUserToOrderColumns = false;
            AllowRowsResize = false;
        }

        /// <summary>
        /// Разрешить изменение ширины столбцов
        /// </summary>
        public bool AllowRowsResize { get; set; }

        /// <summary>
        /// Разрешить упорядочивание столбцов
        /// </summary>
        public bool AllowUserToOrderColumns { get; set; }
    }
}