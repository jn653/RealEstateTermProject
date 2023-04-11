<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHouses.aspx.cs" Inherits="RealEstateTermProject.SearchHouses" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/navHomeSeller.js"></script>
    <title></title>
</head>
<body>
     <script>navHomeSeller();</script>
    <form id="form1" runat="server">
        <div>
        </div>

        <p>

            &nbsp;<div style="z-index: 1; left: 253px; top: 83px; position: absolute; height: 27px; width: 1464px"> 
    
        </div>
                
        <asp:Label ID="lblState" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 303px; top: 109px; position: absolute" Text="State"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 473px; top: 108px; position: absolute" Text="Price"></asp:Label>
        <asp:DropDownList ID="ddlPrice" runat="server" style="z-index: 1; left: 449px; top: 152px; position: absolute; right: 715px">
            <asp:ListItem>Lower than or equal to 100,000</asp:ListItem>
            <asp:ListItem>lower than or equal to 200,000</asp:ListItem>
            <asp:ListItem>greater than or equal to 200,000</asp:ListItem>
        </asp:DropDownList>

            <asp:Label ID="lblSearch" runat="server" Text="Search for a house by" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 8px; top: 141px; position: absolute"></asp:Label>
        
            <asp:DropDownList ID="ddlCriteria" runat="server" style="z-index: 1; left: 519px; top: 288px; position: absolute; width: 171px">
                <asp:ListItem>State/Price/PropertyType</asp:ListItem>
                <asp:ListItem>City/Price</asp:ListItem>
                <asp:ListItem>State/Price/Number of bedrooms</asp:ListItem>
                <asp:ListItem>Price/Number of bathrooms</asp:ListItem>
        </asp:DropDownList>

            <asp:Label ID="lblSearchByCriteria" runat="server" Text="Search for a house by One of the following criteria:" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 272px; top: 223px; position: absolute"></asp:Label>
        
            <asp:Button ID="btnsubmitCriteria" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnsubmitCriteria_Click" style="z-index: 1; left: 515px; top: 358px; position: absolute" Text="Submit criteria" />
        <asp:DropDownList ID="ddlPropertyType" runat="server" style="z-index: 1; left: 743px; top: 151px; position: absolute">
            <asp:ListItem>Single-family home</asp:ListItem>
            <asp:ListItem>Multi-family home</asp:ListItem>
            <asp:ListItem>Condo</asp:ListItem>
            <asp:ListItem>TownHouse</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblPropertyType" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 742px; top: 101px; position: absolute" Text="Property Type"></asp:Label>
                
        </p>
    </form>
</body>
</html>
