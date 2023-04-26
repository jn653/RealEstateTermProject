using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class ShowRealEstatesCompany : System.Web.UI.Page
    {
        SoapUserFunc soapUser = new SoapUserFunc();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<RealEstateAgent> objList = new List<RealEstateAgent>();

            lblAgentChosen.Visible = false;

            if (!IsPostBack)
            {

                //putting all the data from realestateinfo table into the gridview
                String strSQL = "SELECT * FROM TP_RealEstateInfo";

                DBConnect objDB = new DBConnect();
                

                gvShowRealEstate.DataSource = objDB.GetDataSet(strSQL);
                gvShowRealEstate.DataBind();


            }






        }

        protected void gvShowRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            lblAgentChosen.Visible = true;

            //retreiving the house information from selling page
            House objhouse = new House();
            objhouse = (House)Session["House"];
            


            //going through the gridview to get the checkbox if it is checked
            for (int row = 0; row < gvShowRealEstate.Rows.Count; row++)
            {
                CheckBox profileCheck;
                profileCheck = (CheckBox)gvShowRealEstate.Rows[row].FindControl("checkboxChoose");


                if (profileCheck.Checked)
                {

                    //retrieving the username for the stored username in login and sign up page to use in other pages
                    string UserAccountName = (string)Session["Username"];

                    //storing user id
                    int UserID = soapUser.GetIDByUsername(UserAccountName);

                    int AgentId = Convert.ToInt32(gvShowRealEstate.Rows[row].Cells[1].Text);



                    //soapUser.AddToRequestedSeller(UserAccountName, objhouse.SellerID, objhouse.Address, objhouse.Amenities, objhouse.State, objhouse.AskingPrice, objhouse.City, objhouse.Garage, objhouse.HomeDescription, objhouse.HomeSize, objhouse.HouseImages,
                    //    objhouse.HouseYear, objhouse.NumberOfBathrooms, objhouse.NumberOfBedrooms, objhouse.PropertyType, objhouse.Utilities, AgentId);

                    lblAgentChosen.Text = "The Agent" + " " + gvShowRealEstate.Rows[row].Cells[3].Text + " " + "Has been notified of your request to sell a house with them";
                }
            }
        }
    }
}
       
            

            

            
           
   