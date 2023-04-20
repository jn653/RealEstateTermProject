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
using Newtonsoft.Json;


namespace RealEstateTermProject
{
    public partial class AddRealEstateInfoPage : System.Web.UI.Page
    {
        SoapUserFunc soapUser = new SoapUserFunc();
       
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];

            //storing user id
           int UserID = soapUser.GetIDByUsername(UserAccountName);
            

            //create realestateagent object
            RealEstateAgent objRealEstate = new RealEstateAgent();
            objRealEstate.agentName = txtboxAgentName.Text;
            objRealEstate.companyName = txtboxCompanyName.Text;
            objRealEstate.phoneNumber = txtboxPhoneNumber.Text;


            //// Serialize the realestateagent object
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            Byte[] byteArray;
            serializer.Serialize(memStream, objRealEstate);
            byteArray = memStream.ToArray();

            //doesn't work, have to fix it

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddRealEstateCompany";
            objCommand.Parameters.AddWithValue("@theRealEstateCompany", byteArray);
            objCommand.Parameters.AddWithValue("@theID", UserID);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);




            //Response.Redirect("LandingPageforRealEstateAgent.aspx");






        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

           //the output is wrong but everything works i just have to change the output



            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            //storing user id
            int UserID = soapUser.GetIDByUsername(UserAccountName);
            String strSQL = "SELECT RealEstateCompany FROM TP_RealEstateCompany WHERE UserID ='" + UserID + "'";

            DBConnect objDB = new DBConnect();
            objDB.GetDataSet(strSQL);

            Byte[] byteArray = (Byte[])objDB.GetField("RealEstateCompany", 0);



            BinaryFormatter deSerializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream(byteArray);



            RealEstateAgent objrealEstate = (RealEstateAgent)deSerializer.Deserialize(memStream);

            lblDisplay.Text = "The following credit card information was found: </br>" +

                                       "----------------------------------------------- </br>" +

                                       "Card Type: " + objrealEstate.companyName + " </br>" +

                                       "Card #: " + objrealEstate.agentName + " </br>" +

                                       "Exp Date: " + objrealEstate.phoneNumber;

                                       
        }
    }
}