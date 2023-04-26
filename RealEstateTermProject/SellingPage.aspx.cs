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
        SoapUserFunc SoapUser = new SoapUserFunc();
        HouseUtils houseUtils = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.Attributes.Add("enctype", "multipart/form-data");
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            createImageUploads();
        }

        private void createImageUploads()
        {
            for (int i = 0; i < 15; i++)
            {
                Control c = new Control();
                c.ID = $"uploadImage{i}";

                Image im = new Image();
                im.ID = $"im{i}";
                im.CssClass = "imageImg";

                FileUpload fl = new FileUpload();
                fl.ID = $"fl{i}";
                fl.Attributes.Add("onchange", $"changeButton({i})");

                TextBox tb = new TextBox();
                tb.ID = $"tb{i}";
                tb.CssClass = "imageCaption";
                tb.Attributes.Add("placeholder", "Image Caption");

                Label lbl = new Label();
                lbl.ID = $"lbl{i}";
                lbl.Text = "Upload Image";
                lbl.CssClass = "imageButton";
                lbl.AssociatedControlID = fl.ID;
                
                c.Controls.Add(im);
                c.Controls.Add(fl);
                c.Controls.Add(lbl);
                c.Controls.Add(tb);
                c.Visible = false;

                FindControl("contentBox").Controls.Add(c);
            }
        }
        public String UploadFile()
        {
            String dir = $@"{Server.MapPath("~/")}pics\houses\{address.Value}";

            System.Diagnostics.Debug.WriteLine(dir);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            for (int i = 0; i < 15; i++)
            {
                var c = FindControl($"uploadImage{i}");
                var fl = (FileUpload)FindControl($"fl{i}");
                
                TextBox tb = (TextBox)FindControl($"tb{i}");

                System.Diagnostics.Debug.Write(fl.ID);
                System.Diagnostics.Debug.Write(fl.HasFile);
                System.Diagnostics.Debug.WriteLine(fl.FileName);
                
                if (c.Visible && fl.HasFile)
                {
                    fl.SaveAs($@"{dir}\{tb.Text}.jpeg");
                }
            }

            return dir;
        }

        protected void AddFileUpload(object sender, EventArgs e)
        {
            DropDownList dl = (DropDownList)sender;

            for (int i = 0; i < 15; i++)
            {
                Control c = FindControl($"uploadImage{i}");
                var fl = (FileUpload)c.FindControl($"fl{i}");

                c.Visible = false;
                fl.Visible = false;
            }

            if (dl.SelectedValue == "0")
                return;

            for (int i = 0; i < int.Parse(dl.SelectedValue); i++)
            {
                Control c = FindControl($"uploadImage{i}");
                var fl = (FileUpload)c.FindControl($"fl{i}");

                c.Visible = true;
                fl.Visible = true;
            }
            

        }

        protected void findRealtor_Click(object sender, EventArgs e)
        {
            House house = createHouse();
           
            Session["House"] = house;

            Response.Redirect("ShowRealEstatesCompany.aspx");

        }

        public House createHouse()
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);

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
            house.HouseImages = UploadFile();
            house.State = state.Value;
            house.NumberOfBathrooms = int.Parse(numOfBath.Value);
            house.City = city.Value;
            house.SellerID = UserID;
            house.RealEstateID = -1;

            return house;
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



            House house = createHouse();

            /*
            if (AccountType == "Home Seller")
                house.SellerID = (int)Session["AccountID"];
            else
                house.RealEstateID = (int)Session["AccountID"];*/

            houseUtils.putHouse(house);
            Response.Redirect("AddingHouseInfotoSellPage.aspx");
        }
    }
}