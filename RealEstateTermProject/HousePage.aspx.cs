using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Web.UI.HtmlControls;

namespace RealEstateTermProject
{
    public partial class HousePage : System.Web.UI.Page
    {
        DBConnect utils = new DBConnect();
        SqlCommand SQLcmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            listingBox.Controls.Add(createListing(1));
        }

        public HtmlGenericControl createListing(int id)
        {
            SQLcmd = new SqlCommand();
            try
            {
                DataSet ds = new DataSet();

                SQLcmd.CommandType = CommandType.StoredProcedure;
                SQLcmd.CommandText = "TP_GetHouse";

                SqlParameter inputFirstName = new SqlParameter("@id", id);

                inputFirstName.SqlDbType = SqlDbType.Int;

                inputFirstName.Size = 50;

                SQLcmd.Parameters.Add(inputFirstName);

                ds = utils.GetDataSet(SQLcmd);

                HtmlGenericControl listing = new HtmlGenericControl("listing");

                Label address = new Label();
                HtmlGenericControl addressInfo = new HtmlGenericControl("info");

                Image image = new Image();

                Label price = new Label();
                HtmlGenericControl priceInfo = new HtmlGenericControl("info");


                address.Text = "Address: ";
                addressInfo.InnerHtml = ds.Tables[0].Rows[0]["Address"].ToString() + "<br>";

                image.ImageUrl = ds.Tables[0].Rows[0]["Image"].ToString() + "<br>";

                price.Text = "Price";
                priceInfo.InnerHtml = ds.Tables[0].Rows[0]["Price"].ToString();

                listing.Controls.Add(address);
                listing.Controls.Add(addressInfo);
                listing.Controls.Add(image);
                listing.Controls.Add(price);
                listing.Controls.Add(priceInfo);

                return listing;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}