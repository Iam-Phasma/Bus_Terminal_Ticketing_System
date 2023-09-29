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
    public partial class frmDestination : Form
    {
        public frmDestination()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDestination_Load(object sender, EventArgs e)
        {
            destData();
        }
        
        

        private DialogResult result;
        string filename = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Destination.txt";

        private void destData()
        {

            lvDest.Items.Clear();

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                lvDest.Items.Add(line);
            }




        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
        }
    }
}
