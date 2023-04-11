<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingHouseInfotoSellPage.aspx.cs" Inherits="RealEstateTermProject.AddingHouseInfotoSellPage" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       
    <title></title>
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
    <form id="form1" runat="server">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 269px; top: 186px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 417px; top: 184px; position: absolute" Text="State"></asp:Label>
        

        <asp:Label ID="lblAdress" runat="server" style="z-index: 1; left: 27px; top: 194px; position: absolute" Text="Address"></asp:Label>
    
        <%--<ajaxToolkit:ComboBox ID="ComboBox1" runat="server" DropDownStyle="DropDownList" style="z-index: 1; left: 10px; top: 58px; position: absolute">
            <asp:ListItem>Philadelphia </asp:ListItem>
        </ajaxToolkit:ComboBox>--%>
        <textarea id="TextAreaHouseDescription" cols="20" name="S1" rows="2"></textarea><asp:TextBox ID="txAddress" runat="server" style="z-index: 1; left: 5px; top: 230px; position: absolute"></asp:TextBox>
    
        <asp:Label ID="lblHomeSize" runat="server" style="z-index: 1; left: 564px; top: 183px; position: absolute" Text="Home Size"></asp:Label>
        <asp:Label ID="lblNumofBedrooms" runat="server" style="z-index: 1; left: 793px; top: 178px; position: absolute" Text="Number of Bedrooms"></asp:Label>
        <asp:Label ID="lblNumofBathrooms" runat="server" style="z-index: 1; left: 1077px; top: 174px; position: absolute" Text="Number of Bathrooms"></asp:Label>
        <asp:Label ID="lblHouseYear" runat="server" style="z-index: 1; left: 2px; top: 345px; position: absolute" Text="Year house was built"></asp:Label>
        <asp:Label ID="lblUtilities" runat="server" style="z-index: 1; left: 283px; top: 343px; position: absolute" Text="Utilities "></asp:Label>
        <asp:Label ID="lblGarage" runat="server" style="z-index: 1; left: 424px; top: 329px; position: absolute; width: 260px; height: 51px" Text="Does the house have a Garage?"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 731px; top: 341px; position: absolute; right: 703px" Text="Price"></asp:Label>
        <asp:Label ID="lblImages" runat="server" style="z-index: 1; left: 949px; top: 349px; position: absolute; height: 27px" Text="Images"></asp:Label>
        <asp:Label ID="lblHouseDescription" runat="server" style="z-index: 1; left: 1127px; top: 348px; position: absolute" Text="House Description"></asp:Label>
        <asp:Button ID="btnPutHouseForSale" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 548px; top: 497px; position: absolute" Text="Put House for Sale" />
        <asp:CheckBoxList ID="CheckBoxListGarage" runat="server" style="z-index: 1; left: 475px; top: 394px; position: absolute; height: 33px; width: 114px">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:CheckBoxList>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 676px; top: 389px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtImage" runat="server" style="z-index: 1; left: 917px; top: 389px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtUtilities" runat="server" style="z-index: 1; left: 226px; top: 384px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtHouseYear" runat="server" style="z-index: 1; left: 6px; top: 382px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtNumofBedrooms" runat="server" style="z-index: 1; left: 796px; top: 214px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtNumofBathrooms" runat="server" style="z-index: 1; left: 1079px; top: 204px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtHomeSize" runat="server" style="z-index: 1; left: 548px; top: 218px; position: absolute"></asp:TextBox>
        </p>
    
    </form>
</body>
</html>
