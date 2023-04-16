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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            // checking to see if string username is already taken in the datbase 
            SqlCommand objCommand20 = new SqlCommand();
            objCommand20.CommandType = CommandType.StoredProcedure;
            objCommand20.CommandText = "TP_validateCreateNewUser";




            SqlParameter outputParameter30 = new SqlParameter("@accountUsername", SqlDbType.VarChar, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand20.Parameters.Add(outputParameter30);


            DBConnect objDB45 = new DBConnect();
            objDB45.GetDataSet(objCommand20);

            string starterUsername = objCommand20.Parameters["@accountUsername"].Value.ToString();

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

            //--------------------------------------------------------------------------------------------------------------------------

            // this code is to add the newly crearted user to the database table UserAccount.
            //it is commented out just so we dont have to create a new user everytime we test the sign up page

            if (!starterUsername.Equals(txtCreateUsername.Text))
            {

                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_AddUserAccount";


                objCommand.Parameters.AddWithValue("@theUsername", txtCreateUsername.Text);
                objCommand.Parameters.AddWithValue("@thePassword", txtCreatePassword.Text);
                objCommand.Parameters.AddWithValue("@accountType", AccountType.ToString());
                objCommand.Parameters.AddWithValue("@theEmail", txtEmail.Text);
                objCommand.Parameters.AddWithValue("@FirstSecurityQuestion", lblseucrityquestion1question0.Text);
                objCommand.Parameters.AddWithValue("@SecondSecurityQuestion", lblseucrityquestion2question0.Text);
                objCommand.Parameters.AddWithValue("@ThirdSecurityQuestion", lblseucrityquestion3question.Text);
                objCommand.Parameters.AddWithValue("@FirstAnswer", txtSecurityquestion1Answer.Text);
                objCommand.Parameters.AddWithValue("@SecondAnswer", txtSecurityquestion2Answer.Text);
                objCommand.Parameters.AddWithValue("@ThirdAnswer", txtSecurityquestion3Answer.Text);





                DBConnect objDB = new DBConnect();
                DataSet myDataSet;
                myDataSet = objDB.GetDataSet(objCommand);

                //storing username to use across multiple pages
                Session["Username"] = txtCreateUsername.Text;

            }
            else
                lblUsername.Text = "Username/Password already taken";


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
                Response.Redirect("LandingPageforRealEstateAgent.aspx");
            }
            else
                //storing username to use across multiple pages

                Session["Username"] = txtCreateUsername.Text;
            Response.Redirect("LandingPage.aspx");
        }
    }
}

    
