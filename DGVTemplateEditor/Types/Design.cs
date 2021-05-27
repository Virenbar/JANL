using System.Collections.Generic;
using System.Linq;

namespace DGVTemplateEditor.Types
{
	public class Design
	{
		public Design()
		{
		}

		public Design(DGVTemplate T)
		{
			Columns = T.Columns.Select(c => new DesignColumn(c)).ToList();
		}

		public List<DesignColumn> Columns { get; set; }

		public static Design FromTemplate(DGVTemplate T)
		{
			return new Design(T);
		}

		public DGVTemplate ToTemplate()
		{
			return new DGVTemplate
			{
				Columns = Columns.Select(c => c.ToTemplate()).ToList()
			};
		}
	}
}