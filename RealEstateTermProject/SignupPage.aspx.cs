using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class SignupPage : System.Web.UI.Page
    {
        SoapUserFunc SoapUser = new SoapUserFunc();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            // checking to see if string username is already taken in the datbase 
            string error =  SoapUser.ValidateSignUp(txtCreateUsername.Text);

            if (string.IsNullOrEmpty(error))
            {
                lblUsername.Text = "Username is good";
                //---------------------------------------------------------------------------------------------------------------------------------

                // getting the account type

                string AccountType;
                if (radiobtnHomeSeller.Checked == true)
                {
                    AccountType = "Home Seller";

                }
                else if (radiobtnRealEstateAgent.Checked == true)
                {
                    AccountType = "Real Estate Agent";

                }
                else

                    AccountType = "Home Buyer";

                //adding user account to database
                SoapUser.addUserAccount(txtCreateUsername.Text, txtCreatePassword.Text, txtEmail.Text, AccountType.ToString(), lblseucrityquestion1question0.Text,
                lblseucrityquestion2question0.Text, lblseucrityquestion3question.Text, txtSecurityquestion1Answer.Text, txtSecurityquestion2Answer.Text, txtSecurityquestion3Answer.Text);

                //storing username to use across multiple pages
                Session["Username"] = txtCreateUsername.Text;

                // depedning on what the account type is  will determine what landing page loads
                if (AccountType.ToString() == "Home Seller")
                {
                    //storing username to use across multiple pages

                    Session["Username"] = txtCreateUsername.Text;
                    Response.Redirect("LandingPageforHomeSeller.aspx");
                }
                else if (AccountType.ToString() == "Real Estate Agent")
                {
                    //storing username to use across multiple pages

                    Session["Username"] = txtCreateUsername.Text;
                    Response.Redirect("AddRealEstateInfoPage.aspx");
                }
                else
                    //storing username to use across multiple pages

                    Session["Username"] = txtCreateUsername.Text;
                Response.Redirect("LandingPage.aspx");
            


        }
            else
                lblUsername.Text = "Username is taken, please choose a different one";
            lblUsername.ForeColor = System.Drawing.Color.Red;
          

        }
    }
}

    
