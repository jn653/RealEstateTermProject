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

            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveQuestionsFromEmail";


            objCommand50.Parameters.AddWithValue("@Email", txtEmailForgotPassword.Text);


            SqlParameter outputParameter30 = new SqlParameter("@FirstAnswer", SqlDbType.VarChar, 600);
            SqlParameter outputParameter31 = new SqlParameter("@SecondAnswer", SqlDbType.VarChar, 600);
            SqlParameter outputParameter32 = new SqlParameter("@ThirdAnswer", SqlDbType.VarChar, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            outputParameter31.Direction = ParameterDirection.Output;
            outputParameter32.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);
            objCommand50.Parameters.Add(outputParameter31);
            objCommand50.Parameters.Add(outputParameter32);
            SqlParameter outputParameter33 = new SqlParameter("@FirstQuestion", SqlDbType.VarChar, 600);
            SqlParameter outputParameter34 = new SqlParameter("@SecondQuestion", SqlDbType.VarChar, 600);
            SqlParameter outputParameter35 = new SqlParameter("@ThirdQuestion", SqlDbType.VarChar, 600);
            SqlParameter outputParameter36 = new SqlParameter("@theEmail", SqlDbType.VarChar, 600);
            outputParameter33.Direction = ParameterDirection.Output;
            outputParameter34.Direction = ParameterDirection.Output;
            outputParameter35.Direction = ParameterDirection.Output;
            outputParameter36.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter33);
            objCommand50.Parameters.Add(outputParameter34);
            objCommand50.Parameters.Add(outputParameter35);
            objCommand50.Parameters.Add(outputParameter36);


            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            string SecurityQuestionOneAnswer = objCommand50.Parameters["@FirstAnswer"].Value.ToString();
            string SecurityQuestionTwoAnswer = objCommand50.Parameters["@SecondAnswer"].Value.ToString();
            string SecurityQuestionThreeAnswer = objCommand50.Parameters["@ThirdAnswer"].Value.ToString();
            string SecurityQuestionOne = objCommand50.Parameters["@FirstQuestion"].Value.ToString();
            string SecurityQuestionTwo = objCommand50.Parameters["@SecondQuestion"].Value.ToString();
            string SecurityQuestionThree = objCommand50.Parameters["@ThirdQuestion"].Value.ToString();
            string Email = objCommand50.Parameters["@theEmail"].Value.ToString();


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
                    lblquestion.Text = SecurityQuestionOne;
                    break;
                case 2:
                    lblquestion.Text = SecurityQuestionTwo;
                    break;
                case 3:
                    lblquestion.Text = SecurityQuestionThree;
                    break;

            }

            Session["Email"] = Email;
            Session["questionOne"] = SecurityQuestionOne;
            Session["questionTwo"] = SecurityQuestionTwo;
            Session["questionThree"] = SecurityQuestionThree;

        }
 //--------------------------------------------------------------------------------------------------------

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            string UserEmail = (string)Session["Email"];
            string qOne = (string)Session["questionOne"];
            string qTwo = (string)Session["questionTwo"];
            string qThree = (string)Session["questionThree"];
            lblUsernameandPassword.Visible = true;

            //// checking the security question answers from database
            SqlCommand objCommand20 = new SqlCommand();
            objCommand20.CommandType = CommandType.StoredProcedure;
            objCommand20.CommandText = "TP_validateSecurityQuestionAnswer";


            objCommand20.Parameters.AddWithValue("@Email", UserEmail);

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


//--------------------------------------------------------------------------------------------------------------------------

            //code to check if the answer submitted is the same as answer in database to retrieve username and password 
  
            if (lblquestion.Text.Equals(qOne) && (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionOneAnswer.ToString())))
            {
                //add store procedure that returns the username and password where security question one answer is equal to the txt answer
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_RetrieveUsernamePasswordQuestionOne";


                objCommand.Parameters.AddWithValue("@FirstAnswer", SecurityQuestionOneAnswer.ToString());
                objCommand.Parameters.AddWithValue("@Email", UserEmail);

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

                lblUsernameandPassword.Text = "Your Username is:" + " " + usernameRetrieved + "<br>" + "Your Password is:" + " " + passwordRetrieved;

            }
            else if ((lblquestion.Text.Equals(qTwo) && (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionTwoAnswer.ToString()))))
            {
                //add store procedure that returns the username and password where security question two answer is equal to the txt answer
                SqlCommand objCommand1 = new SqlCommand();
                objCommand1.CommandType = CommandType.StoredProcedure;
                objCommand1.CommandText = "TP_RetrieveUsernamePasswordQuestionTwo";


                objCommand1.Parameters.AddWithValue("@SecondAnswer", SecurityQuestionTwoAnswer.ToString());
                objCommand1.Parameters.AddWithValue("@Email", UserEmail);

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

                lblUsernameandPassword.Text = "Your Username is:" + " " + usernameRetrieved + "<br>" + "Your Password is:" + " " + passwordRetrieved;
            } else if (lblquestion.Text.Equals(qThree) && (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionThreeAnswer.ToString())))
            {
                //add store procedure that returns the username and password where security question three answer is equal to the txt answer
                SqlCommand objCommand3 = new SqlCommand();
                objCommand3.CommandType = CommandType.StoredProcedure;
                objCommand3.CommandText = "TP_RetrieveUsernamePasswordQuestionThree";


                objCommand3.Parameters.AddWithValue("@ThirdAnswer", SecurityQuestionThreeAnswer.ToString());
                objCommand3.Parameters.AddWithValue("@Email", UserEmail);

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

                lblUsernameandPassword.Text = "Your Username is:" + " " + usernameRetrieved + "<br>" + "Your Password is:" + " " + passwordRetrieved;

            } 
//-------------------------------------------------------------------------------------------------------
            //Statements to display error if answer is wrong
            else
            if ((!lblquestion.Text.Equals(qTwo) && (!txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionTwoAnswer.ToString()))))

            {
                lblInstructions.Text = "The answer you have provided is incorrect. Return to login page and try again";
                lblInstructions.ForeColor = System.Drawing.Color.Red;
                lblUsernameandPassword.Visible = false;
            } else if (!lblquestion.Text.Equals(qOne) && (!txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionOneAnswer.ToString())))
            {
                lblInstructions.Text = "The answer you have provided is incorrect. Return to login page and try again";
                lblInstructions.ForeColor = System.Drawing.Color.Red;
                lblUsernameandPassword.Visible = false;
            } else if (!lblquestion.Text.Equals(qThree) && (!txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionThreeAnswer.ToString())))
            {
                lblInstructions.Text = "The answer you have provided is incorrect. Return to login page and try again";
                lblInstructions.ForeColor = System.Drawing.Color.Red;
                lblUsernameandPassword.Visible = false;
            }       
                
        }
        

    }
}


