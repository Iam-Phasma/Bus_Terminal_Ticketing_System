using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBusTerminalMenu
{
    public partial class frmFare : Form
    {
        public frmFare()
        {
            InitializeComponent();
        }

        private void btnNextFare_Click(object sender, EventArgs e)
        {
            frmView view = new frmView();
            view.Show();
        }
    }
}
