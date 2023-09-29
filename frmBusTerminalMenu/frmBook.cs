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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        public static string name;


        private void btnNext2_Click(object sender, EventArgs e)
        {
            frmDetails details = new frmDetails();
            details.Show();


            string input1 = tbName.Text; // get the user input from the first textbox
            string input2 = tbDestinationNumber.Text; // get the user input from the second textbox
            string input3 = tbTicketAmount.Text; // get the user input from the third textbox
            string input4 = tbHowManyHaveDiscount.Text; // get the user input from the third textbox

            // concatenate the input from all textboxes
            string input = input1 + "\r\n" + input2 + "\r\n" + input3 + "\r\n" + input4;

            // get the path to the documents folder
            string documentsPath = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Buyers";

            // specify the file name
            string fileName = tbName.Text + ".txt";

            // combine the documents path with the file name
            string fullPath = Path.Combine(documentsPath, fileName);

            // write the input to the text file
            File.WriteAllText(fullPath, input);
        }







        private void frmBook_Load(object sender, EventArgs e)
        {
            name = tbName.Text;

            bookNowData();

        }

        private DialogResult result;
        string bookNowfilename = @"C:\Users\USER\source\repos\BusTerminalTicketGenerator\Destination.txt";


        private void bookNowData()
        {

            lvDest2.Items.Clear();

            string[] lines = File.ReadAllLines(bookNowfilename);

            foreach (string line in lines)
            {
                lvDest2.Items.Add(line);
            }




        }
    }
}
