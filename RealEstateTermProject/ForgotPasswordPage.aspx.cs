﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            //code to check if the answer submitted is the same as answer in database
            //string securityQuestionAnswer;
            //if(txtSecuityQuestionAnswer.Text.Equals())

        }
    }
}