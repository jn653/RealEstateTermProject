using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;

namespace RealEstateTermProject
{
    public partial class TwoFactorEmail : System.Web.UI.Page
    {

        string randsixdigit;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string UserEmail = (string)Session["Email"];
            string sixDigit = (string)Session["sixdigit"];

            //Random r = new Random();
            //int randNum = r.Next(1000000);
            //randsixdigit = randNum.ToString("D6");

            ////Email objEmail = new Email();
            ////String strTO = UserEmail;
            ////String strFROM = "tuj09076@temple.edu";
            ////String strSubject = "Two Factor Authorization";
            ////String strMessage = randsixdigit;




            //string to = UserEmail; //To address    
            //string from = "juannavarro653@gmail.com"; //From address    
            //MailMessage message = new MailMessage(from, to);

            //string mailbody = randsixdigit;
            //message.Subject = "Verification of Account";
            //message.Body = mailbody;
            //message.BodyEncoding = Encoding.UTF8;
            //message.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            //System.Net.NetworkCredential basicCredential1 = new
            //System.Net.NetworkCredential("TermProject12345@gmail.com", "kjbxxpfqopkwbqlf");
            //client.EnableSsl = true;
            //client.UseDefaultCredentials = false;
            //client.Credentials = basicCredential1;
            //try
            //{
            //    client.Send(message);
            //}

            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string sixDigit = (string)Session["sixdigit"];
            string UserAccountType = (string)Session["accountType"];
           

            if (txtSixDigit.Text.Equals(sixDigit) && UserAccountType.Equals("Home Buyer"))
            {
                Response.Redirect("LandingPage.aspx");
            }
            else 
            
                if (txtSixDigit.Text.Equals(sixDigit) && UserAccountType.Equals("Home Seller"))
            {
                Response.Redirect("LandingPageforHomeSeller.aspx");
            } 
            else 
                if (txtSixDigit.Text.Equals(sixDigit) && UserAccountType.Equals("Real Estate Agent"))
            {
                Response.Redirect("LandingPageforRealEstateAgent.aspx");
            }

            else
                if (!txtSixDigit.Text.Equals(sixDigit))
            {
                // lblinstructions1.Text = "The six digit you entered was incorrect.";
                lblinstructions1.Text =  UserAccountType; ;
                lblinstructions2.Text = "Go back to login page and try again";
                lblinstructions1.ForeColor = System.Drawing.Color.Red;
                lblinstructions2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}