using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;

namespace RealEstateTermProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)) || txtUsername.Text == "Username" && txtPassword.Text == "Password")
            {
                lblUsername.Text = "You must enter your username";
                lblUsername.ForeColor = System.Drawing.Color.Red;

                lblPassword.Text = "Your must ener your password";
                lblPassword.ForeColor = System.Drawing.Color.Red;
            }

        }

       
    }
}