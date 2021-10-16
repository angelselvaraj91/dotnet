using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void CalculateInterestButton_Click(object sender, EventArgs e)
        {
            var principal = double.Parse(txtPrincipalAmt.Text);
            var rate = double.Parse(txtrate.Text);
            var period = double.Parse(txtperiod.Text);
            //MessageBox.Show((principal * 2).ToString(),"We will double your sum");
            var interest = (principal * rate * period) / 1200;
            var amount = principal + interest;
            txtinterest.Text = interest.ToString();
            txtAmount.Text = amount.ToString();
        }

    }
}
