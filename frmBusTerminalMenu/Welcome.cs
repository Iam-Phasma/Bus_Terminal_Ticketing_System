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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            frmDestination destination = new frmDestination();
            destination.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
        }

        private void btnFare_Click(object sender, EventArgs e)
        {
            frmFare fare = new frmFare();
            fare.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmView view = new frmView();
            view.Show();
        }
    }
}
