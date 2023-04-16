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
    public partial class ScheduleAVisitPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddToScheduledHouseVisits";

            //the lines of code commented out needs the specific information from the list of houses thats displayed
           // objCommand.Parameters.AddWithValue("@theSellerID", txtCreateUsername.Text);
            //objCommand.Parameters.AddWithValue("@theRealEstateID", txtCreatePassword.Text);
            objCommand.Parameters.AddWithValue("@theDate", txtDate.ToString());
            objCommand.Parameters.AddWithValue("@theTime", txtTime.ToString());
            objCommand.Parameters.AddWithValue("@theUsernameVisiting",UserAccountName);
            





            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);
        }
    }
}