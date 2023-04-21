using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class SellingPage : System.Web.UI.Page
    {
        HouseUtils houseUtils = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            for (int i = 1; i <= 20; i++)
                upImages.FindControl($"FileUpload{i}").Visible = true;
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            String dir = @"C:\fuck";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            image1.SaveAs($@"{dir}\fart.png");
        }

        protected void AddFileUpload(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                Control c = upImages.FindControl($"FileUpload{i}");
                if (!c.Visible)
                {
                    c.Visible = true;
                    break;
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            //retrieving the account type from the stored session
            string AccountType = (string)Session["accountType"];

            /*// stored procedure to get the user ID
            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUserID";


            objCommand50.Parameters.AddWithValue("@theUsername", UserAccountName);


            SqlParameter outputParameter30 = new SqlParameter("@theID", SqlDbType.Int, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);




            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            int UserID = Convert.ToInt32(objCommand50.Parameters["@theID"].Value.ToString());
            */



            House house = new House();
            house.Address = address.Value;
            house.PropertyType = propertyType.Value;
            house.HomeSize = int.Parse(homeSize.Value);
            house.NumberOfBedrooms = int.Parse(numOfBed.Value);
            house.Amenities = amenities.Value;
            house.HouseYear = int.Parse(houseYear.Value);
            house.Garage = garage.Value;
            house.Utilities = utilities.Value;
            house.HomeDescription = homeDescription.Value;
            house.AskingPrice = int.Parse(askingPrice.Value);
            house.HouseImages = houseImages.Value;
            house.State = state.Value;
            house.NumberOfBathrooms = int.Parse(numOfBath.Value);
            house.City = city.Value;
            house.SellerID = -1;
            house.RealEstateID = -1;

            /*
            if (AccountType == "Home Seller")
                house.SellerID = (int)Session["AccountID"];
            else
                house.RealEstateID = (int)Session["AccountID"];*/

            houseUtils.putHouse(house);
            //Response.Redirect("AddingHouseInfotoSellPage.aspx");
        }
    }
}