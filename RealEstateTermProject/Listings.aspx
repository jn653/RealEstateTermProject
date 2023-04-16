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
                    <h1>
                        Property Details
                    </h1>
                    <contentBox>
                        <h2>Beds</h2>
                        <h3 id="beds" runat="server" ></h3>
                        <h2>Property Type</h2>
                        <h3 id="propertyType" runat="server"></h3>
                        <h2>Square Footage</h2>
                        <h3 id="houseSize" runat="server" ></h3>
                    </contentBox>
                    <contentBox>
                        <h2>Amenities</h2>
                        <h3 id="amenities" runat="server" ></h3>
                        <h2>Garages</h2>
                        <h3 id="garages" runat="server" ></h3>
                        <h2>Year Built</h2>
                        <h3 id="houseYear" runat="server" ></h3>
                    </contentBox>
                </homeinfocontent>
            </homeinfofull>
        </homeinfo>
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
