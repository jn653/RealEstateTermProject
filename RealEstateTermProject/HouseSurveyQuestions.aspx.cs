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
    public partial class HouseSurveyQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbltitle.Text = "Feedback For House With Address: ";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string price;
            if (radiobtnReasonablePrice.Text.Equals("Not very reasonable"))
            {
                price = "Not very reasonable";
            }
            else
                if (radiobtnReasonablePrice.Text.Equals("Somewhat reasonable"))
            {
                price = "Somwhat reasonable";
            }
            else
                price = "Very reasonable";

            


            //this code needs the house id of that they are making a survey for
            
            //SqlCommand objCommand = new SqlCommand();
            //objCommand.CommandType = CommandType.StoredProcedure;
            //objCommand.CommandText = "TP_AddHouseSurvey";


            //objCommand.Parameters.AddWithValue("@theResonablePrice", price);
            //// objCommand.Parameters.AddWithValue("@theHouseID	", txtPassword.Text);
            //objCommand.Parameters.AddWithValue("@theOtherComments", textAreaFeedback.InnerText);
            //objCommand.Parameters.AddWithValue("@theHouseRating	", ddlHouseRating.SelectedItem.Text);
            //objCommand.Parameters.AddWithValue("@theLocationRating", ddlLocationSafe.SelectedItem.Text);



            //DBConnect objDB = new DBConnect();
            //objDB.GetDataSet(objCommand);
        }
    }
}