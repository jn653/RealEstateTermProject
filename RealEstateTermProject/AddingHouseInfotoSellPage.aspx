<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingHouseInfotoSellPage.aspx.cs" Inherits="RealEstateTermProject.AddingHouseInfotoSellPage" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       
    <title></title>
    <script src="js/navHomeSeller.js"></script>
    <style type="text/css">
        #TextArea1 {
            z-index: 1;
            left: 8px;
            top: 504px;
            position: absolute;
        }
        #TextAreaHouseDescription {
            z-index: 1;
            left: 1122px;
            top: 381px;
            position: absolute;
        }
    </style>
</head>
<body>
     <script>navHomeSeller();</script>
   
    
    <form id="form1" runat="server">
    
        

        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 274px; top: 155px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 63px; top: 154px; position: absolute" Text="State"></asp:Label>
        

        <asp:Label ID="lblAdress" runat="server" style="z-index: 1; left: 453px; top: 154px; position: absolute" Text="Address"></asp:Label>
    
        <textarea ID="TextAreaHouseDescription" cols="20" name="S1" rows="2"></textarea>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 432px; top: 196px; position: absolute"></asp:TextBox>
    
        <asp:Label ID="lblHomeSize" runat="server" style="z-index: 1; left: 635px; top: 153px; position: absolute" Text="Home Size"></asp:Label>
        <asp:Label ID="lblNumofBedrooms" runat="server" style="z-index: 1; left: 842px; top: 155px; position: absolute" Text="Number of Bedrooms"></asp:Label>
        <asp:Label ID="lblNumofBathrooms" runat="server" style="z-index: 1; left: 1109px; top: 152px; position: absolute" Text="Number of Bathrooms"></asp:Label>
        <asp:Label ID="lblHouseYear" runat="server" style="z-index: 1; left: 2px; top: 345px; position: absolute" Text="Year house was built"></asp:Label>
        <asp:Label ID="lblUtilities" runat="server" style="z-index: 1; left: 283px; top: 343px; position: absolute" Text="Utilities "></asp:Label>
        <asp:Label ID="lblGarage" runat="server" style="z-index: 1; left: 424px; top: 329px; position: absolute; width: 260px; height: 51px" Text="Does the house have a Garage?"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 731px; top: 341px; position: absolute; right: 703px" Text="Price"></asp:Label>
        <asp:Label ID="lblImages" runat="server" style="z-index: 1; left: 949px; top: 349px; position: absolute; height: 27px" Text="Images"></asp:Label>
        <asp:Label ID="lblHouseDescription" runat="server" style="z-index: 1; left: 1127px; top: 348px; position: absolute" Text="House Description"></asp:Label>
        <asp:Button ID="btnPutHouseForSale" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 668px; top: 486px; position: absolute; height: 36px; width: 260px;" Text="Put House for Sale" OnClick="btnPutHouseForSale_Click" />
        <asp:TextBox ID="txtAmentities" runat="server" style="z-index: 1; left: 224px; top: 470px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 254px; top: 443px; position: absolute" Text="Amentities"></asp:Label>
        <asp:CheckBox ID="checkboxYesGarage" runat="server" style="z-index: 1; left: 450px; top: 382px; position: absolute" Text="Yes" />
        <asp:CheckBox ID="checkboxNoGarage" runat="server" style="z-index: 1; left: 449px; top: 407px; position: absolute" Text="No" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 676px; top: 389px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtImage" runat="server" style="z-index: 1; left: 917px; top: 389px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtUtilities" runat="server" style="z-index: 1; left: 226px; top: 384px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtHouseYear" runat="server" style="z-index: 1; left: 6px; top: 382px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtNumofBedrooms" runat="server" style="z-index: 1; left: 855px; top: 194px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtNumofBathrooms" runat="server" style="z-index: 1; left: 1122px; top: 186px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtHomeSize" runat="server" style="z-index: 1; left: 606px; top: 198px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 244px; top: 195px; position: absolute; width: 155px"></asp:TextBox>
        </p>
    <div style="z-index: 1; left: 2px; top: 127px; position: absolute; height: 27px; width: 1464px">
        <asp:Label ID="lblPropertyType" runat="server" style="z-index: 1; left: 10px; top: 317px; position: absolute" Text="Property Type"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonPropertyType" runat="server" style="z-index: 1; left: 10px; top: 353px; position: absolute; height: 33px; width: 303px">
            <asp:ListItem>Single-family home</asp:ListItem>
            <asp:ListItem>Multi-family home</asp:ListItem>
            <asp:ListItem>Condo</asp:ListItem>
            <asp:ListItem>TownHouse</asp:ListItem>
        </asp:RadioButtonList>
        </div>
    
    </form>
</body>
</html>
