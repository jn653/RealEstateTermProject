﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;
using Utilities;

namespace RealEstateTermProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            btnTwoFactorAUthentification.Visible = false;
            txtEmailSixDigit.Visible = false;
            if (!IsPostBack && Request.Cookies["Username_Cookie"] != null && Request.Cookies["Password_Cookie"] != null)
            {

                HttpCookie RequestUsernamecookie = Request.Cookies["Username_Cookie"];
                txtUsername.Text = RequestUsernamecookie.Values["Username"].ToString();

                HttpCookie RequestPasswordcookie = Request.Cookies["Password_Cookie"];
                txtPassword.Text = RequestPasswordcookie.Values["Password"].ToString();



            }


        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            btnTwoFactorAUthentification.Visible = false;
            txtEmailSixDigit.Visible = false;

            if (checkboxCookie.Checked == true)
            {
                HttpCookie UsernameCookie = new HttpCookie("Username_Cookie");
                UsernameCookie.Values["Username"] = txtUsername.Text;
                UsernameCookie.Expires = new DateTime(2025, 1, 1);

                HttpCookie PasswordCookie = new HttpCookie("Password_Cookie");
                PasswordCookie.Values["Password"] = txtPassword.Text;
                PasswordCookie.Expires = new DateTime(2025, 1, 1);

                Response.Cookies.Add(UsernameCookie);
                Response.Cookies.Add(PasswordCookie);

               
            }

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_validateLogin";


            objCommand.Parameters.AddWithValue("@theUsername", txtUsername.Text);
            objCommand.Parameters.AddWithValue("@thePassword", txtPassword.Text);

            SqlParameter outputParameter = new SqlParameter("@accountUsername", SqlDbType.VarChar, 600);
            SqlParameter outputParameter2 = new SqlParameter("@accountPassword", SqlDbType.VarChar, 600);
            SqlParameter outputParameter3 = new SqlParameter("@accountType", SqlDbType.VarChar, 600);
            SqlParameter outputParameter4 = new SqlParameter("@email", SqlDbType.VarChar, 600);
            outputParameter.Direction = ParameterDirection.Output;
            outputParameter2.Direction = ParameterDirection.Output;
            outputParameter3.Direction = ParameterDirection.Output;
            outputParameter4.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParameter);
            objCommand.Parameters.Add(outputParameter2);
            objCommand.Parameters.Add(outputParameter3);
            objCommand.Parameters.Add(outputParameter4);



            DBConnect objDB = new DBConnect();
            objDB.GetDataSet(objCommand);


            string profileUsername;
            string profilePassword;
            string accountType;
            string email;

            profileUsername = objCommand.Parameters["@accountUsername"].Value.ToString();
            profilePassword = objCommand.Parameters["@accountPassword"].Value.ToString();
            accountType = objCommand.Parameters["@accountType"].Value.ToString();
            email = objCommand.Parameters["@email"].Value.ToString();

            Session["Email"] = email;
            //storing the account type to use across different pages 
            Session["accountType"] = accountType;

            //code for sending the two factor email - have to fix it to get it to work 

            




            //// this code works for validation 
            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)) || txtUsername.Text == "Username" && txtPassword.Text == "Password")

            {
                lblUsername.Text = "You must enter your username";
                lblUsername.ForeColor = System.Drawing.Color.Red;

                lblPassword.Text = "Your must ener your password";
                lblPassword.ForeColor = System.Drawing.Color.Red;
            }
            else


            if (!profileUsername.Equals(txtUsername.Text) && !profilePassword.Equals(txtPassword.Text))
            {
                lblUsername.Text = "Invalid Username/Password";
                lblUsername.ForeColor = System.Drawing.Color.Red;

                lblPassword.Text = "Invalid Username/Password";
                lblPassword.ForeColor = System.Drawing.Color.Red;
            }
            else

        if (profileUsername.Equals(txtUsername.Text) && profilePassword.Equals(txtPassword.Text) && accountType.Equals("Home Seller") && txtUsername.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
                string UserEmail = (string)Session["Email"];
                //storing username to use across multiple pages
                Session["Username"] = txtUsername.Text;
                //storing the account type to use across different pages 
                Session["accountType"] = accountType;



                Random r = new Random();
                int randNum = r.Next(1000000);
                string randsixdigit = randNum.ToString("D6");
                Session["sixdigit"] = randsixdigit;

                //Email objEmail = new Email();
                //String strTO = UserEmail;
                //String strFROM = "tuj09076@temple.edu";
                //String strSubject = "Two Factor Authorization";
                //String strMessage = randsixdigit;




                string to = UserEmail; //To address    
                string from = "juannavarro653@gmail.com"; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = randsixdigit;
                message.Subject = "Verification of Account";
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("TermProject12345@gmail.com", "kjbxxpfqopkwbqlf");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                // Response.Redirect("LandingPageforHomeSeller.aspx");
                Response.Redirect("TwoFactorEmail.aspx");
                
            }
            else

        if (profileUsername.Equals(txtUsername.Text) && profilePassword.Equals(txtPassword.Text) && accountType.Equals("Home Buyer") && txtUsername.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
                string UserEmail = (string)Session["Email"];
                //storing username to use across multiple pages
                Session["Username"] = txtUsername.Text;
                //storing the account type to use across different pages 
                Session["accountType"] = accountType;



                Random r = new Random();
                int randNum = r.Next(1000000);
                string randsixdigit = randNum.ToString("D6");
                Session["sixdigit"] = randsixdigit;

                //Email objEmail = new Email();
                //String strTO = UserEmail;
                //String strFROM = "tuj09076@temple.edu";
                //String strSubject = "Two Factor Authorization";
                //String strMessage = randsixdigit;




                string to = UserEmail; //To address    
                string from = "juannavarro653@gmail.com"; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = randsixdigit;
                message.Subject = "Verification of Account";
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("TermProject12345@gmail.com", "kjbxxpfqopkwbqlf");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }

                catch (Exception ex)
                {
                    throw ex;
                }


                // Response.Redirect("LandingPage.aspx");
                Response.Redirect("TwoFactorEmail.aspx");

                
            }
            else

        if (profileUsername.Equals(txtUsername.Text) && profilePassword.Equals(txtPassword.Text) && accountType.Equals("Real Estate Agent") && txtUsername.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
                string UserEmail = (string)Session["Email"];
                //storing username to use across multiple pages
                Session["Username"] = txtUsername.Text;
                //storing the account type to use across different pages 
                Session["accountType"] = accountType;


                Random r = new Random();
                int randNum = r.Next(1000000);
               string randsixdigit = randNum.ToString("D6");
                Session["sixdigit"] = randsixdigit;

                //Email objEmail = new Email();
                //String strTO = UserEmail;
                //String strFROM = "tuj09076@temple.edu";
                //String strSubject = "Two Factor Authorization";
                //String strMessage = randsixdigit;




                string to = UserEmail; //To address    
                string from = "juannavarro653@gmail.com"; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = randsixdigit;
                message.Subject = "Verification of Account";
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("TermProject12345@gmail.com", "kjbxxpfqopkwbqlf");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }

                catch (Exception ex)
                {
                    throw ex;
                }



                //Response.Redirect("LandingPageforRealEstateAgent.aspx");
                Response.Redirect("TwoFactorEmail.aspx");

                
            }









        }

        protected void btnTwoFactorAUthentification_Click(object sender, EventArgs e)
        {

        }
    }
}