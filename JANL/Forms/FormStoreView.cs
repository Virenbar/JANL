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
    public partial class FormStoreView<K> : Form where K : struct
    {
        private BaseStoreView<K> StoreView;
        private UserControl Header;

        public FormStoreView(BaseStoreView<K> SV) : this() { StoreView = SV; }

        protected FormStoreView()
        {
            InitializeComponent();
        }
    }
}