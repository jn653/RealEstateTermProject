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
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 274px; top: 155px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 63px; top: 154px; position: absolute" Text="State"></asp:Label>
        

        <asp:Label ID="lblAdress" runat="server" style="z-index: 1; left: 453px; top: 154px; position: absolute" Text="Address"></asp:Label>
    
        <textarea id="TextAreaHouseDescription" cols="20" name="S1" rows="2"></textarea><asp:TextBox ID="txAddress" runat="server" style="z-index: 1; left: 429px; top: 194px; position: absolute; width: 155px;"></asp:TextBox>
    
        <asp:Label ID="lblHomeSize" runat="server" style="z-index: 1; left: 635px; top: 153px; position: absolute" Text="Home Size"></asp:Label>
        <asp:Label ID="lblNumofBedrooms" runat="server" style="z-index: 1; left: 842px; top: 155px; position: absolute" Text="Number of Bedrooms"></asp:Label>
        <asp:Label ID="lblNumofBathrooms" runat="server" style="z-index: 1; left: 1109px; top: 152px; position: absolute" Text="Number of Bathrooms"></asp:Label>
        <asp:Label ID="lblHouseYear" runat="server" style="z-index: 1; left: 2px; top: 345px; position: absolute" Text="Year house was built"></asp:Label>
        <asp:Label ID="lblUtilities" runat="server" style="z-index: 1; left: 283px; top: 343px; position: absolute" Text="Utilities "></asp:Label>
        <asp:Label ID="lblGarage" runat="server" style="z-index: 1; left: 424px; top: 329px; position: absolute; width: 260px; height: 51px" Text="Does the house have a Garage?"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 731px; top: 341px; position: absolute; right: 703px" Text="Price"></asp:Label>
        <asp:Label ID="lblImages" runat="server" style="z-index: 1; left: 949px; top: 349px; position: absolute; height: 27px" Text="Images"></asp:Label>
        <asp:Label ID="lblHouseDescription" runat="server" style="z-index: 1; left: 1127px; top: 348px; position: absolute" Text="House Description"></asp:Label>
        <asp:Button ID="btnPutHouseForSale" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 494px; top: 497px; position: absolute; height: 36px; width: 260px;" Text="Put House for Sale" />
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
        <ajaxToolkit:ComboBox ID="ComboBox1" runat="server" DropDownStyle="DropDownList" style="z-index: 1; left: 10px; top: 58px; position: absolute">
            <asp:ListItem>Alabama</asp:ListItem>
            <asp:ListItem>Alaska</asp:ListItem>
            <asp:ListItem>Arizona</asp:ListItem>
            <asp:ListItem>Arkansas</asp:ListItem>
            <asp:ListItem>California</asp:ListItem>
            <asp:ListItem>Colorado</asp:ListItem>
            <asp:ListItem>Connecticut</asp:ListItem>
            <asp:ListItem>Delaware</asp:ListItem>
            <asp:ListItem>Florida</asp:ListItem>
            <asp:ListItem>Georgia</asp:ListItem>
            <asp:ListItem>Hawaii</asp:ListItem>
            <asp:ListItem>Idaho</asp:ListItem>
            <asp:ListItem>Illinois</asp:ListItem>
            <asp:ListItem>Indiana</asp:ListItem>
            <asp:ListItem>Iowa</asp:ListItem>
            <asp:ListItem>Kansas</asp:ListItem>
            <asp:ListItem>Kentucky</asp:ListItem>
            <asp:ListItem>Louisiana</asp:ListItem>
            <asp:ListItem>Maine</asp:ListItem>
            <asp:ListItem>Maryland</asp:ListItem>
            <asp:ListItem>Massachusetts</asp:ListItem>
            <asp:ListItem>Michigan</asp:ListItem>
            <asp:ListItem>Minnesota</asp:ListItem>
            <asp:ListItem>Mississippi</asp:ListItem>
            <asp:ListItem>Missouri</asp:ListItem>
            <asp:ListItem>Montana</asp:ListItem>
            <asp:ListItem>Nebraska</asp:ListItem>
            <asp:ListItem>Nevada</asp:ListItem>
            <asp:ListItem>New Hampshire</asp:ListItem>
            <asp:ListItem>New Jersey</asp:ListItem>
            <asp:ListItem>New Mexico</asp:ListItem>
            <asp:ListItem>New York</asp:ListItem>
            <asp:ListItem>North Carolina</asp:ListItem>
            <asp:ListItem>North Dakota</asp:ListItem>
            <asp:ListItem>Ohio</asp:ListItem>
            <asp:ListItem>Oklahoma</asp:ListItem>
            <asp:ListItem>Oregon</asp:ListItem>
            <asp:ListItem>Pennslyvania</asp:ListItem>
            <asp:ListItem>Rhode Island</asp:ListItem>
            <asp:ListItem>South Carolina</asp:ListItem>
            <asp:ListItem>South Dakota</asp:ListItem>
            <asp:ListItem>Tennessee</asp:ListItem>
            <asp:ListItem>Texas</asp:ListItem>
            <asp:ListItem>Utah</asp:ListItem>
            <asp:ListItem>Vermont</asp:ListItem>
            <asp:ListItem>Virginia</asp:ListItem>
            <asp:ListItem>Washington</asp:ListItem>
            <asp:ListItem>West Virginia</asp:ListItem>
            <asp:ListItem>Wisconsin</asp:ListItem>
            <asp:ListItem>Wyoming</asp:ListItem>
        </ajaxToolkit:ComboBox>
    
        </div>
    
    </form>
</body>
</html>
