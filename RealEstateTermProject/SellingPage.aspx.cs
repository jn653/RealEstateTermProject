using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Media;
using Utilities;

namespace RealEstateTermProject
{
    public partial class SellingPage : System.Web.UI.Page
    {

        HouseUtils houseUtils = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {

            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            createImageUploads();
        }

        private void createImageUploads()
        {
            for (int i = 0; i <= 15; i++)
            {
                Control c = new Control();
                c.ID = $"uploadImage{i}";

                FileUpload fl = new FileUpload();
                fl.ID = $"fl{i}";

                TextBox tb = new TextBox();
                tb.ID = $"tb{i}";
                tb.CssClass = "imageCaption";
                tb.Text = "Image Caption";

                Label lbl = new Label();
                lbl.ID = $"lbl{i}";
                lbl.Text = "Upload Image";
                lbl.CssClass = "imageButton";
                lbl.AssociatedControlID = fl.ID;

                c.Controls.Add(lbl);
                c.Controls.Add(tb);
                c.Controls.Add(fl);
                c.Visible = false;

                FindControl("contentBox").Controls.Add(c);
            }
        }
        protected void UploadFile(object sender, EventArgs e)
        {
            String dir = $@"C:\{address.Value}";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            for(int i = 0; i <= 15; i++)
            {
                Control c = FindControl($"uploadImage{i}");
                FileUpload fl = (FileUpload)c.FindControl($"fl{i}");
                
                TextBox tb = (TextBox)c.FindControl($"tb{i}");
                if (c.Visible && fl.HasFile)
                {
                    fl.SaveAs($@"{dir}\{tb.Text}.png");
                }
            }


            /*for (int i = 1; i <= 20; i++)
            {
                var control = (FileUpload)upImages.FindControl($"FileUpload{i}");
                if (control.Visible)
                {
                    String caption = Page.Request.Form[$"imageCaption{i}"].ToString();
                    control.SaveAs($@"{dir}\{caption}.png");
                }
            }*/
        }

        protected void onHasFile(object sender, EventArgs e)
        {

        }

        protected void AddFileUpload(object sender, EventArgs e)
        {
            DropDownList dl = (DropDownList)sender;

            for (int i = 0; i <= 15; i++)
            {
                Control c = FindControl($"uploadImage{i}");
                c.Visible = false;
            }

            if (dl.SelectedValue == "0")
                return;

            for (int i = 0; i <= int.Parse(dl.SelectedValue); i++)
            {
                Control c = FindControl($"uploadImage{i}");
                c.Visible = true;
            }
            /*
            List<Control> controls = new List<Control>();

            DropDownList dl = (DropDownList)sender;

            upImages.ContentTemplateContainer.Controls.Clear();

            if (dl.SelectedValue == "0")
                return;

            for(int i = 0; i <= int.Parse(dl.SelectedValue); i++)
            {
                Control c = new Control();
                c.ID = $"uploadImage{i}";

                FileUpload fl = new FileUpload();
                fl.ID = $"fl{i}";

                TextBox tb = new TextBox();
                tb.ID = $"tb{i}";
                tb.Text = "Image Caption";

                Label lbl = new Label();
                lbl.ID = $"lbl{i}";
                lbl.Text = "Upload Image";
                lbl.AssociatedControlID = fl.ID;

                c.Controls.Add(lbl);
                c.Controls.Add(tb);
                c.Controls.Add(fl);

                controls.Add(c);
                upImages.ContentTemplateContainer.Controls.Add(c);
            }
                
            /*
            for (int i = 1; i <= 1; i++)
            {
                //upImages.FindControl($"FileUpload{i}").Visible = true;
                upImages.FindControl($"FileUpload1").Visible = false;
                upImages.FindControl($"lbl{i}").Visible = false;
            }

            for (int i = 1; i <= int.Parse(dl.SelectedValue); i++)
            {
                //upImages.FindControl($"FileUpload{i}").Visible = true;
                upImages.FindControl($"FileUpload1").Visible = true;
                upImages.FindControl($"lbl{i}").Visible = true;
            }*/
            /*try
            {
                foreach (Control c in upImages.ContentTemplateContainer.Controls)
                {
                    if (!c.Visible)
                    {

                        c.Visible = true;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

            }*/
            /*
            for (int i = 1; i <= 20; i++)
            {
                //Control c = upImages.FindControl($"FileUpload{i}");
                Label l = (Label)upImages.FindControl($"fileUploadLabel{i}");
                //TextBox t = (TextBox)upImages.FindControl("puke");
                if (!l.Visible)
                {
                    l.Visible = true;
                    return;
                }
            }*/


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            //retrieving the account type from the stored session
            string AccountType = (string)Session["accountType"];

            /*// stored procedure to get the user ID
            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUserID";


            objCommand50.Parameters.AddWithValue("@theUsername", UserAccountName);


            SqlParameter outputParameter30 = new SqlParameter("@theID", SqlDbType.Int, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);




            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            int UserID = Convert.ToInt32(objCommand50.Parameters["@theID"].Value.ToString());
            */



            House house = new House();
            house.Address = address.Value;
            house.PropertyType = propertyType.Value;
            house.HomeSize = int.Parse(homeSize.Value);
            house.NumberOfBedrooms = int.Parse(numOfBed.Value);
            house.Amenities = amenities.Value;
            house.HouseYear = int.Parse(houseYear.Value);
            house.Garage = garage.Value;
            house.Utilities = utilities.Value;
            house.HomeDescription = homeDescription.Value;
            house.AskingPrice = int.Parse(askingPrice.Value);
            house.HouseImages = houseImages.Value;
            house.State = state.Value;
            house.NumberOfBathrooms = int.Parse(numOfBath.Value);
            house.City = city.Value;
            house.SellerID = -1;
            house.RealEstateID = -1;

            /*
            if (AccountType == "Home Seller")
                house.SellerID = (int)Session["AccountID"];
            else
                house.RealEstateID = (int)Session["AccountID"];*/

            houseUtils.putHouse(house);
            //Response.Redirect("AddingHouseInfotoSellPage.aspx");
        }
    }
}