using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmPersonnelVerified : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the data from the previous form, fromPersonnel.aspx
            txtVerifiedInfo.Text = Request["txtFirstName"] +
                "\n" + Request["txtLastName"] +
                "\n" + Request["txtPayRate"] +
                "\n" + Request["txtStartDate"] +
                "\n" + Request["txtEndDate"];
        }
    }
}