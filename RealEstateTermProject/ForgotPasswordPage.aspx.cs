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
    public partial class ForgotPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the security question, the textbox for security question answer and the label for the username and password retrieved 
            //will not be visible on page load
            lblquestion.Visible = false;
            txtSecuityQuestionAnswer.Visible = false;
            lblUsernameandPassword.Visible = false;
            submitbtn.Visible = false;
        }
//-------------------------------------------------------------------------------------------------
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            lblquestion.Visible = true;
            txtSecuityQuestionAnswer.Visible = true;
            lblUsernameandPassword.Visible = false;
            lblInstructions.Text = "Answer the security question to retreive your username and password";
            lblEmail.Visible = false;
            txtEmailForgotPassword.Visible = false;
            btnContinue.Visible = false;
            submitbtn.Visible = true;

            Random rnd = new Random();
            int num = rnd.Next(1, 4);

            switch (num)
            {
                case 1:
                    lblquestion.Text = "What city were you born in?";
                    break;
                case 2:
                    lblquestion.Text = "What is your mom's middle name?";
                    break;
                case 3:
                    lblquestion.Text = "What is the name of your best friend?";
                    break;
                
            }

           

        }

//--------------------------------------------------------------------------------------------------------

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            lblUsernameandPassword.Visible = true;
            // checking the security question answers from database
            SqlCommand objCommand20 = new SqlCommand();
            objCommand20.CommandType = CommandType.StoredProcedure;
            objCommand20.CommandText = "TP_validateSecurityQuestionAnswer";




            SqlParameter outputParameter30 = new SqlParameter("@FirstAnswer", SqlDbType.VarChar, 600);
            SqlParameter outputParameter31 = new SqlParameter("@SecondAnswer", SqlDbType.VarChar, 600);
            SqlParameter outputParameter32 = new SqlParameter("@ThirdAnswer", SqlDbType.VarChar, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            outputParameter31.Direction = ParameterDirection.Output;
            outputParameter32.Direction = ParameterDirection.Output;
            objCommand20.Parameters.Add(outputParameter30);
            objCommand20.Parameters.Add(outputParameter31);
            objCommand20.Parameters.Add(outputParameter32);


            DBConnect objDB45 = new DBConnect();
            objDB45.GetDataSet(objCommand20);

            string SecurityQuestionOneAnswer = objCommand20.Parameters["@FirstAnswer"].Value.ToString();
            string SecurityQuestionTwoAnswer = objCommand20.Parameters["@SecondAnswer"].Value.ToString();
            string SecurityQuestionThreeAnswer = objCommand20.Parameters["@ThirdAnswer"].Value.ToString();




            //code to check if the answer submitted is the same as answer in database
            if(lblquestion.Text == "What city were you born in?")
            {
                if (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionOneAnswer.ToString()))
                {
                    //add store procedure that returns the username and password where security question one answer is equal to the txt answer
                    SqlCommand objCommand = new SqlCommand();
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "TP_RetrieveUsernamePasswordQuestionOne";


                    objCommand.Parameters.AddWithValue("@FirstAnswer", SecurityQuestionOneAnswer.ToString());

                    SqlParameter outputParameter = new SqlParameter("@Username", SqlDbType.VarChar, 600);
                    SqlParameter outputParameter1 = new SqlParameter("@Password", SqlDbType.VarChar, 600);
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter1.Direction = ParameterDirection.Output;
                    objCommand.Parameters.Add(outputParameter);
                    objCommand.Parameters.Add(outputParameter1);


                    DBConnect objDB = new DBConnect();
                    objDB.GetDataSet(objCommand);


                    String usernameRetrieved = objCommand.Parameters["@Username"].Value.ToString();
                    String passwordRetrieved = objCommand.Parameters["@Password"].Value.ToString();
                    lblUsernameandPassword.Text = "Your Username is" + " " + usernameRetrieved + " " + "your password is" + " " + passwordRetrieved;

                }
                else if (lblquestion.Text == "What is your mom's middle name?")
                {
                    if (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionTwoAnswer.ToString()))
                    {
                        //add store procedure that returns the username and password where security question two answer is equal to the txt answer
                        SqlCommand objCommand1 = new SqlCommand();
                        objCommand1.CommandType = CommandType.StoredProcedure;
                        objCommand1.CommandText = "TP_RetrieveUsernamePasswordQuestionOne";


                        objCommand1.Parameters.AddWithValue("@SecondAnswer", SecurityQuestionTwoAnswer.ToString());

                        SqlParameter outputParameter3 = new SqlParameter("@Username", SqlDbType.VarChar, 600);
                        SqlParameter outputParameter4 = new SqlParameter("@Password", SqlDbType.VarChar, 600);
                        outputParameter3.Direction = ParameterDirection.Output;
                        outputParameter4.Direction = ParameterDirection.Output;
                        objCommand1.Parameters.Add(outputParameter3);
                        objCommand1.Parameters.Add(outputParameter4);


                        DBConnect objDB2 = new DBConnect();
                        objDB2.GetDataSet(objCommand1);


                        String usernameRetrieved = objCommand1.Parameters["@Username"].Value.ToString();
                        String passwordRetrieved = objCommand1.Parameters["@Password"].Value.ToString();

                        lblUsernameandPassword.Text = "Your Username is" + " " + usernameRetrieved + " " + "your password is" + " " + passwordRetrieved;

                    }
                    else
                        if (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionThreeAnswer.ToString()))
                    {
                        //add store procedure that returns the username and password where security question three answer is equal to the txt answer
                        SqlCommand objCommand3 = new SqlCommand();
                        objCommand3.CommandType = CommandType.StoredProcedure;
                        objCommand3.CommandText = "TP_RetrieveUsernamePasswordQuestionOne";


                        objCommand3.Parameters.AddWithValue("@SecondAnswer", SecurityQuestionThreeAnswer.ToString());

                        SqlParameter outputParameter5 = new SqlParameter("@Username", SqlDbType.VarChar, 600);
                        SqlParameter outputParameter6 = new SqlParameter("@Password", SqlDbType.VarChar, 600);
                        outputParameter5.Direction = ParameterDirection.Output;
                        outputParameter6.Direction = ParameterDirection.Output;
                        objCommand3.Parameters.Add(outputParameter5);
                        objCommand3.Parameters.Add(outputParameter6);


                        DBConnect objDB3 = new DBConnect();
                        objDB3.GetDataSet(objCommand3);


                        String usernameRetrieved = objCommand3.Parameters["@Username"].Value.ToString();
                        String passwordRetrieved = objCommand3.Parameters["@Password"].Value.ToString();

                        lblUsernameandPassword.Text = "Your Username is" + " " + usernameRetrieved + " " + "your password is" + " " + passwordRetrieved;
                    }
                    else
                        lblInstructions.Text = "The answer you have provided is incorrect. Return to login page and try again";
                    lblInstructions.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}