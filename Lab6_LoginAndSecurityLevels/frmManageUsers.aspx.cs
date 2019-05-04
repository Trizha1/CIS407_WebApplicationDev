using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != "A")
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"),
            UserName.Text, Password.Text, SecurityLevel.SelectedValue))
            {
                lblDisplay.Text = "The user was successfully added!";
                grdUsers.DataBind();
            }
            else
            {
                lblDisplay.Text = "The user was not added";
            }
        }
    }
}