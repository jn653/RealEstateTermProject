<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestedSellings.aspx.cs" Inherits="RealEstateTermProject.RequestedSellings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <script src="js/navHomeSeller.js"></script>

</head>
<body>

    <form id="form1" runat="server">




        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 72px; top: 287px; position: absolute" Text="State"></asp:Label>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 212px; top: 284px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 339px; top: 282px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblbathrooms" runat="server" style="z-index: 1; left: 487px; top: 280px; position: absolute" Text="Bathrooms"></asp:Label>
        <asp:Label ID="lblPropertyType" runat="server" style="z-index: 1; left: 985px; top: 276px; position: absolute" Text="Property Type"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; top: 325px; position: absolute; width: 109px; left: 330px"></asp:TextBox>
        <asp:Label ID="lblbedrooms" runat="server" style="z-index: 1; left: 672px; top: 280px; position: absolute" Text="Bedrooms"></asp:Label>




        <asp:GridView ID="gvRequestors" runat="server" style="z-index: 1; left: 20px; top: 550px; position: absolute; height: 180px; width: 100px" AutoGenerateColumns="False" OnRowCommand ="gvRequestors_RowCommand">
            <Columns>
                 <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="NumberOfBathrooms" HeaderText="Bathrooms" SortExpression="NumberofBathrooms" />
                <asp:BoundField DataField="NumberofBedrooms" HeaderText="BedRooms" SortExpression="NumberofBedrooms" />
                  <asp:BoundField DataField="HouseYear" HeaderText="Year" SortExpression="HouseYear" />
                <asp:BoundField DataField="PropertyType" HeaderText="PropertyType" SortExpression="PropertyType" />
                 <asp:BoundField DataField="Utilities" HeaderText="Utilities" SortExpression="Utilities" />
                 <asp:BoundField DataField="Amentities" HeaderText="Amentities" SortExpression="Amentities" />
                <asp:BoundField DataField="Garage" HeaderText="Garage" SortExpression="Garage" />
                <asp:BoundField DataField="AskingPrice" HeaderText="Price" SortExpression="AskingPrice" />
               <asp:ImageField DataImageUrlField="HouseImages" HeaderText="HouseImages" ControlStyle-Height ="60px" >
                </asp:ImageField>
                <asp:BoundField DataField="HomeDescription" HeaderText="Description" SortExpression="HouseDescription" />
                 <asp:BoundField DataField="HomeSize" HeaderText="HomeSize" SortExpression="HomeSize" />
                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Address" />     
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select" ShowHeader="True" Text="Select" />
            </Columns>
        </asp:GridView>



         <asp:Button ID="btnSellhouse" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 1155px; top: 403px; position: absolute; height: 41px; width: 141px" Text="Sell House" OnClick="btnSellhouse_Click" />



         <script>navHomeSeller()</script>

        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="55pt" ForeColor="RoyalBlue" style="z-index: 1; left: 277px; top: 64px; position: absolute" Text="Users requesting to sell"></asp:Label>
            <asp:Label ID="lblTestingpage" runat="server" style="z-index: 1; left: 75px; top: 204px; position: absolute" Text="Label"></asp:Label>
            <asp:TextBox ID="txtUtilities" runat="server" style="z-index: 1; left: 46px; top: 430px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtHouseYear" runat="server" style="z-index: 1; top: 320px; position: absolute; width: 109px; left: 837px"></asp:TextBox>
            <asp:TextBox ID="txtBathrooms" runat="server" style="z-index: 1; top: 323px; position: absolute; width: 109px; left: 480px"></asp:TextBox>
            <asp:TextBox ID="txtBedrooms" runat="server" style="z-index: 1; top: 320px; position: absolute; width: 109px; left: 655px"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; top: 326px; position: absolute; width: 109px; left: 185px"></asp:TextBox>
            <asp:TextBox ID="txtProperty" runat="server" style="z-index: 1; top: 316px; position: absolute; width: 109px; left: 992px"></asp:TextBox>
            <asp:Label ID="lblHouseYear0" runat="server" style="z-index: 1; left: 845px; top: 276px; position: absolute" Text="House Year"></asp:Label>
            <asp:Label ID="lblAmentities" runat="server" style="z-index: 1; left: 205px; top: 389px; position: absolute" Text="Amentities"></asp:Label>
            <asp:TextBox ID="txtState" runat="server" style="z-index: 1; left: 46px; top: 329px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtAmentities" runat="server" style="z-index: 1; left: 193px; top: 429px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtGarage" runat="server" style="z-index: 1; left: 351px; top: 427px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 523px; top: 427px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtImages" runat="server" style="z-index: 1; left: 688px; top: 424px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 843px; top: 422px; position: absolute; width: 109px"></asp:TextBox>
            <asp:Label ID="lblImages" runat="server" style="z-index: 1; left: 688px; top: 388px; position: absolute" Text="Images"></asp:Label>
            <asp:Label ID="lblGarage" runat="server" style="z-index: 1; left: 362px; top: 384px; position: absolute" Text="Garage"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 537px; top: 387px; position: absolute" Text="Price"></asp:Label>
            <asp:Label ID="lblUtilities3" runat="server" style="z-index: 1; left: 56px; top: 390px; position: absolute" Text="Utilities"></asp:Label>
            <asp:Label ID="lblHouseDescription" runat="server" style="z-index: 1; left: 1002px; top: 384px; position: absolute" Text="House Size"></asp:Label>
            <asp:Label ID="lblHouseDescription0" runat="server" style="z-index: 1; left: 827px; top: 384px; position: absolute" Text="House Description"></asp:Label>
            <asp:TextBox ID="txtHomeSize" runat="server" style="z-index: 1; left: 990px; top: 418px; position: absolute; width: 109px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
