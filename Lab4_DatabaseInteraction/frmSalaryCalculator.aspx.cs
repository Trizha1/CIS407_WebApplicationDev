using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmSalaryCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            //declare variables
            double hours = 0.0;
            double rate = 0.0;
            double salary = 0.0;

            //extract values from the textboxes
            hours = Double.Parse(txtAnnualHours.Text);
            rate = Double.Parse(txtPayRate.Text.Trim());

            //calculations
            salary = hours * rate;

            //display result
            lblAnnualSalary.Text = "Annual Salary is $" + salary.ToString("N");
        }
    }
}