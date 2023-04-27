using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Utilities;
using System.Web.DynamicData;
using System.Collections;

namespace RealEstateTermProject
{
    public partial class Listings : System.Web.UI.Page
    {
        DBConnect utils = new DBConnect();
        HouseUtils houseUtils = new HouseUtils();
        SqlCommand SQLcmd;
        House localHouse = new House();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Username"] = "testing123";
            createButtons();
        }

        private void createButtons()
        {
            HtmlGenericControl listingBox = houseUtils.createAllListings();

            foreach (Control control in listingBox.Controls)
            {
                Button button = new Button();
                button.CssClass = "button";
                button.SkinID = control.SkinID;
                button.Text = "View Home";
                button.Attributes["runat"] = "server";
                button.Click += new EventHandler(Button_Click);

                control.Controls.Add(button);
            }

            content.Controls.Add(listingBox);
        }

        public void showHomeInfo(String id)
        {
            int i = int.Parse(id);

            House house = houseUtils.getHouse(int.Parse(id));

            homeAddress.InnerHtml = house.Address;
            image.Src = house.HouseImages;

            homeDescription.InnerHtml = house.HomeDescription;

            beds.InnerHtml = house.NumberOfBedrooms.ToString();
            bathrooms.InnerHtml = house.NumberOfBathrooms.ToString();
            propertyType.InnerHtml = house.PropertyType;
            houseSize.InnerHtml = house.HomeSize.ToString();

            amenities.InnerHtml = house.Amenities;
            utilities.InnerHtml = house.Utilities;
            garages.InnerHtml = house.Garage;
            houseYear.InnerHtml = house.HouseYear.ToString();

            askingPrice.InnerHtml = house.AskingPrice.ToString();
            state.InnerHtml = house.State;
            city.InnerHtml = house.City;

            //scheduleVisit.SkinID = id;

            Session["House"] = house;
            homeInfo.Visible = true;
        }

        protected void MakeOffer_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            houseUtils.AddHomeOffer((House)Session["House"], Session["Username"].ToString(), int.Parse(offerBox.Value));
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            showHomeInfo(button.SkinID);
        }
    }
}