using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization.Formatters.Binary;       
using System.IO;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace RealEstateTermProject
{
    public partial class AddRealEstateInfoPage : System.Web.UI.Page
    {
       
       
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];

            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUserID";


            objCommand50.Parameters.AddWithValue("@theUsername", UserAccountName);


            SqlParameter outputParameter30 = new SqlParameter("@theID", SqlDbType.Int, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);
            
            


            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            int UserID = Convert.ToInt32( objCommand50.Parameters["@theID"].Value.ToString());


            //create realestateagent object
            RealEstateAgent objRealEstate = new RealEstateAgent();
            objRealEstate.agentName = txtboxAgentName.Text;
            objRealEstate.companyName = txtboxCompanyName.Text;
            objRealEstate.phoneNumber = txtboxPhoneNumber.Text;


            // Serialize the realestateagent object
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            Byte[] byteArray;
            serializer.Serialize(memStream, objRealEstate);
            byteArray = memStream.ToArray();

            //doesn't work, have to fix it
            //DBConnect objDB = new DBConnect();
            //SqlCommand objCommand = new SqlCommand();
            //objCommand.CommandType = CommandType.StoredProcedure;
            //objCommand.CommandText = "TP_RealEstateCompany";
            //objCommand.Parameters.AddWithValue("@theRealEstateCompany", byteArray);
            //objCommand.Parameters.AddWithValue("@theID", UserID);

            

            Response.Redirect("LandingPageforRealEstateAgent.aspx");






        }
    }
}