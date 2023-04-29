using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class HomeOffers : System.Web.UI.Page
    {
        SoapUserFunc SoapUser = new SoapUserFunc();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {
                lblConfirm.Visible = false;
                loadGridview();
            }
        }

        protected void loadGridview()
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_HouseOffers Where SellerID = " + UserID + " OR RealEstateId =" + UserID;


            gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);
            gvHomeOffers.DataBind();
            lblConfirm.Visible = false;
        }




        protected void linkbtnAccept_Click1(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();


                
                string UserOffering = gvHomeOffers.Rows[rowIndex].Cells[3].Text;
                int houseId = Convert.ToInt32(gvHomeOffers.Rows[rowIndex].Cells[0].Text);

                string houseStatus = "Sold to " + UserOffering;

                SoapUser.UpdateHouseStatus(houseStatus, houseId);

                String strSQL = "DELETE FROM TP_HouseOffers Where ID = " + houseId;
                gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);

                loadGridview();
                lblConfirm.Visible = true;
                lblConfirm.Text = "You have accepted the offer from " + UserOffering + " .";
                lblConfirm.ForeColor = System.Drawing.Color.Green;

            }
        }



        protected void linkbtnDeny_Click2(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvHomeOffers.Rows[rowIndex].Cells[0].Text);

                string UserOffering = gvHomeOffers.Rows[rowIndex].Cells[3].Text;


                String strSQL = "DELETE FROM TP_HouseOffers Where ID = " + houseId;
                gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);

                loadGridview();
                lblConfirm.Visible = true;
                lblConfirm.Text = "You have Denied the offer from " + UserOffering + " .";
                lblConfirm.ForeColor = System.Drawing.Color.Green;



            }
        }


    }
}