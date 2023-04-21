using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class SearchHouses : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];


            lblSearch.Visible = false;
            
            lblState.Visible = false;
            lblPropertyType.Visible = false;
            lblPrice.Visible = false;
            ddlPrice.Visible = false;
            ddlPropertyType.Visible = false;
            lblNumofBedrooms.Visible = false;
            ddlnumofBathrooms.Visible = false;
            ddlCity.Visible = false;
            lblCity.Visible = false;
            btnSearchHouse.Visible = false;
            hyperlinkBack.Visible = false;
            Image1.Visible = false;
            ddlStates.Visible = false;


            
        }

        protected void btnsubmitCriteria_Click(object sender, EventArgs e)
        {
            if(AjaxComboCriteria.SelectedValue.Equals("State/Price/PropertyType"))
            {
                lblSearch.Visible = true;

                lblState.Visible = true;
                lblPrice.Visible = true;
                lblPropertyType.Visible = true;
                ddlPrice.Visible = true;
                ddlPropertyType.Visible = true;
                AjaxComboCriteria.Visible = false;
                hyperlinkBack.Visible = true;
                Image1.Visible = true;


                lblSearchByCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                btnSearchHouse.Visible = true;
                ddlStates.Visible = true;


                // populate the dropdown list for states witht the states in the database
                DBConnect dbConnect = new DBConnect();
                DataSet myData2 = dbConnect.GetDataSet("Select  DISTINCT State FROM TP_Houses");

                ddlStates.DataSource = myData2;
                ddlStates.DataBind();
            }
            else if (AjaxComboCriteria.SelectedValue.Equals("State/Price/Number of bedrooms"))
            {
                lblSearch.Visible = true;

                lblState.Visible = true;
                lblPrice.Visible = true;
                lblNumofBedrooms.Visible = true;
                ddlnumofBathrooms.Visible = true;
                ddlPrice.Visible = true;
                AjaxComboCriteria.Visible = false;
                hyperlinkBack.Visible = true;
                Image1.Visible = true;


                lblSearchByCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                btnSearchHouse.Visible = true;
                ddlStates.Visible = true;


                // populate the dropdown list for states witht the states in the database
                DBConnect dbConnect = new DBConnect();
                DataSet myData2 = dbConnect.GetDataSet("Select  DISTINCT State FROM TP_Houses");

                ddlStates.DataSource = myData2;
                ddlStates.DataBind();

            }
            else if (AjaxComboCriteria.SelectedValue.Equals("City/Price"))
            {
                lblSearch.Visible = true;
                lblCity.Visible = true;
                lblPrice.Visible = true;
                ddlPrice.Visible = true;
                ddlCity.Visible = true;
                AjaxComboCriteria.Visible = false;
                hyperlinkBack.Visible = true;
                Image1.Visible = true;


                lblSearchByCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                ddlnumofBathrooms.Visible = false;
                lblNumofBedrooms.Visible = false;
                btnSearchHouse.Visible = true;


                // populate the dropdown list for states witht the states in the database
                DBConnect dbConnect = new DBConnect();
                DataSet myData2 = dbConnect.GetDataSet("Select  DISTINCT City FROM TP_Houses");

                ddlCity.DataSource = myData2;
                ddlCity.DataBind();
            }
            else
                if(AjaxComboCriteria.SelectedValue.Equals("Price/Number of bathrooms"))
            {
                lblPrice.Visible = true;
                ddlPrice.Visible = true;
                lblNumofBedrooms.Visible = true;
                lblNumofBedrooms.Text = "Number of bathrooms";
                ddlnumofBathrooms.Visible = true;
                lblSearch.Visible = true;
                btnSearchHouse.Visible = true;
                AjaxComboCriteria.Visible = false;
                hyperlinkBack.Visible = true;
                Image1.Visible = true;



                lblSearchByCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
            }
                
        }
    }
}