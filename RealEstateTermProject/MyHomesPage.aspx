<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyHomesPage.aspx.cs" Inherits="RealEstateTermProject.MyHomesPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/navHomeSeller.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 473px; top: 358px; position: absolute; height: 180px; width: 289px">
            <Columns>
                <asp:ButtonField CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblMyHomes" runat="server" Font-Bold="True" Font-Size="85" ForeColor="RoyalBlue" style="z-index: 1; left: 367px; top: 99px; position: absolute" Text="My Homes"></asp:Label>
    <script>navHomeSeller()</script>
        <div>
        </div>
    </form>
</body>
</html>
