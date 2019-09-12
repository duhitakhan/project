using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsFormsApp1
{
    public partial class DatatypeUI : Form
    {
        public DatatypeUI()
        {
            InitializeComponent();
        }


        private void showButton1_Click(object sender, EventArgs e)
        {

            if (itemComboBox1.Text == "")
            {
                MessageBox.Show("Select item");
            }
            else
            {
                MessageBox.Show(itemComboBox1.Text + "is selected");
            }
        }
    }
}
