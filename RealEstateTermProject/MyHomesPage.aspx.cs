using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class MyHomesPage : System.Web.UI.Page
    {
        SoapUserFunc SoapUser = new SoapUserFunc();
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
           int UserID = SoapUser.GetIDByUsername(UserAccountName);


            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_Houses Where ID = " + UserID;


            
            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            gvMyHomes.DataBind();

        }
    }
}