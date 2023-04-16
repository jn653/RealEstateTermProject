using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealEstateTermProject
{
    public partial class SellingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddingHouseInfotoSellPage.aspx");
        }
    }
}