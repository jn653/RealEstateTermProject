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

            //string address = (string)Session["address"];
            //string propertyType = (string)Session["property"];
            //int homeSize = (int)Session["homeSize"];
            //int bedrooms = (int)Session["Bedrooms"];
            //string amentities = (string)Session["Amenities"];
            //int year = (int)Session["Year"];
            //string Garage = (string)Session["Garage"];
            //string Utilities = (string)Session["Utils"];
            //string description = (string)Session["Description"];
            //double price = (double)Session["Price"];
            //string Images = (string)Session["Images"];
            //string state = (string)Session["State"];
            //int bathrooms = (int)Session["Bathrooms"];
            //string city = (string)Session["City"];
            //int SellerId = (int)Session["SellerId"];

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
                    //int UserID = soapUser.GetIDByUsername(UserAccountName);
                    
                    int AgentId = Convert.ToInt32(gvShowRealEstate.Rows[row].Cells[1].Text);



                    //soapUser.AddToRequestedSeller(UserAccountName, SellerId, address, amentities, state, price, city, Garage, description, homeSize, Images,
                    //    year, bathrooms, bedrooms, propertyType, Utilities, AgentId);
                    lblAgentChosen.Text =  objhouse.Address + objhouse.Garage + objhouse.AskingPrice + "The Agent" + " " + gvShowRealEstate.Rows[row].Cells[3].Text + " " + "Has been notified of your request to sell a house with them";
                }
            }
        }
    }
}
       
            

            

            
           
   