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
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace Utilities
{
    public class HouseUtils
    {
        String connString = "https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk60318/WebAPI/api/Houses"; //For when you run the api server side
        //String connString = "https://localhost:44398/api/Houses"; //For when you run the api client side
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

        public HtmlGenericControl createAllListings(List<House> houses)
        {
            try
            {
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
        /*
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
            
        }*/
        public String getSpecificHouseInfo(int id, String info)
        {
            House house = getHouse(id);

            var property = (typeof (House)).GetProperty(info).GetValue(house, null);

            return property.ToString();
        }

        public bool AddHomeOffer(House house, String username, decimal offer)
        {
            SqlCommand SQLcmd = new SqlCommand();
            DBConnect objDB = new DBConnect();

            try
            {
                int rowsAffected = 0;

                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_MakeOffer";

                SqlParameter inputHouseImages = new SqlParameter(@"houseImages", house.HouseImages);
                SqlParameter inputAddress = new SqlParameter("@houseAddress", house.Address);
                SqlParameter inputUserBuying = new SqlParameter("@userBuying", username);
                SqlParameter inputSellerId = new SqlParameter("@sellerId", house.SellerID);
                SqlParameter inputRealEstateId = new SqlParameter("@realEstateId", house.RealEstateID);
                SqlParameter inputOfferPrice = new SqlParameter("@offerPrice", offer);
                SqlParameter inputAskingPrice = new SqlParameter("@askingPrice", house.AskingPrice);

                inputHouseImages.SqlDbType = SqlDbType.VarChar;
                inputAddress.SqlDbType = SqlDbType.VarChar;
                inputUserBuying.SqlDbType = SqlDbType.VarChar;
                inputSellerId.SqlDbType = SqlDbType.Int;
                inputRealEstateId.SqlDbType = SqlDbType.Int;
                inputOfferPrice.SqlDbType = SqlDbType.Decimal;
                inputAskingPrice.SqlDbType = SqlDbType.Decimal;

                inputHouseImages.Size = 500;
                inputAddress.Size = 500;
                inputUserBuying.Size = 500;
                inputSellerId.Size = 500;
                inputRealEstateId.Size = 500;
                inputOfferPrice.Size = 500;
                inputAskingPrice.Size = 500;

                SQLcmd.Parameters.Add(inputHouseImages);
                SQLcmd.Parameters.Add(inputAddress);
                SQLcmd.Parameters.Add(inputUserBuying);
                SQLcmd.Parameters.Add(inputSellerId);
                SQLcmd.Parameters.Add(inputRealEstateId);
                SQLcmd.Parameters.Add(inputOfferPrice);
                SQLcmd.Parameters.Add(inputAskingPrice);

                rowsAffected = objDB.DoUpdate(SQLcmd);
                if (rowsAffected > 0)
                    return true;
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public bool ScheduleVisit(House house, String username, DateTime date, String time)
        {
            SqlCommand SQLcmd = new SqlCommand();
            DBConnect objDB = new DBConnect();

            try
            {
                int rowsAffected = 0;

                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_ScheduleHouseVisit";

                SqlParameter inputVisitDate = new SqlParameter(@"visitDate", date);
                SqlParameter inputVisitTime = new SqlParameter("@visitTime", time);
                SqlParameter inputVisitorUsername = new SqlParameter("@visitorUsername", username);
                SqlParameter inputSellerId = new SqlParameter("@sellerId", house.SellerID);
                SqlParameter inputRealEstateId = new SqlParameter("@realEstateId", house.RealEstateID);
                SqlParameter inputHouseAddress = new SqlParameter("@houseAddress", house.Address);

                inputVisitDate.SqlDbType = SqlDbType.Date;
                inputVisitTime.SqlDbType = SqlDbType.VarChar;
                inputVisitorUsername.SqlDbType = SqlDbType.VarChar;
                inputSellerId.SqlDbType = SqlDbType.Int;
                inputRealEstateId.SqlDbType = SqlDbType.Int;
                inputHouseAddress.SqlDbType = SqlDbType.VarChar;

                inputVisitDate.Size = 500;
                inputVisitTime.Size = 500;
                inputVisitorUsername.Size = 500;
                inputSellerId.Size = 500;
                inputRealEstateId.Size = 500;
                inputHouseAddress.Size = 500;

                SQLcmd.Parameters.Add(inputVisitDate);
                SQLcmd.Parameters.Add(inputVisitTime);
                SQLcmd.Parameters.Add(inputVisitorUsername);
                SQLcmd.Parameters.Add(inputSellerId);
                SQLcmd.Parameters.Add(inputRealEstateId);
                SQLcmd.Parameters.Add(inputHouseAddress);

                rowsAffected = objDB.DoUpdate(SQLcmd);
                if (rowsAffected > 0)
                    return true;
                return false;
            }
            catch (Exception ex) { return false; }
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

        public List<House> getHousesStatePricePropertyType(String state, float minPrice, float maxPrice, String propType)
        {
            WebRequest request = WebRequest.Create($"{connString}/State/{state}/MinPrice/{minPrice}/MaxPrice/{maxPrice}/PropertyType/{propType}");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<House> houses = javaScriptSerializer.Deserialize<List<House>>(data);

            return houses;
        }

        public List<House> getHousesCityPrice(String city, float minPrice, float maxPrice)
        {
            WebRequest request = WebRequest.Create($"{connString}/City/{city}/MinPrice/{minPrice}/MaxPrice/{maxPrice}");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<House> houses = javaScriptSerializer.Deserialize<List<House>>(data);

            return houses;
        }

        public List<House> getHousesStatePriceNumOfBed(String state, float minPrice, float maxPrice, int numOfBed)
        {
            WebRequest request = WebRequest.Create($"{connString}/State/{state}/MinPrice/{minPrice}/MaxPrice/{maxPrice}/NumOfBed/{numOfBed}");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<House> houses = javaScriptSerializer.Deserialize<List<House>>(data);

            return houses;
        }

        public List<House> getHousesPriceNumOfBath(float minPrice, float maxPrice, int numOfBath)
        {
            WebRequest request = WebRequest.Create($"{connString}/MinPrice/{minPrice}/MaxPrice/{maxPrice}/NumOfBath/{numOfBath}");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<House> houses = javaScriptSerializer.Deserialize<List<House>>(data);

            return houses;
        }

        public void putHouse(House house)
        {
            // Create an object of the Customer class which is avaialable through the web service reference and WSDL
            // Serialize a Customer object into a JSON string.
            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonHouse = js.Serialize(house);
            
                // Send the Customer object to the Web API that will be used to store a new customer record in the database.
                // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                WebRequest request = WebRequest.Create(connString);
                request.Method = "POST";
                request.ContentLength = jsonHouse.Length;
                request.ContentType = "application/json";

                // Write the JSON data to the Web Request
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonHouse);
                writer.Flush();
                writer.Close();

                // Read the data from the Web Response, which requires working with streams.
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();
            
        }
    }
}