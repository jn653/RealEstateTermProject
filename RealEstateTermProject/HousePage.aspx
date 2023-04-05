<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HousePage.aspx.cs" Inherits="RealEstateTermProject.HousePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/HousePage.css" rel="stylesheet" />
    <script src="js/nav.js"></script>
</head>
<body>
    <script>nav();</script>
    <backgroundImage>
        <imageTitle>
            Welcome to the listings page
        </imageTitle>
        <img src="https://images.familyhomeplans.com/cdn-cgi/image/fit=scale-down,quality=85/plans/44207/44207-b600.jpg"/>
    </backgroundImage>
    <form id="form1" runat="server">
        <asp:Label style="position:absolute; top:10rem;" ID="lblTest" runat="server"></asp:Label>
        <content id="content" runat="server">
            <listingBox id="listingBox" runat="server">
                <listing>
                    f
                </listing>
                <listing>
                    h
                </listing>
                <listing>
                    j
                </listing>
            </listingBox>
        </content>
    </form>
</body>
</html>
