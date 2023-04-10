using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Utilities
{
    public class HouseUtils
    {
        DBConnect utils = new DBConnect();
        SqlCommand SQLcmd;
        public HouseUtils() { }

        public DataSet GetAllHouses()
        {
            SQLcmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_GetAllHouses";

                ds = utils.GetDataSet(SQLcmd);

                return ds;
            }
            catch 
            {
                return null;
            }

        }

        public HtmlGenericControl createSingleListing(int id)
        {
            SQLcmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_GetHouse";

                SqlParameter sqlInput = new SqlParameter("@id", id);

                sqlInput.SqlDbType = SqlDbType.Int;

                sqlInput.Size = 50;

                SQLcmd.Parameters.Add(sqlInput);

                ds = utils.GetDataSet(SQLcmd);

                HtmlGenericControl listing = new HtmlGenericControl("listing");

                listing.SkinID = ds.Tables[0].Rows[0]["Id"].ToString();

                HtmlGenericControl address = new HtmlGenericControl("label");
                HtmlGenericControl addressInfo = new HtmlGenericControl("info");

                Image image = new Image();

                HtmlGenericControl price = new HtmlGenericControl("label");
                HtmlGenericControl priceInfo = new HtmlGenericControl("info");

                address.InnerHtml = "Address: ";
                addressInfo.InnerHtml = ds.Tables[0].Rows[0]["Address"].ToString();

                image.ImageUrl = ds.Tables[0].Rows[0]["HouseImages"].ToString();

                price.InnerHtml = "Price: ";
                priceInfo.InnerHtml = "$" + ds.Tables[0].Rows[0]["AskingPrice"].ToString();

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
            DataSet ds = new DataSet();
            try
            {
                ds = GetAllHouses();
                
                DataTable dt = ds.Tables[0];

                HtmlGenericControl listingBox = new HtmlGenericControl("listingBox");
                listingBox.ID = "listingBox";

                for(int i = 0; i < dt.Rows.Count; i++) 
                {
                    listingBox.Controls.Add(createSingleListing(int.Parse(dt.Rows[i]["Id"].ToString())));
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
                DataRow dr = getAllHouseInfo(id);

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
            SQLcmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_GetHouse";

                SqlParameter sqlInput = new SqlParameter("@id", id);

                sqlInput.SqlDbType = SqlDbType.Int;

                sqlInput.Size = 50;

                SQLcmd.Parameters.Add(sqlInput);

                ds = utils.GetDataSet(SQLcmd);

                return ds.Tables[0].Rows[0][info].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataRow getAllHouseInfo(int id)
        {
            SQLcmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_GetHouse";

                SqlParameter sqlInput = new SqlParameter("@id", id);

                sqlInput.SqlDbType = SqlDbType.Int;

                sqlInput.Size = 50;

                SQLcmd.Parameters.Add(sqlInput);

                ds = utils.GetDataSet(SQLcmd);

                return ds.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}