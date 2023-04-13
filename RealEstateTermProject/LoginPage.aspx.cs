using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            objCommand.CommandText = "validateLogin";


            objCommand.Parameters.AddWithValue("@theUsername", txtUsername.Text);
            objCommand.Parameters.AddWithValue("@thePassword", txtPassword.Text);

            SqlParameter outputParameter = new SqlParameter("@accountUsername", SqlDbType.VarChar, 600);
            SqlParameter outputParameter2 = new SqlParameter("@accountPassword", SqlDbType.VarChar, 600);
            SqlParameter outputParameter3 = new SqlParameter("@accountType", SqlDbType.VarChar, 600);
            outputParameter.Direction = ParameterDirection.Output;
            outputParameter2.Direction = ParameterDirection.Output;
            outputParameter3.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParameter);
            objCommand.Parameters.Add(outputParameter2);
            objCommand.Parameters.Add(outputParameter3);



            DBConnect objDB = new DBConnect();
            objDB.GetDataSet(objCommand);


            string profileUsername;
            string profilePassword;
            string accountType;

            profileUsername = objCommand.Parameters["@accountUsername"].Value.ToString();
            profilePassword = objCommand.Parameters["@accountPassword"].Value.ToString();
            accountType = objCommand.Parameters["@accountType"].Value.ToString();




            // this code works for validation 
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
                Response.Redirect("LandingPageforHomeSeller.aspx");
            }
            else 
            
            if (profileUsername.Equals(txtUsername.Text) && profilePassword.Equals(txtPassword.Text) && accountType.Equals("Home Buyer") && txtUsername.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
              
                Response.Redirect("LandingPage.aspx");
            }
            else 
            
            if (profileUsername.Equals(txtUsername.Text) && profilePassword.Equals(txtPassword.Text) && accountType.Equals("Real Estate Agent") && txtUsername.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
               
                Response.Redirect("LandingPageforRealEstateAgent.aspx");
            } 
            
            

           
              




        }


    }
}