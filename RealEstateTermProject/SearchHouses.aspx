<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHouses.aspx.cs" Inherits="RealEstateTermProject.SearchHouses" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/nav.js"></script>
    <link href="styles/SearchHouses.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 5px;
            top: 12px;
            position: absolute;
            height: 233px;
            width: 1425px;
        }
    </style>
</head>
<body>



    <script>nav();</script>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ScriptManager>
        <div>
        </div>
        <content id="content" runat="server">
        </content>

        <p>

            <asp:Image ID="Image1" runat="server" ImageUrl="~/pics/leftarrowimage-removebg-preview.png" Style="z-index: 1; left: 17px; top: 67px; position: absolute; height: 10px; width: 21px" />
            <div style="z-index: 1; left: 253px; top: 83px; position: absolute; height: 27px; width: 1464px">
            </div>

            <asp:Label ID="lblState" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 303px; top: 109px; position: absolute" Text="State"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 473px; top: 108px; position: absolute" Text="Price"></asp:Label>

            <asp:Button ID="btnSearchHouse" runat="server" BackColor="RoyalBlue" ForeColor="White" Style="z-index: 1; left: 413px; top: 262px; position: absolute" Text="Search House" OnClick="btnSearchHouse_Click" />

            <asp:Label ID="lblSearch" runat="server" Text="Search for a house by" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 8px; top: 141px; position: absolute"></asp:Label>

            <asp:HyperLink ID="hyperlinkBack" runat="server" Font-Size="Small" ForeColor="RoyalBlue" NavigateUrl="~/SearchHouses.aspx" Style="z-index: 1; left: 45px; top: 64px; position: absolute">Back to Search</asp:HyperLink>

            <asp:DropDownList ID="ddlStates" AppendDataBoundItems="true" DataTextField="State" runat="server" Style="z-index: 1; left: 290px; top: 155px; position: absolute">
            </asp:DropDownList>


            <asp:Label ID="lblCity" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 350px; top: 106px; position: absolute" Text="City"></asp:Label>
            <asp:DropDownList ID="ddlCity" runat="server" AppendDataBoundItems="true" DataTextField="City" Style="z-index: 1; left: 333px; top: 155px; position: absolute">
            </asp:DropDownList>
            <asp:Label ID="lblNumofBedrooms" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 735px; top: 104px; position: absolute" Text="Number of Bedrooms"></asp:Label>

            <asp:Label ID="lblSearchByCriteria" runat="server" Text="Search for a house by One of the following criteria:" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 272px; top: 223px; position: absolute"></asp:Label>

            <asp:Button ID="btnsubmitCriteria" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnsubmitCriteria_Click" Style="z-index: 1; left: 515px; top: 358px; position: absolute" Text="Submit criteria" />
            <asp:DropDownList ID="ddlPropertyType" AppendDataBoundItems="true" DataTextField="PropertyType" runat="server" Style="z-index: 1; left: 743px; top: 151px; position: absolute">
            </asp:DropDownList>
            <asp:Label ID="lblPropertyType" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 1; left: 742px; top: 101px; position: absolute" Text="Property Type"></asp:Label>

            <asp:DropDownList ID="ddlnumofBathrooms" runat="server" Style="z-index: 1; left: 851px; top: 162px; position: absolute">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3+</asp:ListItem>
            </asp:DropDownList>

        </p>
        <div style="z-index: 1; left: 493px; top: 206px; position: absolute; height: 27px; width: 1464px">

        </div>
            <asp:DropDownList ID="ddlPrice" runat="server" Style="z-index: 1; left: 445px; top: 158px; position: absolute; height: 20px;">
                <asp:ListItem>Lower than or equal to 100,000</asp:ListItem>
                <asp:ListItem>Greater than 100,000 or equal to 200,000</asp:ListItem>
                <asp:ListItem>Greater than 200,000</asp:ListItem>
            </asp:DropDownList>

        <div style="z-index: 1; left: 496px; top: 302px; position: absolute; height: 27px; width: 1425px">

            <ajaxToolkit:ComboBox ID="AjaxComboCriteria" runat="server">
                <asp:ListItem>State/Price/PropertyType</asp:ListItem>
                <asp:ListItem>City/Price</asp:ListItem>
                <asp:ListItem>State/Price/Number of bedrooms</asp:ListItem>
                <asp:ListItem>Price/Number of bathrooms</asp:ListItem>
            </ajaxToolkit:ComboBox>

        </div>

    </form>
</body>
</html>
