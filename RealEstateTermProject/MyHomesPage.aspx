<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyHomesPage.aspx.cs" Inherits="RealEstateTermProject.MyHomesPage" %>

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
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 505px; top: 427px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtImages" runat="server" style="z-index: 1; left: 658px; top: 424px; position: absolute; width: 109px"></asp:TextBox>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 810px; top: 422px; position: absolute; width: 109px"></asp:TextBox>
            <asp:Label ID="lblImages" runat="server" style="z-index: 1; left: 671px; top: 388px; position: absolute" Text="Images"></asp:Label>
            <asp:Label ID="lblGarage" runat="server" style="z-index: 1; left: 362px; top: 384px; position: absolute" Text="Garage"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 527px; top: 387px; position: absolute" Text="Price"></asp:Label>
            <asp:Label ID="lblUtilities3" runat="server" style="z-index: 1; left: 56px; top: 390px; position: absolute" Text="Utilities"></asp:Label>
            <asp:Label ID="lblHouseDescription" runat="server" style="z-index: 1; left: 982px; top: 384px; position: absolute" Text="House Size"></asp:Label>
            <asp:Button ID="btnUpdate" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 1141px; top: 407px; position: absolute" Text="Update House" OnClick="btnUpdate_Click" />
            <asp:Label ID="lblHouseDescription0" runat="server" style="z-index: 1; left: 792px; top: 384px; position: absolute" Text="House Description"></asp:Label>
            <asp:TextBox ID="txtHomeSize" runat="server" style="z-index: 1; left: 977px; top: 418px; position: absolute; width: 109px"></asp:TextBox>
        <asp:GridView ID="gvMyHomes" runat="server" style="z-index: 1; left: 30px; top: 508px; position: absolute; height: 180px; width: 289px" AutoGenerateColumns="False" OnRowDeletingCommand ="gvMyHomes_RowCommand" OnSelectedIndexChanged="gvMyHomes_SelectedIndexChanged" OnRowCommand ="gvMyHomes_RowCommand" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Address" />
                <asp:ImageField DataImageUrlField="HouseImages" HeaderText="HouseImages" ControlStyle-Height ="60px" >
<ControlStyle Height="60px"></ControlStyle>
                </asp:ImageField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:TemplateField HeaderText ="Delete House">
                    <ItemTemplate>
                        
                        <asp:LinkButton ID="btnLinkDelete" runat="server" OnClick="btnLinkDelete_Click1">Delete</asp:LinkButton>
                        
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="View feedback">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkbtnView" runat="server" OnClick="linkbtnView_Click2">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Update House" ShowHeader="True" Text="Update" />
                
            </Columns>
        </asp:GridView>
        <asp:GridView ID="gvHouseFeedback" runat="server" style="z-index: 1; left: 662px; top: 526px; position: absolute; height: 180px; width: 289px">
        </asp:GridView>
        <asp:Label ID="lblConfim" runat="server" style="z-index: 1; left: 375px; top: 247px; position: absolute"></asp:Label>
        <asp:Label ID="lblMyHomes" runat="server" Font-Bold="True" Font-Size="65" ForeColor="RoyalBlue" style="z-index: 1; left: 367px; top: 99px; position: absolute" Text="My Homes"></asp:Label>
    <script>navHomeSeller()</script>
        <div>
        </div>
    </form>
</body>
</html>
