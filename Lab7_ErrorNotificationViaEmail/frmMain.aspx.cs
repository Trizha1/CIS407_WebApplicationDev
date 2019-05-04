using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Creating data layer
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");
            if (Session["securityLevel"] != "A")
            {
                linkbtnEditEmployees.Visible = false;
                linkbtnViewUserActivity.Visible = false;
                linkbtnNewEmployee.Visible = false;
                imgbtnEditEmployees.Visible = false;
                imgbtnViewUserActivity.Visible = false;
                imgbtnViewPersonnel.Visible = false;
                imgbtnManageUsers.Visible = false;
                linkbtnManageUsers.Visible = false;
            }
          
        }
    }
}
