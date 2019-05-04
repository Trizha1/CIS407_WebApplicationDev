using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // variable for the dsUser
            dsUser dsUserLogin;

            // string variable 
            string SecurityLevel;

            // set dsUserLogin to the database
            dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
            Login1.UserName, Login1.Password);

            // create If statement for authentication
            if (dsUserLogin.tblUserLogin.Count < 1)
            {
                e.Authenticated = false;
               
                // send error message to the corresponding email and display error message 
                if (clsBusinessLayer.SendEmail("trizha_1@yahoo.com",
                "stvdaviscom@yahoo.com", "", "", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName +
                " Password: " + Login1.Password))
                {
                    Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to trizha_1@yahoo.com";
                }
                return;
            }
            // create security level
            SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

            // create switch for security level
            switch (SecurityLevel)
            {
                case "A":
                    // authenticate security level for Administrator
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "A";
                    break;
                case "U":
                    // authenticate security level for user
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "U";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }
        }
    }
}