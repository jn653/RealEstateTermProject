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
            if (!IsPostBack)
            {
                loadGridview();
            }
           

        }



        protected void gvMyHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        //    if (e.CommandName == "Select")
        //    {
        //        int rowIndex = Convert.ToInt32(e.CommandArgument);
        //        GridViewRow row = gvMyHomes.Rows[rowIndex];
        //        gvMyHomes.DeleteRow(rowIndex);

        //        gvMyHomes.DataBind();
        //    }
        }

        protected void loadGridview()
        {

            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);


            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_Houses Where SellerID = " + UserID + " OR RealEstateId =" + UserID;



            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            gvMyHomes.DataBind();
        }


        

        protected void gvMyHomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLinkDelete_Click1(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


                String strSQL = "DELETE FROM TP_Houses Where ID = " + houseId;
                gvMyHomes.DataSource = objDB.GetDataSet(strSQL);

                loadGridview();
                

            }







        }

        protected void linkbtnView_Click2(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


                String strSQL = "SELECT * FROM TP_HouseSurvey WHERE HouseiD = " + houseId;
                gvHouseFeedback.DataSource = objDB.GetDataSet(strSQL);
                gvHouseFeedback.DataBind();

            }






        }
    }
}