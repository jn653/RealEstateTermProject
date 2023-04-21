using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblAgentName.Visible = false;
                lblcomapnyinfo.Visible = false;
                lblComapnyName.Visible = false;
                lblPhoneNumber.Visible = false;

                String strSQL = "SELECT RealEstateCompany FROM TP_RealEstateCompany";

                DBConnect objDB = new DBConnect();
                objDB.GetDataSet(strSQL);

                Byte[] byteArray = (Byte[])objDB.GetField("RealEstateCompany", 0);



                BinaryFormatter deSerializer = new BinaryFormatter();

                MemoryStream memStream = new MemoryStream(byteArray);



                RealEstateAgent objrealEstate = (RealEstateAgent)deSerializer.Deserialize(memStream);

                for (int i = 0; i <= byteArray.Count(); i++)
                {
                    gvShowRealEstate.DataSource = byteArray;
                    gvShowRealEstate.DataBind();
                    gvShowRealEstate.Rows[0].Cells[0].Text = objrealEstate.agentName.ToString();
                }

            }






        }

        protected void gvShowRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ViewButton(object sender, EventArgs e)
        {
            
                lblAgentName.Visible = true;
                lblcomapnyinfo.Visible = true;
                lblComapnyName.Visible = true;
                lblPhoneNumber.Visible = true;
           
            
        }


    }
}