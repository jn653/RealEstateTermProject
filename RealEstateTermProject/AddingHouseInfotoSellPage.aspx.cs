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
    public partial class AddingHouseInfotoSellPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPutHouseForSale_Click(object sender, EventArgs e)
        {

            string garage;
            if(checkboxNoGarage.Checked == true)
            {
                garage = checkboxNoGarage.Text;
            } 
            else
            
                garage = checkboxYesGarage.Text;


            string proptype;
            if (RadioButtonPropertyType.SelectedValue.Equals("Single-family home"))
            {
                proptype = "Single-family home";
            } else if (RadioButtonPropertyType.SelectedValue.Equals("Multi-family home"))
            {
                proptype = "Multi-family home";
            } else if (RadioButtonPropertyType.SelectedValue.Equals("Condo"))
            {
                proptype = "Condo";
            } else
                proptype = "TownHouse";




            //SqlCommand objCommand = new SqlCommand();
            //objCommand.CommandType = CommandType.StoredProcedure;
            //objCommand.CommandText = "TP_AddHouse";


            //objCommand.Parameters.AddWithValue("@theAddress	", txtAddress.Text);
            //objCommand.Parameters.AddWithValue("@theAmentities", txtAmentities.Text);
            ////objCommand.Parameters.AddWithValue("@theState", txt);
            //objCommand.Parameters.AddWithValue("@thePrice", txtPrice.Text);
            //objCommand.Parameters.AddWithValue("@theCity", txtCity.Text);
            //objCommand.Parameters.AddWithValue("@theGarage", garage);
            ////objCommand.Parameters.AddWithValue("@theHomeDescription", House );
            //objCommand.Parameters.AddWithValue("@theHomeSize", txtHomeSize.Text);
            //objCommand.Parameters.AddWithValue("@theHouseImages	", txtImage.Text);
            //objCommand.Parameters.AddWithValue("@theHouseYear", txtHouseYear.Text);
            //objCommand.Parameters.AddWithValue("@theNumOfBathroom", txtNumofBathrooms.Text);
            //objCommand.Parameters.AddWithValue("@theNumOfBedrooms", txtNumofBedrooms.Text);
            //objCommand.Parameters.AddWithValue("@thePropertyType", proptype);
            //objCommand.Parameters.AddWithValue("@theUtilities", txtUtilities.Text);





            //DBConnect objDB = new DBConnect();
            //DataSet myDataSet;
            //myDataSet = objDB.GetDataSet(objCommand);

        }
    }
}