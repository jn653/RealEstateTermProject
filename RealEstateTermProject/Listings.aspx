<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listings.aspx.cs" Inherits="RealEstateTermProject.Listings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="styles/Listings.css" rel="stylesheet" />
    <script src="js/nav.js"></script>
    <title></title>
</head>
<body>
    <script>nav();</script>
    <backgroundimage>
        <imagetitle>
            Your future starts right here!
        </imagetitle>
        <img src="https://images.familyhomeplans.com/cdn-cgi/image/fit=scale-down,quality=85/plans/44207/44207-b600.jpg" />
    </backgroundimage>
    <form id="form1" runat="server">
        <asp:Label Style="position: absolute; top: 10rem;" ID="lblTest" runat="server"></asp:Label>
        <content id="content" runat="server">
        </content>
        <homeinfo id="homeInfo" runat="server" visible="false">
            <backdrop id="backdrop" onclick="hideHomeInfo()"></backdrop>
            <homeinfofull>
                <mainimage>
                    <img id="image" runat="server" />
                    <homeaddress id="homeAddress" runat="server">
                    </homeaddress>
                </mainimage>
                <homeinfocontent>
                    <contentbox style="flex-basis: 100%; flex-direction: column; border-bottom: .1rem solid royalblue">
                        <h2>Home Description</h2>
                        <h3 id="homeDescription" runat="server"></h3>
                    </contentbox>
                    <contentbox>
                        <h2>Beds</h2>
                        <h3 id="beds" runat="server"></h3>
                        <h2>Bathrooms</h2>
                        <h3 id="bathrooms" runat="server"></h3>
                        <h2>Property Type</h2>
                        <h3 id="propertyType" runat="server"></h3>
                        <h2>Square Footage</h2>
                        <h3 id="houseSize" runat="server"></h3>
                    </contentbox>
                    <contentbox>
                        <h2>Amenities</h2>
                        <h3 id="amenities" runat="server"></h3>
                        <h2>Utilities</h2>
                        <h3 id="utilities" runat="server"></h3>
                        <h2>Garages</h2>
                        <h3 id="garages" runat="server"></h3>
                        <h2>Year Built</h2>
                        <h3 id="houseYear" runat="server"></h3>
                    </contentbox>
                    <contentbox>
                        <h2>Asking Price</h2>
                        <h3 id="askingPrice" runat="server"></h3>
                        <h2>State</h2>
                        <h3 id="state" runat="server"></h3>
                        <h2>City</h2>
                        <h3 id="city" runat="server"></h3>
                    </contentbox>
                    <contentbox3 runat="server">
                        <h1 style="align-self: center">Comments</h1>
                        <input id="userComment" placeholder="Write your own comment here!" runat="server" />
                        <asp:Button Text="Upload Comment" OnClick="UploadComment_Click" runat="server" />
                        <commentbox id="comments" runat="server">
                        </commentbox>
                    </contentbox3>
                    <contentbox3 runat="server">
                        <h1 style="align-self: center">Home Layout</h1>
                        <commentbox id="homeSizes" runat="server">
                        </commentbox>
                    </contentbox3>
                    <contentbox3 style="margin-left: 1rem;" runat="server">
                        <h1 style="align-self: center">Images</h1>
                        <images>
                            <imagebox id="imageBox" runat="server">
                            </imagebox>
                        </images>
                    </contentbox3>
                    <contentbox3 style="flex-basis:100%;">
                        <h1>Seller Info</h1>
                        <commentBox id="sellerInfo" style="flex-direction:row;" runat="server">
                            <h2>Seller Username</h2>
                            <h1 id="sellerUsername" runat="server"></h1>
                            <h2>Account Type</h2>
                            <h1 id="accountType" runat="server"></h1>
                        </commentBox>

                    </contentbox3>
                    <contentbox style="flex-direction: row;">
                        <input id="offerBox" type="number" placeholder="Offer" runat="server" />
                        <asp:Button ID="makeOffer" Text="Make Offer" OnClick="MakeOffer_Click" runat="server" />
                        <asp:Button ID="requestVisit" Text="Request Visit" OnClick="ShowScheduleVisit_Click" runat="server" />
                    </contentbox>
                </homeinfocontent>
            </homeinfofull>
        </homeinfo>
        <requestvisit id="requestVisitContent" visible="false" runat="server">
            <backdrop id="backdrop2" style="z-index: 200;"></backdrop>
            <requestvisitcontent>
                <contentbox2>
                    <label for="visitDate">Visit Date</label>
                    <input id="visitDate" type="date" runat="server" />
                    <label for="visitTime">Visit Time</label>
                    <asp:DropDownList ID="visitTime" runat="server">
                        <asp:ListItem>9am</asp:ListItem>
                        <asp:ListItem>10am</asp:ListItem>
                        <asp:ListItem>11am</asp:ListItem>
                        <asp:ListItem>12am</asp:ListItem>
                        <asp:ListItem>1pm</asp:ListItem>
                        <asp:ListItem>2pm</asp:ListItem>
                        <asp:ListItem>3pm</asp:ListItem>
                        <asp:ListItem>4pm</asp:ListItem>
                        <asp:ListItem>5pm</asp:ListItem>
                    </asp:DropDownList>
                </contentbox2>
                <buttonbox>
                    <asp:Button ID="scheduleVisit" Text="Schedule Visit" OnClick="ScheduleVisit_Click" runat="server" />
                    <asp:Button ID="cancelRequest" Text="Cancel Request" OnClick="CancelRequest_Click" runat="server" />
                </buttonbox>
            </requestvisitcontent>
        </requestvisit>

    </form>
    <script>                              
        function hideHomeInfo() {
            homeInfo = document.getElementById("homeInfo");

            homeInfo.style.visibility = "hidden";

            location = location;
        }
    </script>
</body>
</html>
