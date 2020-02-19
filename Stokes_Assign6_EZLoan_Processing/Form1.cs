using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Jesse Stokes
// 4/5/2019
// EZ Loan Processing App


namespace Stokes_Assign6_EZLoan_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.SelectedIndex == 0)
            {
                lbIntRate.Text = "0.075";
                lbNumYears.Text = "4";
                lbCarDetails.Visible = true;
                lbCarMake.Visible = true;
                tbCarMake.Visible = true;
                lbCarModel.Visible = true;
                tbCarModel.Visible = true;
                lbCarYear.Visible = true;
                tbCarYear.Visible = true;
                lbCarColor.Visible = true;
                tbCarColor.Visible = true;
                lbHomeDetails.Visible = false;
                lbHomAdd.Visible = false;
                tbHomeAdd.Visible = false;
                lbHomeSqFt.Visible = false;
                tbHomeSqFt.Visible = false;
                lbHomeYrBlt.Visible = false;
                tbHomeYrBlt.Visible = false;
            }
            else if(cbType.SelectedIndex == 1)
            {
                lbIntRate.Text = "0.055";
                lbNumYears.Text = "15";
                lbCarDetails.Visible = false;
                lbCarMake.Visible = false;
                tbCarMake.Visible = false;
                lbCarModel.Visible = false;
                tbCarModel.Visible = false;
                lbCarYear.Visible = false;
                tbCarYear.Visible = false;
                lbCarColor.Visible = false;
                tbCarColor.Visible = false;
                lbHomeDetails.Visible = true;
                lbHomAdd.Visible = true;
                tbHomeAdd.Visible = true;
                lbHomeSqFt.Visible = true;
                tbHomeSqFt.Visible = true;
                lbHomeYrBlt.Visible = true;
                tbHomeYrBlt.Visible = true;
            }
        }

        private void btProcess_Click(object sender, EventArgs e)
        {
            if(cbType.SelectedIndex == 0)
            {
                AutoLoan aAutoLoan = new AutoLoan(tbFirstName.Text, tbLastName.Text, double.Parse(lbIntRate.Text), double.Parse(tbLoanAmount.Text), double.Parse(lbNumYears.Text), int.Parse(tbCarYear.Text), tbCarModel.Text, tbCarMake.Text);
                MessageBox.Show(aAutoLoan.ToString(), "AutoLoan Information\n");
            }
            else if(cbType.SelectedIndex == 1)
            {
                HomeLoan aHomeLoan = new HomeLoan(tbFirstName.Text, tbLastName.Text, double.Parse(lbIntRate.Text), double.Parse(tbLoanAmount.Text), double.Parse(lbNumYears.Text), int.Parse(tbHomeYrBlt.Text), int.Parse(tbHomeSqFt.Text), tbHomeAdd.Text);
                MessageBox.Show(aHomeLoan.ToString(), "HomeLoan Information\n");
            }
        }
    }
}
