using JANL.Extensions;
using JANL.Types;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class DGVManager
{
    public static Dictionary<string, DGVTemplate> Templates { get; set; } = new Dictionary<string, DGVTemplate>();

    /// <summary>
    /// Apply Template to DGV
    /// </summary>
    /// <param name="DGV"></param>
    /// <param name="T">Template Name</param>
    public static void ApplyTemplate(DataGridView DGV, string T)
    {
        EditDGV(DGV);
        var Name = T.ToLowerInvariant();
        if (Templates.ContainsKey(Name))
        {
            EditDGVColumns(DGV, Templates[Name]);
        }
    }

    public static void ApplyTemplate(DataGridView DGV, DGVTemplate T)
    {
        EditDGV(DGV);
        EditDGVColumns(DGV, T);
    }

    public static DGVTemplate FromXML(string XML) => DGVTemplate.FromXML(XML);

    public static DGVTemplate GetItem(string Name)
    {
        Name = Name.ToLowerInvariant();
        if (!Templates.ContainsKey(Name)) return null;
        return Templates[Name];
    }

    public static void SetItem(string Name, DGVTemplate Template) => Templates[Name.ToLowerInvariant()] = Template;

    public static string ToXML(DGVTemplate T) => DGVTemplate.ToXML(T);

    private static void EditDGV(DataGridView DGV)
    {
        DGV.DoubleBuffered(true);
        DGV.ReadOnly = true;
        DGV.RowHeadersVisible = false;
        DGV.AllowUserToAddRows = false;
        DGV.AllowUserToDeleteRows = false;
        DGV.AllowUserToOrderColumns = false;
        DGV.AllowUserToResizeRows = false;
    }

    private static void EditDGVColumns(DataGridView DGV, DGVTemplate T)
    {
        DGV.AutoGenerateColumns = false;
        DGV.Columns.Clear();
        foreach (var C in T.Columns)
        {
            var DGVC = new DataGridViewTextBoxColumn()
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
            DGV.Columns.Add(DGVC);
        }
    }
}

public class DGVSettings
{
    public DGVSettings()
    {
        AllowRowsResize = false;
    }

    public bool AllowRowsResize { get; set; }
}