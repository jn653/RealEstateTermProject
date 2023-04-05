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

                HtmlGenericControl address = new HtmlGenericControl("label");
                HtmlGenericControl addressInfo = new HtmlGenericControl("info");

                Image image = new Image();

                HtmlGenericControl price = new HtmlGenericControl("label");
                HtmlGenericControl priceInfo = new HtmlGenericControl("info");

                Button button = new Button();
                

                address.InnerHtml = "Address: ";
                addressInfo.InnerHtml = ds.Tables[0].Rows[0]["Address"].ToString();

                image.ImageUrl = ds.Tables[0].Rows[0]["HouseImages"].ToString();

                price.InnerHtml = "Price: ";
                priceInfo.InnerHtml = "$" + ds.Tables[0].Rows[0]["AskingPrice"].ToString();

                button.CssClass = "button";
                button.SkinID = ds.Tables[0].Rows[0]["Id"].ToString();
                button.Text = "View Home";

                address.Controls.Add(addressInfo);
                listing.Controls.Add(address);
                listing.Controls.Add(image);
                price.Controls.Add(priceInfo);
                listing.Controls.Add(price);
                listing.Controls.Add(button);

                return listing;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}