using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBusTerminalMenu
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void lvDest2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmFare fare = new frmFare();
            fare.Show();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            
        }


        
        


    }
}
