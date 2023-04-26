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
            String strSQL = "SELECT * FROM TP_Houses Where SellerID = " + UserID;


            
            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            gvMyHomes.DataBind();

        }



        protected void gvMyHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvMyHomes.Rows[rowIndex];
                gvMyHomes.DeleteRow(rowIndex);

                gvMyHomes.DataBind();
            }
        }


        

        protected void gvMyHomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLinkDelete_Click1(object sender, EventArgs e)
        {
            int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            DBConnect objDB = new DBConnect();
            String strSQL = "DELETE FROM TP_Houses Where ID = " + 12;



            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            

        }
    }
}