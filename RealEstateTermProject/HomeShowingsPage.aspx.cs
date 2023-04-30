using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class HomeShowingsPage : System.Web.UI.Page
    {
        SoapUserFunc SoapUser = new SoapUserFunc();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {
                //retrieving the username for the stored username in login and sign up page to use in other pages
                string UserAccountName = (string)Session["Username"];
                int UserID = SoapUser.GetIDByUsername(UserAccountName);

                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM TP_ScheduledHouseVisits  Where SellerID = " + UserID + " OR RealEstateId =" + UserID; 


                HouseVisitsRepeater.DataSource = objDB.GetDataSet(strSQL);
                HouseVisitsRepeater.DataBind();
            }
        }
    }
}