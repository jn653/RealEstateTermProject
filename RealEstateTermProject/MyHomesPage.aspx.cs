using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class MyHomesPage : System.Web.UI.Page
    {
        
        SoapUserFunc SoapUser = new SoapUserFunc();
        HouseUtils houseUtils = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            //gvMyHomes.DataSource = houseUtils.getHouses();
            //gvMyHomes.DataBind();
            loadGridview();
        }



        

        protected void loadGridview()
        {

            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);


            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_Houses Where SellerID = " + UserID + " OR RealEstateId =" + UserID;



            gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
            gvMyHomes.DataBind();



        }




        protected void gvMyHomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLinkDelete_Click1(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                DBConnect objDB = new DBConnect();

                int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


                String strSQL = "DELETE FROM TP_Houses Where ID = " + houseId;
                gvMyHomes.DataSource = objDB.GetDataSet(strSQL);
                

                loadGridview();

                lblConfim.Visible = true;
                lblConfim.Text = "House with the Id " + houseId + " was successfully Deleted";
                lblConfim.ForeColor = System.Drawing.Color.Green;


            }







        }

        //protected void linkbtnView_Click2(object sender, EventArgs e)
        //{

        //    if (IsPostBack)
        //    {
        //        int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        //        DBConnect objDB = new DBConnect();

        //        int houseId = Convert.ToInt32(gvMyHomes.Rows[rowIndex].Cells[0].Text);


        //        String strSQL = "SELECT * FROM TP_Comments WHERE ID = " + houseId;
        //        gvHouseFeedback.DataSource = objDB.GetDataSet(strSQL);
        //        gvHouseFeedback.DataBind();

        //    }


        //}


        protected void gvMyHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvMyHomes.Rows[rowIndex];
               int HouseId = Convert.ToInt32(row.Cells[0].Text);

                House brandNew = new House();
                brandNew = houseUtils.getHouse(HouseId);
                //txtHomeSize.Text = brandNew.HomeSize.ToString();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < gvMyHomes.Rows.Count; i++)
            {
                int houseId = Convert.ToInt32(gvMyHomes.Rows[i].Cells[0].Text);


               /* SoapUser.UpdateHouse(txtAddress.Text, txtAmentities.Text, txtState.Text, Convert.ToDecimal(txtPrice.Text), txtCity.Text, txtGarage.Text, txtDescription.Text, Convert.ToInt32(txtHomeSize.Text),
                    txtImages.Text, Convert.ToInt32(txtHouseYear.Text), Convert.ToInt32(txtBathrooms.Text), Convert.ToInt32(txtBedrooms.Text), txtProperty.Text, txtUtilities.Text, houseId);
               
                lblConfim.Visible = true;
                lblConfim.Text = "House with the Id " + houseId + " was successfully updated";
                lblConfim.ForeColor = System.Drawing.Color.Green;
            }*/
            Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;
            int id = int.Parse(row.Cells[0].Text);

            Session["UpdateHouse"] = houseUtils.getHouse(id);
            System.Diagnostics.Debug.WriteLine(id);

            Response.Redirect("UpdateHouse.aspx");
        }
    }
}