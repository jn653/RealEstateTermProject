using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            txtCity.Visible = false;
            lblCity.Visible = false;
            btnSearchHouse.Visible = false;
        }

        protected void btnsubmitCriteria_Click(object sender, EventArgs e)
        {
            if (ddlCriteria.SelectedValue.Equals("State/Price/PropertyType"))
            {
                lblSearch.Visible = true;

                lblState.Visible = true;
                lblPrice.Visible = true;
                lblPropertyType.Visible = true;
                ddlPrice.Visible = true;
                ddlPropertyType.Visible = true;


                lblSearchByCriteria.Visible = false;
                ddlCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                btnSearchHouse.Visible = true;
            }
            else if (ddlCriteria.SelectedValue.Equals("State/Price/Number of bedrooms"))
            {
                lblSearch.Visible = true;

                lblState.Visible = true;
                lblPrice.Visible = true;
                lblNumofBedrooms.Visible = true;
                ddlnumofBathrooms.Visible = true;
                ddlPrice.Visible = true;


                lblSearchByCriteria.Visible = false;
                ddlCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                btnSearchHouse.Visible = true;
            }
            else if (ddlCriteria.SelectedValue.Equals("City/Price"))
            {
                lblSearch.Visible = true;
                lblCity.Visible = true;
                lblPrice.Visible = true;
                ddlPrice.Visible = true;
                txtCity.Visible = true;


                lblSearchByCriteria.Visible = false;
                ddlCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
                ddlnumofBathrooms.Visible = false;
                lblNumofBedrooms.Visible = false;
                btnSearchHouse.Visible = true;
            }
            else
                if(ddlCriteria.SelectedValue.Equals("Price/Number of bathrooms"))
            {
                lblPrice.Visible = true;
                ddlPrice.Visible = true;
                lblNumofBedrooms.Visible = true;
                lblNumofBedrooms.Text = "Number of bathrooms";
                ddlnumofBathrooms.Visible = true;
                lblSearch.Visible = true;
                btnSearchHouse.Visible = true;



                lblSearchByCriteria.Visible = false;
                ddlCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
            }
                
        }
    }
}