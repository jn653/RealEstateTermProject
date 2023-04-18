<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeOffers.aspx.cs" Inherits="RealEstateTermProject.HomeOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="js/navHomeSeller.js"></script>
</head>
<body>
    <script>navHomeSeller()</script>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gvHomeOffers" runat="server" style="z-index: 1; left: 357px; top: 251px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="75" ForeColor="RoyalBlue" style="z-index: 1; left: 359px; top: 62px; position: absolute" Text="Home Offers"></asp:Label>
    </form>
</body>
</html>
