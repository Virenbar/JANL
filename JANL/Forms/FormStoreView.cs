using JANL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.Forms
{
    public partial class FormStoreView : Form
    {
        private BaseStoreView StoreView;
        private UserControl Header;
        private UserControl Footer;

        public FormStoreView(BaseStoreView SV) : this() { StoreView = SV; }

        protected FormStoreView()
        {
            InitializeComponent();
        }
    }
}