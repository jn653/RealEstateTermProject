using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
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

            DBConnect dbConnect2 = new DBConnect();
            DataSet myData3 = dbConnect2.GetDataSet("Select DISTINCT AgentName FROM TP_RealEstateInfo");
            realtors.DataSource = myData3;
            realtors.DataBind();
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

                Label b = new Label();
                b.CssClass = "break";

                c.Controls.Add(im);
                c.Controls.Add(fl);
                c.Controls.Add(lbl);
                c.Controls.Add(tb);
                c.Controls.Add(b);

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
                String filename = GenerateRandomString();

                var c = FindControl($"uploadImage{i}");
                var fl = (FileUpload)FindControl($"fl{i}");

                TextBox tb = (TextBox)FindControl($"tb{i}");

                String imageDir = $@"pics/houses/{address.Value}/{filename}.jpeg";

                System.Diagnostics.Debug.Write(fl.ID);
                System.Diagnostics.Debug.Write(fl.HasFile);
                System.Diagnostics.Debug.WriteLine(fl.FileName);

                if (c.Visible && fl.HasFile)
                {
                    fl.SaveAs($@"{dir}\{filename}.jpeg");

                    HouseImage image = new HouseImage();
                    image.Address = address.Value;
                    image.Url = imageDir;
                    image.ImageDescription = tb.Text;

                    houseUtils.putImage(image);
                }
            }

            return "deprecated";
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
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            //retrieving the account type from the stored session

            int UserID = SoapUser.GetIDByUsername(UserAccountName);
            string AccountType = (string)Session["accountType"];

            foreach (House h in houseUtils.getHouses())
            {
                if (h.Address == address.Value)
                {
                    Response.Write("<script>alert('Unfortunately, that address already exists. Please enter a different address.')</script>");
                    return;
                }
            }

            House house = createHouse();

            house.RealEstateID = SoapUser.GetAgentIDByAgentName(realtors.SelectedValue);

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddToRequestedSeller";



            objCommand.Parameters.AddWithValue("@theAddress", house.Address);
            objCommand.Parameters.AddWithValue("@theAmentities", house.Amenities);
            objCommand.Parameters.AddWithValue("@theState", house.State);
            objCommand.Parameters.AddWithValue("@thePrice", house.AskingPrice);
            objCommand.Parameters.AddWithValue("@theCity", house.City);
            objCommand.Parameters.AddWithValue("@theGarage", house.Garage);
            objCommand.Parameters.AddWithValue("@theHomeDescription", house.HomeDescription);
            objCommand.Parameters.AddWithValue("@theHomeSize", house.HomeSize);
            objCommand.Parameters.AddWithValue("@theHouseImages", house.HouseImages);
            objCommand.Parameters.AddWithValue("@theHouseYear", house.HouseYear);
            objCommand.Parameters.AddWithValue("@theNumOfBathroom", house.NumberOfBathrooms);
            objCommand.Parameters.AddWithValue("@theNumOfBedrooms", house.NumberOfBedrooms);
            objCommand.Parameters.AddWithValue("@thePropertyType", house.PropertyType);
            objCommand.Parameters.AddWithValue("@theUtilities", house.Utilities);
            objCommand.Parameters.AddWithValue("@agentId", house.RealEstateID);
            objCommand.Parameters.AddWithValue("@SellerUsername", UserAccountName);
            objCommand.Parameters.AddWithValue("@SellerID", UserID);





            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);



            houseUtils.putHouse(house);

            houseUtils.updateStatus(houseUtils.getHouseId(house.Address), "Pending");
        }

        private House createHouse()
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            string UserAccountName = (string)Session["Username"];
            int UserID = SoapUser.GetIDByUsername(UserAccountName);

            House house = new House();
            house.Address = address.Value;
            house.PropertyType = propertyType.SelectedValue;
            house.Rooms = GrabRoomSizes();
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

            foreach (House h in houseUtils.getHouses())
            {
                if (h.Address == address.Value)
                {
                    Response.Write("<script>alert('Unfortunately, that address already exists. Please enter a different address.')</script>");
                    return;
                }
            }

            House house = createHouse();

            houseUtils.putHouse(house);
            foreach (Room room in house.Rooms)
            {
                System.Diagnostics.Debug.WriteLine(room.RoomSizeL + "x" + room.RoomSizeW + " " + room.RoomDescription);
            }
        }

        private List<Room> GrabRoomSizes()
        {
            List<Room> rs = new List<Room>();

            for (int i = 0; i <= 10; i++)
            {
                HtmlInputGenericControl length = (HtmlInputGenericControl)FindControl($"l{i}");
                HtmlInputGenericControl width = (HtmlInputGenericControl)FindControl($"w{i}");
                DropDownList ddl = (DropDownList)FindControl($"sddl{i}");

                if (length.Value != "" && width.Value != "")
                {
                    Room room = new Room();
                    room.RoomSizeL = int.Parse(length.Value);
                    room.RoomSizeW = int.Parse(width.Value);
                    room.RoomDescription = ddl.SelectedValue;
                    rs.Add(room);
                }
            }

            return rs;
        }

        private String GenerateRandomString()
        {
            int length = 15;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            return str_build.ToString();
        }
    }
}