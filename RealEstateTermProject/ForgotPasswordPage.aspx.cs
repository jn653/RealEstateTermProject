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
            lblUsernameandPassword.Visible = true;
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

                }else if (lblquestion.Text == "What is your mom's middle name?")
                {
                    if (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionTwoAnswer.ToString()))
                    {
                        //add store procedure that returns the username and password where security question two answer is equal to the txt answer

                    }
                    else
                        if (txtSecuityQuestionAnswer.Text.Equals(SecurityQuestionThreeAnswer.ToString()))
                    {
                        //add store procedure that returns the username and password where security question three answer is equal to the txt answer

                    }
                    else
                        lblInstructions.Text = "The answer you have provided is incorrect. Return to login page and try again";
                }
            }
        }
    }
}