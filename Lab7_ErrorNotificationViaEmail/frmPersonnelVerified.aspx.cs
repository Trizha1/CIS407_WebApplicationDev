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

            txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
                "\n" + Session ["txtLastName"].ToString() +
                "\n" + Session ["txtPayRate"].ToString() +
                "\n" + Session ["txtStartDate"].ToString() +
                "\n" + Session ["txtEndDate"].ToString();

            // Save the data from the previous form
            if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
            Session["txtFirstName"].ToString(),
            Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(),
            Session["txtStartDate"].ToString(),
            Session["txtEndDate"].ToString()))
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was successfully saved!";
            }
            else
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was NOT saved.";
            }

        }

        protected void txtVerifiedInfo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnViewPersonnel_Click(object sender, EventArgs e)
        {

        }
    }
}