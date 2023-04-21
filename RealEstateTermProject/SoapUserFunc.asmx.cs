﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    /// <summary>
    /// Summary description for SoapUserFunc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapUserFunc : System.Web.Services.WebService
    {

        [WebMethod]
        //making sure the username isnt already in the database when signup happens
        public string ValidateSignUp(string usernameTextBox)
        {
            string errorMessage;
            SqlCommand objCommand20 = new SqlCommand();
            objCommand20.CommandType = CommandType.StoredProcedure;
            objCommand20.CommandText = "TP_validateCreateNewUser";

            objCommand20.Parameters.AddWithValue("@Username", usernameTextBox);

            SqlParameter outputParameter = new SqlParameter("@accountUsername", SqlDbType.VarChar, 600);
            outputParameter.Direction = ParameterDirection.Output;
            objCommand20.Parameters.Add(outputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand20);


            string profileUsername = objCommand20.Parameters["@accountUsername"].Value.ToString();
           

            return profileUsername;
        } 

        //adding a user account to the user account database table
        public void addUserAccount(string username, string password, string email, string accountType, string firstquestion, string secondquestion, string thirdquestion, string firstanswer, string secondanswer, string thirdanswer)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddUserAccount";


            objCommand.Parameters.AddWithValue("@theUsername", username);
            objCommand.Parameters.AddWithValue("@thePassword", password);
            objCommand.Parameters.AddWithValue("@accountType", accountType);
            objCommand.Parameters.AddWithValue("@theEmail", email);
            objCommand.Parameters.AddWithValue("@FirstSecurityQuestion", firstquestion);
            objCommand.Parameters.AddWithValue("@SecondSecurityQuestion", secondquestion);
            objCommand.Parameters.AddWithValue("@ThirdSecurityQuestion", thirdquestion);
            objCommand.Parameters.AddWithValue("@FirstAnswer", firstanswer);
            objCommand.Parameters.AddWithValue("@SecondAnswer", secondanswer);
            objCommand.Parameters.AddWithValue("@ThirdAnswer", thirdanswer);


            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);

           
        }
        //getting user id by entering the stored username
        public int GetIDByUsername(string username)
        {
            

            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUserID";


            objCommand50.Parameters.AddWithValue("@theUsername", username);


            SqlParameter outputParameter30 = new SqlParameter("@theID", SqlDbType.Int, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);




            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            int UserID = Convert.ToInt32(objCommand50.Parameters["@theID"].Value.ToString());

            return UserID;
        }
    }
}