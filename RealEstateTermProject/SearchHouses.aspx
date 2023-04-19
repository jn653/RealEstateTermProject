<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHouses.aspx.cs" Inherits="RealEstateTermProject.SearchHouses" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/nav.js"></script>
    <title></title>
</head>
<body>
     <script>nav();</script>
    <form id="form1" runat="server">
        <div>
        </div>

        <p>

            <asp:Image ID="Image1" runat="server" ImageUrl="~/pics/leftarrowimage-removebg-preview.png" style="z-index: 1; left: 17px; top: 67px; position: absolute; height: 10px; width: 21px" />
            <div style="z-index: 1; left: 253px; top: 83px; position: absolute; height: 27px; width: 1464px"> 
    
        </div>
                
        <asp:Label ID="lblState" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 303px; top: 109px; position: absolute" Text="State"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 473px; top: 108px; position: absolute" Text="Price"></asp:Label>
        <asp:DropDownList ID="ddlPrice" runat="server" style="z-index: 1; left: 449px; top: 152px; position: absolute; right: 715px">
            <asp:ListItem>Lower than or equal to 100,000</asp:ListItem>
            <asp:ListItem>Greater than 100,000 or equal to 200,000</asp:ListItem>
            <asp:ListItem>Greater than 200,000</asp:ListItem>
        </asp:DropDownList>

            <asp:Button ID="btnSearchHouse" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 413px; top: 262px; position: absolute" Text="Search House" />

            <asp:Label ID="lblSearch" runat="server" Text="Search for a house by" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 8px; top: 141px; position: absolute"></asp:Label>
        
            <asp:DropDownList ID="ddlCriteria" runat="server" style="z-index: 1; left: 519px; top: 288px; position: absolute; width: 171px; right: 756px;">
                <asp:ListItem>State/Price/PropertyType</asp:ListItem>
                <asp:ListItem>City/Price</asp:ListItem>
                <asp:ListItem>State/Price/Number of bedrooms</asp:ListItem>
                <asp:ListItem>Price/Number of bathrooms</asp:ListItem>
        </asp:DropDownList>

            <asp:HyperLink ID="hyperlinkBack" runat="server" Font-Size="Small" ForeColor="RoyalBlue" NavigateUrl="~/SearchHouses.aspx" style="z-index: 1; left: 45px; top: 64px; position: absolute">Back to Search</asp:HyperLink>

            <asp:Label ID="lblCity" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 350px; top: 106px; position: absolute" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 339px; top: 152px; position: absolute; width: 96px"></asp:TextBox>
        <asp:Label ID="lblNumofBedrooms" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 735px; top: 104px; position: absolute" Text="Number of Bedrooms"></asp:Label>

            <asp:Label ID="lblSearchByCriteria" runat="server" Text="Search for a house by One of the following criteria:" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 272px; top: 223px; position: absolute"></asp:Label>
        
            <asp:Button ID="btnsubmitCriteria" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnsubmitCriteria_Click" style="z-index: 1; left: 515px; top: 358px; position: absolute" Text="Submit criteria" />
        <asp:DropDownList ID="ddlPropertyType" runat="server" style="z-index: 1; left: 743px; top: 151px; position: absolute">
            <asp:ListItem>Single-family home</asp:ListItem>
            <asp:ListItem>Multi-family home</asp:ListItem>
            <asp:ListItem>Condo</asp:ListItem>
            <asp:ListItem>TownHouse</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblPropertyType" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 742px; top: 101px; position: absolute" Text="Property Type"></asp:Label>
                
        <asp:DropDownList ID="ddlnumofBathrooms" runat="server" style="z-index: 1; left: 787px; top: 151px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3+</asp:ListItem>
        </asp:DropDownList>
                
        </p>
        <div style="z-index: 1; left: 507px; top: 316px; position: absolute; height: 27px; width: 1464px">

        <ajaxToolkit:ComboBox ID="AjaxComboCriteria" runat="server" style="z-index: 1; left: 10px; top: 172px; position: absolute">
            <asp:ListItem>State/Price/PropertyType</asp:ListItem>
            <asp:ListItem>City/Price</asp:ListItem>
            <asp:ListItem>State/Price/Number of bedrooms</asp:ListItem>
            <asp:ListItem>Price/Number of bathrooms</asp:ListItem>
        </ajaxToolkit:ComboBox>

        </div>
    </form>
</body>
</html>
