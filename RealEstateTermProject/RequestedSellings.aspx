<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestedSellings.aspx.cs" Inherits="RealEstateTermProject.RequestedSellings" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="55pt" ForeColor="RoyalBlue" style="z-index: 1; left: 277px; top: 64px; position: absolute" Text="Users requesting to sell"></asp:Label>
            <asp:Label ID="lblTestingpage" runat="server" style="z-index: 1; left: 298px; top: 142px; position: absolute" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
