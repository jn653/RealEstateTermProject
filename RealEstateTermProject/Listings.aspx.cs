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
            createContent();
                
        }

        private void createContent()
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

            HtmlGenericControl homeAddress = new HtmlGenericControl("homeAddress");
            Image image = new Image();

            homeAddress.InnerHtml = houseUtils.getSpecificHouseInfo(i, "Address");
            image.ImageUrl = houseUtils.getSpecificHouseInfo(i, "HouseImages");

            temp.InnerHtml = "<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>jawn";

            mainImage.Controls.Add(image);
            mainImage.Controls.Add(homeAddress);

            homeInfo.Visible = true;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            showHomeInfo(button.SkinID);
        }
    }
}