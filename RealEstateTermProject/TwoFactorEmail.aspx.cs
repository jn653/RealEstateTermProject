using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealEstateTermProject
{
    public partial class TwoFactorEmail : System.Web.UI.Page
    {
        string randsixdigit;
        protected void Page_Load(object sender, EventArgs e)
        {

            //string UserEmail = (string)Session["Email"];

            //Random r = new Random();
            //int randNum = r.Next(1000000);
            //randsixdigit = randNum.ToString("D6");

            //Email objEmail = new Email();
            //String strTO = UserEmail;
            //String strFROM = "tuj09076@temple.edu";
            //String strSubject = "Two Factor Authorization";
            //String strMessage = randsixdigit;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserAccountType = (string)Session["accountType"]; 

            if (txtSixDigit.Text.Equals(randsixdigit) && UserAccountType.Equals("Home Buyer"))
            {
                Response.Redirect("LandingPage.aspx");
            }
            else 
            
                if (txtSixDigit.Text.Equals(randsixdigit) && UserAccountType.Equals("Home Seller"))
            {
                Response.Redirect("LandingPageforHomeSeller.aspx");
            } 
            else 
                if (txtSixDigit.Text.Equals(randsixdigit) && UserAccountType.Equals("Real Estate Agent"))
            {
                Response.Redirect("LandingPageforRealEstateAgent.aspx");
            }

            else
                if (!txtSixDigit.Text.Equals(randsixdigit))
            {
                lblinstructions1.Text = "The six digit you entered was incorrect.";
                lblinstructions2.Text = "Go back to login page and try again";
                lblinstructions1.ForeColor = System.Drawing.Color.Red;
                lblinstructions2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}