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
         
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
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