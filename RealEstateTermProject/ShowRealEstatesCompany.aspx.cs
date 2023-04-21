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
        //have to fix this page
        protected void Page_Load(object sender, EventArgs e)
        {
            List<RealEstateAgent> objList = new List<RealEstateAgent>();
           
            if (!IsPostBack)
            {
                lblAgentName.Visible = false;
                lblcomapnyinfo.Visible = false;
                lblComapnyName.Visible = false;
                lblPhoneNumber.Visible = false;

                String strSQL = "SELECT Distinct RealEstateCompany FROM TP_RealEstateCompany";

                DBConnect objDB = new DBConnect();
                objDB.GetDataSet(strSQL);




               
                






                //for(int i = 0; i<= objList.Count; i++)
                //{

                //    gvShowRealEstate.DataSource = objList;
                //    gvShowRealEstate.DataBind();

                //    for (int row = 0; row < gvShowRealEstate.Rows.Count; row++)
                //    {

                //        gvShowRealEstate.Rows[row].Cells[0].Text = objrealEstate.agentName.ToString();
                //        gvShowRealEstate.Rows[row].Cells[1].Text = objrealEstate.companyName.ToString();
                //        gvShowRealEstate.Rows[row].Cells[2].Text = objrealEstate.phoneNumber.ToString();

                //        gvShowRealEstate.Columns[1].Visible = false;
                //        gvShowRealEstate.Columns[2].Visible = false;
                //    }

                //}






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

            for(int row = 0; row < gvShowRealEstate.Rows.Count; row++)
            {

            }

            

            
           
            
        }


    }
}