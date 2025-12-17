using System.Collections.Generic;
using System.Linq;

namespace JANL.Types
{
    internal class Design
    {
        public List<DesignColumn> Columns = new List<DesignColumn>();

        public Design() { }

        protected Design(DGVTemplate T)
        {
            Columns = T.Columns.Select(c => DesignColumn.FromTemplate(c)).ToList();
        }

        public static Design FromTemplate(DGVTemplate T)
        {
            var D = new Design
            {
                Columns = T.Columns.Select(c => DesignColumn.FromTemplate(c)).ToList()
            };
            return D;
        }

        public DGVTemplate ToTemplate() => new DGVTemplate { Columns = Columns.Select(c => c.ToTemplate()).ToList() };
    }
}