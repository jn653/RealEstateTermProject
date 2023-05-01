using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Utilities;
using System.Web.DynamicData;
using System.Collections;

namespace RealEstateTermProject
{
    public partial class Listings : System.Web.UI.Page
    {
        DBConnect utils = new DBConnect();
        HouseUtils houseUtils = new HouseUtils();
        SqlCommand SQLcmd;
        House localHouse = new House();

        protected void Page_Load(object sender, EventArgs e)
        {
            createButtons(houseUtils.getHouses());
        }

        private void createButtons(List<House> houses)
        {
            HtmlGenericControl listingBox = houseUtils.createAllListings(houses);

            foreach (Control control in listingBox.Controls)
            {
                Button button = new Button();
                button.CssClass = "button";
                button.SkinID = control.SkinID;
                button.Text = "View Home";
                button.Attributes["runat"] = "server";
                button.Click += new EventHandler(Button_Click);

                control.Controls.Add(button);
            }

            content.Controls.Add(listingBox);
        }

        public void showHomeInfo(String id)
        {
            int i = int.Parse(id);

            House house = houseUtils.getHouse(int.Parse(id));
            List<HouseImage> images = houseUtils.getImages(house.Address);

            homeAddress.InnerHtml = house.Address;
            image.Src = house.CoverImageUrl;

            homeDescription.InnerHtml = house.HomeDescription;
            houseSize.InnerHtml = house.HomeSize.ToString();

            beds.InnerHtml = house.NumberOfBedrooms.ToString();
            bathrooms.InnerHtml = house.NumberOfBathrooms.ToString();
            propertyType.InnerHtml = house.PropertyType;

            amenities.InnerHtml = house.Amenities;
            utilities.InnerHtml = house.Utilities;
            garages.InnerHtml = house.Garage;
            houseYear.InnerHtml = house.HouseYear.ToString();

            askingPrice.InnerHtml = house.AskingPrice.ToString();
            state.InnerHtml = house.State;
            city.InnerHtml = house.City;

            comments.Controls.Clear();
            homeSizes.Controls.Clear();

            List<Comment> lComments = houseUtils.getCommentsForHouse(house.Address);
            List<Room> rooms = house.Rooms;

            foreach (Comment comment in lComments)
            {
                HtmlGenericControl username = new HtmlGenericControl("h2");
                HtmlGenericControl content = new HtmlGenericControl("h3");

                username.InnerText = comment.Username;
                content.InnerText = comment.Content;

                comments.Controls.Add(username);
                comments.Controls.Add(content);
            }

            foreach(Room room in rooms)
            {
                HtmlGenericControl desc = new HtmlGenericControl("h2");
                HtmlGenericControl lw = new HtmlGenericControl("h3");

                desc.InnerText = room.RoomDescription;
                lw.InnerText = $"{room.RoomSizeL}x{room.RoomSizeW}";

                homeSizes.Controls.Add(desc);
                homeSizes.Controls.Add(lw);
            }

            foreach(HouseImage image in images)
            {
                Image img = new Image();
                img.ImageUrl = image.Url;
                imageBox.Controls.Add(img);
            }

            Session["House"] = house;
            homeInfo.Visible = true;
        }

        protected void MakeOffer_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;

                if (houseUtils.AddHomeOffer((House)Session["House"], Session["Username"].ToString(), int.Parse(offerBox.Value)))
                    Response.Write("<script>alert('Congratulations, your request has been accepted and will be reviewed shortly! Stay posted for any updates!')</script>");
                else
                    Response.Write("<script>alert('Unfortunately, there was an issue proccessing your request. Please make sure you have entered all of the info correctly.')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Unfortunately, there was an issue proccessing your request. Please make sure you have entered all of the info correctly.')</script>");
            }
        }

        protected void ShowScheduleVisit_Click(object sender, EventArgs e)
        {
            requestVisitContent.Visible = true;
        }

        protected void ScheduleVisit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Parse(visitDate.Value);
                String t = visitTime.SelectedValue;

                System.Diagnostics.Debug.WriteLine(visitDate.Value);
                if (houseUtils.ScheduleVisit((House)Session["House"], Session["Username"].ToString(), dt, t))
                {
                    Response.Write("<script>alert('Congratulations, your request has been accepted! Make sure to be there at least 5 minutes before the scheduled time!')</script>");
                    requestVisitContent.Visible = false;
                }
                else
                {
                    Response.Write("<script>alert('Unfortunately, there was an issue proccessing your request. Please try again.')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Unfortunately, there was an issue proccessing your request. Please try again.')</script>");
            }
        }

        protected void UploadComment_Click(object sender, EventArgs e)
        {
            House house = (House)Session["House"];
            Comment comment = new Comment();

            comment.Address = house.Address;
            comment.Username = Session["Username"].ToString();
            comment.Content = userComment.Value;

            houseUtils.putComment(comment);

            comments.Controls.Clear();

            List<Comment> lComments = houseUtils.getCommentsForHouse(house.Address);

            foreach (Comment c in lComments)
            {
                HtmlGenericControl username = new HtmlGenericControl("h2");
                HtmlGenericControl content = new HtmlGenericControl("h3");

                username.InnerText = c.Username;
                content.InnerText = c.Content;

                comments.Controls.Add(username);
                comments.Controls.Add(content);
            }
        }

        protected void CancelRequest_Click(object sender, EventArgs e)
        {
            requestVisitContent.Visible = false;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            showHomeInfo(button.SkinID);
        }
    }
}