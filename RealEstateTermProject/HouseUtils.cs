using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace Utilities
{
    public class HouseUtils
    {

        String connString = "https://localhost:44398/api/Houses"; //For when you run the api client side
        public HouseUtils() { }

        public HtmlGenericControl createSingleListing(int id)
        {
            
            try
            {
                House house = getHouse(id);

                HtmlGenericControl listing = new HtmlGenericControl("listing");

                listing.SkinID = house.HouseID.ToString();

                HtmlGenericControl address = new HtmlGenericControl("label");
                HtmlGenericControl addressInfo = new HtmlGenericControl("info");

                Image image = new Image();

                HtmlGenericControl price = new HtmlGenericControl("label");
                HtmlGenericControl priceInfo = new HtmlGenericControl("info");

                address.InnerHtml = "Address: ";
                addressInfo.InnerHtml = house.Address;

                image.ImageUrl = house.HouseImages;

                price.InnerHtml = "Price: ";
                priceInfo.InnerHtml = "$" + house.AskingPrice;

                address.Controls.Add(addressInfo);
                listing.Controls.Add(address);
                listing.Controls.Add(image);
                price.Controls.Add(priceInfo);
                listing.Controls.Add(price);

                return listing;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public HtmlGenericControl createAllListings()
        {
            List<House> houses = new List<House>();
            try
            {
                houses = getHouses();

                HtmlGenericControl listingBox = new HtmlGenericControl("listingBox");
                listingBox.ID = "listingBox";

                for(int i = 0; i < houses.Count; i++) 
                {
                    listingBox.Controls.Add(createSingleListing(int.Parse(houses[i].HouseID.ToString())));
                }

                return listingBox;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public HtmlGenericControl createHomeInfo(int id)
        {
            try
            {
                List<House> houses = getHouses();

                HtmlGenericControl homeInfoFull = new HtmlGenericControl("homeInfoFull");
                HtmlGenericControl mainImage = new HtmlGenericControl("mainImage");
                HtmlGenericControl homeAddress = new HtmlGenericControl("homeAddress");

                Image image = new Image();

                mainImage.Controls.Add(image);
                mainImage.Controls.Add(homeAddress);

                HtmlGenericControl homeInfoContent = new HtmlGenericControl("homeInfoContent");

                HtmlGenericControl propertyDetails = new HtmlGenericControl("propertyDetails");

                String[] contentTitles = {
                    "Beds",
                    "Property Type",
                    "Square Footage",
                    "Amenities",
                    "Garages",
                    "Year Built"

                };

                String[] dbTitles =
                {
                    "NumberOfBeds",
                    "PropertyType",
                    "HomeSize",
                    "Amenities",
                    "Garage",
                    "HouseYear"
                };

                foreach(String title in contentTitles)
                {

                }

                homeInfoFull.Controls.Add(mainImage);

                homeInfoFull.Controls.Add(new HtmlGenericControl("homeInfoContent"));

                return homeInfoFull;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        public String getSpecificHouseInfo(int id, String info)
        {
            House house = getHouse(id);

            var property = (typeof (House)).GetProperty(info).GetValue(house, null);

            return property.ToString();
        }

        public House getHouse(int id)
        {
            WebRequest request = WebRequest.Create($"{connString}/{id}");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader= new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            House house = javaScriptSerializer.Deserialize<House> (data);

            return house;
        }

        public List<House> getHouses()
        {
            WebRequest request = WebRequest.Create(connString);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<House> houses = javaScriptSerializer.Deserialize<List<House>>(data);

            return houses;
        }
    }
}