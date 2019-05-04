using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_AnnualSalaryCalculator
{
    public partial class frmPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            //DECLARATIONS
            int count = 0;
            Boolean validatedState = true;
            Boolean validateEntry = false;
            DateTime endDate = new DateTime(2016, 03, 01);
            DateTime startDate = new DateTime(2016, 03, 01);

            //BEGIN SERIES OF IF/ELSE FOR CONFIRMING ENTRIES         
            if (Request["txtFirstName"].ToString().Trim() == "")
            {
                //displays yellow bg for missing input
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please Enter a First Name <br/>"; 
            }//endif
            else
            {
                txtFirstName.BackColor = System.Drawing.Color.White;
                count += 1;
            }//end else

            if (Request["txtLastName"].ToString().Trim() == "")
            {
                //displays yellow bg for missing input
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please Enter a Last Name <br/>";
            }//endif
            else
            {
                txtLastName.BackColor = System.Drawing.Color.White;
                count += 1;
            }//end else

            if (Request["txtPayRate"].ToString().Trim() == "")
            {
                //displays yellow bg for missing input
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "Please Enter a Pay Rate <br/>";
            }//endif
            else
            {
                txtPayRate.BackColor = System.Drawing.Color.White;
                count += 1;
            }//end else

            if (Request["txtStartDate"].ToString().Trim() == "")
            {
                //displays yellow bg for missing input
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                validateEntry = false;
                lblError.Text += "Please Enter a Start Date <br/>";
            }//endif
            else
            {
                startDate = DateTime.Parse(Request["txtStartDate"]);
                validateEntry = true;
            }//end else

            if (Request["txtEndDate"].ToString().Trim() == "")
            {
                //displays yellow bg for missing input
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                validateEntry = false;
                lblError.Text += "Please Enter an End Date <br/>";
            }//endif
            else
            {
                endDate = DateTime.Parse(Request["txtEndDate"]);
                validateEntry = true;
            }//end else
             //END SERIES OF IF/ELSE FOR CONFIRMING ENTRIES 

            //START IF VALIDATE ENTRY    
            if (validateEntry == true)
            {
                if (DateTime.Compare(startDate, endDate) >= 0)
                {
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "The end date must be a later date than the start date.";
                    //The Msg text will be displayed in lblError.Text after all the error messages are concatenated
                    validatedState = false;
                    //Boolean value - test each textbox to see if the data entered is valid, if not set validState=false. 
                    //If after testing each validation rule, the validatedState value is true, then submit to frmPersonnelVerified.aspx, if not, then display error message
                    Response.Write("<span style= 'BackColor:red'>Msg/<span>");
                }
                else //goes to this is dates are correct
                {
                    validatedState = true;
                    count += 2;
                    txtStartDate.BackColor = System.Drawing.Color.White;
                    txtEndDate.BackColor = System.Drawing.Color.White;
                }
            }
            //END IF VALIDATE ENTRY

            //CONFIRMS ALL ARE CORRECT
            if (count == 5 && validatedState == true)
            {
                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtPayRate"] = txtPayRate.Text;
                Session["txtStartDate"] = txtStartDate.Text;
                Session["txtEndDate"] = txtEndDate.Text;
                Response.Redirect("frmPersonnelVerified.aspx");
                //sends to other page
            }
            else
            {
                Response.Write(lblError);
            }
            //ENDS CONFIRMATION OF CORRECT DATA




        }
    }
}