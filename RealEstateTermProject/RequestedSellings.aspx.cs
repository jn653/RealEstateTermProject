using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class RequestedSellings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this code works I just got to wait to uncomment it because if not, we wont be able to see the page unless we log in as a real estate agent

            ////retrieving the accounttype for the stored account type in login and sign up page to use in other pages
            //string AccountType = (string)Session["accountType"];

            //if (AccountType.Equals("Real Estate Agent"))
            //{
            //    lblTestingpage.Text = "You are a real estate agent";
            //}
            //else if (!AccountType.Equals("Real Estate Agent"))
            //{
            //    lblTestingpage.Text = "You are not a real estate agent, you do not have permission to this page";

            //}


            //putting all the data from requestedSelling table into the gridview
            String strSQL = "SELECT * FROM TP_RequestedSelling";

            DBConnect objDB = new DBConnect();


            gvRequestors.DataSource = objDB.GetDataSet(strSQL);
            gvRequestors.DataBind();

        }
    }
}