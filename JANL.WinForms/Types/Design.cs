using System.Collections.Generic;
using System.Linq;

namespace JANL.Types
{
    internal class Design
    {
        public List<DesignColumn> Columns;

        public Design() { }

        public Design(DGVTemplate T)
        {
            Columns = T.Columns.Select(c => new DesignColumn(c)).ToList();
        }

        // <Description("Ширина столбца")>
        // Public Font Font { Get; Set; }

        public static Design FromTemplate(DGVTemplate T) => new Design(T);

        public DGVTemplate ToTemplate() => new DGVTemplate() { Columns = Columns.Select(c => c.ToTemplate()).ToList() };
    }
}