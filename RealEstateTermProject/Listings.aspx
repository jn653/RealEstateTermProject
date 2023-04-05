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
    <backgroundImage>
        <imageTitle>
            Your future starts right here!
        </imageTitle>
        <img src="https://images.familyhomeplans.com/cdn-cgi/image/fit=scale-down,quality=85/plans/44207/44207-b600.jpg"/>
    </backgroundImage>
    <form id="form1" runat="server">
        <asp:Label style="position:absolute; top:10rem;" ID="lblTest" runat="server"></asp:Label>
        <content id="content" runat="server">
        </content>
        <homeInfo id="homeInfo" runat="server" visible="false">
            <backdrop id="backdrop" onclick="hideHomeInfo()"></backdrop>
            <homeInfoFull id="homeInfoFull" runat="server">
                <mainImage id="mainImage" runat="server">
                </mainImage>
            </homeInfoFull>
        </homeInfo>
    </form>
    <script>
        function hideHomeInfo()
        {
            backdrop = document.getElementById("backdrop");
            homeInfoFull = document.getElementById("homeInfoFull");

            backdrop.style.visibility = "hidden";
            homeInfoFull.style.visibility = "hidden";

            location = location;
        }
    </script>
</body>
</html>
