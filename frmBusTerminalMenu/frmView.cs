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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        public static string filename;
        private DialogResult result;

        private void frmView_Load(object sender, EventArgs e)
        {
            lvSearch.AutoSize = false;

            string documentsPath = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Buyers";

            // get a list of all txt files in the documents folder
            string[] txtFiles = Directory.GetFiles(documentsPath, "*.txt");

            // add the file names to the listview
            foreach (string file in txtFiles)
            {
                lvSearch.Items.Add(Path.GetFileName(file));
            }
        }

        private void lblDestination_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {


            // get the selected file name from the first listview
            string fileName = lvSearch.SelectedItems[0].Text;

            // get the path to the documents folder
            string documentsPath = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Buyers";

            // get the full path to the file
            string filePath = Path.Combine(documentsPath, fileName);

            // read the file and store the contents in a string array
            string[] fileContent = File.ReadAllLines(filePath);

            // clear the second listview
            lvDest2.Items.Clear();

            // add each line of the file to the second listview as a separate item
            foreach (string line in fileContent)
            {
                ListViewItem item = new ListViewItem(line);
                lvDest2.Items.Add(item);
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            lvSearch.Clear();
            lvSearch.AutoSize = false;
            string documentsPath = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Buyers";

            // get a list of all txt files in the documents folder
            string[] txtFiles = Directory.GetFiles(documentsPath, "*.txt");

            // add the file names to the listview
            foreach (string file in txtFiles)
            {
                lvSearch.Items.Add(Path.GetFileName(file));
            }
            
        }
    }
}
