using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class MyHomesPage : System.Web.UI.Page
    {
        
        SoapUserFunc SoapUser = new SoapUserFunc();
        HouseUtils UtilsHouse = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGridview();
                lblConfim.Visible = false;
                txtProperty.Visible = false;
                txtGarage.Visible = false;
                txtBedrooms.Visible = false;
                txtBathrooms.Visible = false;
                txtCity.Visible = false;
                txtAmentities.Visible = false;
                txtDescription.Visible = false;
                txtHouseYear.Visible = false;
                txtImages.Visible = false;
                txtPrice.Visible = false;
                txtAddress.Visible = false;
                txtState.Visible = false;
                txtUtilities.Visible = false;
                lblAddress.Visible = false;
                lblAmentities.Visible = false;
                lblbathrooms.Visible = false;
                lblbedrooms.Visible = false;
                lblCity.Visible = false;
                lblGarage.Visible = false;
                lblHouseDescription0.Visible = false;
                lblHouseYear0.Visible = false;
                lblImages.Visible = false;
                lblPrice.Visible = false;
                lblPropertyType.Visible = false;
                lblState.Visible = false;
                lblUtilities3.Visible = false;
                btnUpdate.Visible = false;
                lblHouseDescription.Visible = false;
                txtHomeSize.Visible = false;

            }
           

        }



        

        protected void loadGridview()
        {

            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);


            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_Houses Where SellerID = " + UserID + " OR RealEstateId =" + UserID;



            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            gvMyHomes.DataBind();

            lblConfim.Visible = false;


        }




        protected void gvMyHomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLinkDelete_Click1(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


                String strSQL = "DELETE FROM TP_Houses Where ID = " + houseId;
                gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
                

                loadGridview();

                lblConfim.Visible = true;
                lblConfim.Text = "House with the Id " + houseId + " was successfully Deleted";
                lblConfim.ForeColor = System.Drawing.Color.Green;


            }







        }

        protected void linkbtnView_Click2(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


                String strSQL = "SELECT * FROM TP_HouseSurvey WHERE HouseiD = " + houseId;
                gvHouseFeedback.DataSource = objDB.GetDataSet(strSQL);
                lblConfim.Visible = false;
                gvHouseFeedback.DataBind();

            }


        }


        protected void gvMyHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvMyHomes.Rows[rowIndex];
               int HouseId = Convert.ToInt32(row.Cells[0].Text);

                House brandNew = new House();
                brandNew = UtilsHouse.getHouse(HouseId);


                txtProperty.Visible = true;
                txtGarage.Visible = true;
                txtBedrooms.Visible = true;
                txtBathrooms.Visible = true;
                txtCity.Visible = true;
                txtAmentities.Visible = true;
                txtDescription.Visible = true;
                txtHouseYear.Visible = true;
                txtImages.Visible = true;
                txtPrice.Visible = true;
                txtAddress.Visible = true;
                txtState.Visible = true;
                txtUtilities.Visible = true;
                lblAddress.Visible = true;
                lblAmentities.Visible = true;
                lblbathrooms.Visible = true;
                lblbedrooms.Visible = true;
                lblCity.Visible = true;
                lblGarage.Visible = true;
                lblHouseDescription0.Visible = true;
                lblHouseYear0.Visible = true;
                lblImages.Visible = true;
                lblPrice.Visible = true;
                lblPropertyType.Visible = true;
                lblState.Visible = true;
                lblUtilities3.Visible = true;
                btnUpdate.Visible = true;
                lblHouseDescription.Visible = true;
                txtHomeSize.Visible = true;

                txtProperty.Text = brandNew.PropertyType;
                txtGarage.Text = brandNew.Garage.ToString();
                txtBedrooms.Text = brandNew.NumberOfBedrooms.ToString();
                txtBathrooms.Text = brandNew.NumberOfBathrooms.ToString();
                txtCity.Text = brandNew.City;
                txtAmentities.Text = brandNew.Amenities;
                txtDescription.Text = brandNew.HomeDescription;
                txtHouseYear.Text = brandNew.HouseYear.ToString();
                txtImages.Text = brandNew.HouseImages;
                txtPrice.Text = brandNew.AskingPrice.ToString();
                txtAddress.Text = brandNew.Address;
                txtState.Text = brandNew.State;
                txtUtilities.Text = brandNew.Utilities;
                txtHomeSize.Text = brandNew.HomeSize.ToString();
                lblConfim.Visible = false;

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvMyHomes.Rows.Count; i++)
            {
                int houseId = Convert.ToInt32(gvMyHomes.Rows[i].Cells[0].Text);


                SoapUser.UpdateHouse(txtAddress.Text, txtAmentities.Text, txtState.Text, Convert.ToDecimal(txtPrice.Text), txtCity.Text, txtGarage.Text, txtDescription.Text, Convert.ToInt32(txtHomeSize.Text),
                    txtImages.Text, Convert.ToInt32(txtHouseYear.Text), Convert.ToInt32(txtBathrooms.Text), Convert.ToInt32(txtBedrooms.Text), txtProperty.Text, txtUtilities.Text, houseId);

                lblConfim.Visible = true;
                lblConfim.Text = "House with the Id " + houseId + " was successfully updated";
                lblConfim.ForeColor = System.Drawing.Color.Green;
            }


        }
    }
}