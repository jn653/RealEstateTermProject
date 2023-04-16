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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM TP_ScheduledHouseVisits";


                HouseVisitsRepeater.DataSource = objDB.GetDataSet(strSQL);
                HouseVisitsRepeater.DataBind();
            }
        }
    }
}