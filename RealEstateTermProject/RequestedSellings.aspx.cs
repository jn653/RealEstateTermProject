using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class RequestedSellings : System.Web.UI.Page
    {
        SoapUserFunc SoapUser = new SoapUserFunc();
        HouseUtils house = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);
            //this code works I just got to wait to uncomment it because if not, we wont be able to see the page unless we log in as a real estate agent

            //retrieving the accounttype for the stored account type in login and sign up page to use in other pages
            string AccountType = (string)Session["accountType"];

            if (AccountType.Equals("Real Estate Agent"))
            {
                lblTestingpage.Text = "Instructions: If a user has selected to sell with you Press the SELECT button to populate the textbox with the information for a house and then press SELL HOUSE button to sell the house";
            }
            else if (!AccountType.Equals("Real Estate Agent"))
            {
                lblTestingpage.Text = "You are not a real estate agent, you do not have permission to this page";
                txtProperty.Visible = false;
                txtGarage.Visible = false;
                txtBedrooms.Visible = false;
                txtBathrooms.Visible = false;
                txtCity.Visible = false;
                txtAmentities.Visible = false;
                txtDescription.Visible = false;
                txtHouseYear.Visible = false;
                txtImages.Visible = false;
                txtPrice.Visible = false;
                txtAddress.Visible = false;
                txtState.Visible = false;
                txtUtilities.Visible = false;
                lblAddress.Visible = false;
                lblAmentities.Visible = false;
                lblbathrooms.Visible = false;
                lblbedrooms.Visible = false;
                lblCity.Visible = false;
                lblGarage.Visible = false;
                lblHouseDescription.Visible = false;
                lblHouseYear0.Visible = false;
                lblImages.Visible = false;
                lblPrice.Visible = false;
                lblPropertyType.Visible = false;
                lblState.Visible = false;
                lblUtilities3.Visible = false;
                gvRequestors.Visible = false;
                btnSellhouse.Visible = false;
                lblHouseDescription.Visible = false;
                txtHomeSize.Visible = false;
                lblHouseDescription0.Visible = false;

            }


            //putting all the data from requestedSelling table into the gridview
            //String strSQL = "SELECT * FROM TP_RequestedSelling";
            String strSQL = "SELECT * FROM TP_RequestedSelling Where AgentId =" + UserID;


            DBConnect objDB = new DBConnect();


            gvRequestors.DataSource = objDB.GetDataSet(strSQL);
            gvRequestors.DataBind();



        }

        protected void gvRequestors_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if( e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvRequestors.Rows[rowIndex];
                txtProperty.Text = row.Cells[6].Text;
                txtGarage.Text = row.Cells[9].Text;
                txtBedrooms.Text = row.Cells[4].Text;
                txtBathrooms.Text = row.Cells[3].Text;
                txtCity.Text = row.Cells[1].Text;
                txtAmentities.Text = row.Cells[8].Text;
                txtDescription.Text = row.Cells[12].Text;
                txtHouseYear.Text = row.Cells[5].Text;
                txtImages.Text = row.Cells[11].Text;
                txtPrice.Text = row.Cells[10].Text;
                txtAddress.Text = row.Cells[2].Text;
                txtState.Text = row.Cells[0].Text;
                txtUtilities.Text = row.Cells[7].Text;
                txtHomeSize.Text = row.Cells[13].Text;

                
            }
        }

        protected void btnSellhouse_Click(object sender, EventArgs e)
        {
            ////retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);

            int houseId = (int)Session["HouseId"];
            string houseStatus = "For Sale";
            house.updateStatus(houseId, houseStatus);


            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateRealEstateId";



            objCommand.Parameters.AddWithValue("@RealId", UserID);
            objCommand.Parameters.AddWithValue("@HouseId", houseId);



            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);


        }
    }
}