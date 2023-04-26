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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                loadGridview();
            }
        }

        protected void loadGridview()
        {

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_HouseOffers";


            gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);
            gvHomeOffers.DataBind();
        }




        protected void linkbtnAccept_Click1(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();




                // String strSQL = "DELETE FROM TP_Houses Where ID = " + houseId;
                // gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);

                loadGridview();


            }
        }



        protected void linkbtnDeny_Click2(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                


               // String strSQL = "DELETE FROM TP_Houses Where ID = " + houseId;
               // gvHomeOffers.DataSource = objDB.GetDataSet(strSQL);

                loadGridview();


            }
        }


    }
}