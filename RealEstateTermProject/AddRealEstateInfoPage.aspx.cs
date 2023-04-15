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
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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


            
            objCommand.CommandType = CommandType.StoredProcedure;
           // objCommand.CommandText = "";
            objCommand.Parameters.AddWithValue("@theRealEstate", byteArray);




           
          
        }
    }
}