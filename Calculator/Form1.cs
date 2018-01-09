using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string val = btn.Text;

            if(val == "x")
            {
                val = "*";
            }
            else if(val == "π")
            {
                val = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234";
            }
            else if(val == "clear")
            {
                calculations.Text = "";
                return;
            }

            calculations.Text += val;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string equation = calculations.Text;

            DataTable dt = new DataTable();

            var ans = dt.Compute(equation, "");

            calculations.Text = ans.ToString();
        }

    }
}
