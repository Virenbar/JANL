using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL
{
	public partial class Blocker : Component
	{
		public Control Parent { get; set; }
		private UC_Loader L = new UC_Loader();

		public void Show()
		{
			if (Parent == null) { return; }
			Parent.Controls.Add(L);
		}

		public void Hide()
		{
			if (Parent == null) { return; }
			Parent.Controls.Remove(L);
		}

		public Blocker()
		{
			InitializeComponent();
		}

		public Blocker(IContainer container)
		{
			container.Add(this);
			InitializeComponent();
		}
	}
}