using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    public partial class UpdateHouse : System.Web.UI.Page
    {
        HouseUtils houseUtils = new HouseUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            House house = (House)Session["UpdateHouse"];

            if (!IsPostBack)
            {
                address.InnerText = house.Address;
                propertyType.SelectedValue = house.PropertyType;
                numOfBed.Value = house.NumberOfBedrooms.ToString();
                amenities.Value = house.Amenities;
                houseYear.Value = house.HouseYear.ToString();
                garage.Value = house.Garage.ToString();
                utilities.Value = house.Utilities;
                homeDescription.Value = house.HomeDescription;
                askingPrice.Value = house.AskingPrice.ToString();
                state.Value = house.State;
                numOfBath.Value = house.NumberOfBathrooms.ToString();
                city.Value = house.City;

                int count = 0;
                foreach (Room room in house.Rooms)
                {
                    HtmlInputGenericControl l = (HtmlInputGenericControl)FindControl($"l{count}");
                    HtmlInputGenericControl w = (HtmlInputGenericControl)FindControl($"w{count}");
                    DropDownList sddl = (DropDownList)FindControl($"sddl{count}");

                    l.Value = room.RoomSizeL.ToString();
                    w.Value = room.RoomSizeW.ToString();
                    sddl.SelectedValue = room.RoomDescription;

                    count++;
                }

                createCurrentImages(house.Images);
                createAddImages();

            }

        }
        private void createCurrentImages(List<HouseImage> images)
        {
            int i = 0;
            foreach (HouseImage image in images)
            {
                Control c = new Control();
                c.ID = $"cuploadImage{i}";

                Image im = new Image();
                im.ImageUrl = image.Url;
                im.ID = $"cim{i}";
                /*
                Button btn = new Button();
                btn.ID = $"btn{i}";
                btn.Text = "Delete Image";
                btn.CssClass = "imageButton";
                btn.SkinID = image.Url;
                btn.Click += new EventHandler(deleteImage_Click);*/
                HtmlInputGenericControl btn = new HtmlInputGenericControl("button");
                btn.ID = image.Url;
                btn.Attributes["onclick"] = $"{test(btn.ID, btn.ID)}";

                Label b = new Label();
                b.CssClass = "break";

                c.Controls.Add(im);
                c.Controls.Add(btn);
                c.Controls.Add(b);

                FindControl("contentBox1").Controls.Add(c);
            }
        }

        private void createAddImages()
        {
            for (int i = 0; i < 15; i++)
            {
                Control c = new Control();
                c.ID = $"auploadImage{i}";

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

                FindControl("contentBox3").Controls.Add(c);
            }
        }

        private House createHouse()
        {
            //retrieving the username for the stored username in login and sign up page to use in other pages
            House house = new House();
            house.HouseID = (Session["UpdateHouse"] as House).HouseID;
            house.Address = address.InnerText;
            house.PropertyType = propertyType.SelectedValue;
            house.Rooms = GetRooms();
            house.HomeSize = GetRoomSizes(house.Rooms);
            house.NumberOfBedrooms = int.Parse(numOfBed.Value);
            house.Amenities = amenities.Value;
            house.HouseYear = int.Parse(houseYear.Value);
            house.Garage = garage.Value;
            house.Utilities = utilities.Value;
            house.HomeDescription = homeDescription.Value;
            house.AskingPrice = decimal.Parse(askingPrice.Value);
            house.HouseImages = "deprecated";
            house.State = state.Value;
            house.NumberOfBathrooms = int.Parse(numOfBath.Value);
            house.City = city.Value;

            return house;
        }
        private List<Room> GetRooms()
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

        private int GetRoomSizes(List<Room> rooms)
        {
            int size = 0;

            foreach (Room room in rooms)
            {
                size += (room.RoomSizeL * room.RoomSizeW);
            }

            return size;
        }

        private object test(String id, String s)
        {
            System.Diagnostics.Debug.WriteLine(id);
            return null;
        }

        protected void deleteImage_Click(object sender, EventArgs e)
        {

        }

        protected void updateHouse_Click(object sender, EventArgs e)
        {
            houseUtils.updateHouse(createHouse());
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyHomesPage.aspx");
        }
    }
}