using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneGUI
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void ResulttxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //Source:  //source:  https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0
                // Input Validation 
                decimal Shir = 62.99m;
                ResulttxtBx.Text = Shir.ToString();
            }
            if (radioButton2.Checked)
            {
                decimal Pants = 15.45m;
                ResulttxtBx.Text = Pants.ToString();
            }
            if (radioButton3.Checked)
            {
                decimal Hat = 12.32m;
                ResulttxtBx.Text = Hat.ToString();
            }
        }
    }
}
