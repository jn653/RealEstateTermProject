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

        protected void Page_Load(object sender, EventArgs e)
        {
            createButtons();
        }

        private void createButtons()
        {
            HtmlGenericControl listingBox = houseUtils.createAllListings();

            foreach(Control control in listingBox.Controls)
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

            beds.InnerHtml = house.NumberOfBedrooms.ToString();
            propertyType.InnerHtml = house.PropertyType;
            houseSize.InnerHtml = house.HomeSize.ToString();
            amenities.InnerHtml = house.Amenities;
            garages.InnerHtml = house.Garage;
            houseYear.InnerHtml = house.HouseYear.ToString();
            homeInfo.Visible = true;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            showHomeInfo(button.SkinID);
        }
    }
}