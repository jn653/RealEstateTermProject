<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyHomesPage.aspx.cs" Inherits="RealEstateTermProject.MyHomesPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/navHomeSeller.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvMyHomes" runat="server" style="z-index: 1; left: 30px; top: 391px; position: absolute; height: 180px; width: 289px" AutoGenerateColumns="False" OnRowDeletingCommand ="gvMyHomes_RowCommand" OnSelectedIndexChanged="gvMyHomes_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Address" />
                <asp:BoundField DataField="HouseImages" HeaderText="Images" SortExpression="HouseImages" />
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
            </Columns>
        </asp:GridView>
        <asp:GridView ID="gvHouseFeedback" runat="server" style="z-index: 1; left: 587px; top: 392px; position: absolute; height: 180px; width: 289px">
        </asp:GridView>
        <asp:Label ID="lblMyHomes" runat="server" Font-Bold="True" Font-Size="65" ForeColor="RoyalBlue" style="z-index: 1; left: 367px; top: 99px; position: absolute" Text="My Homes"></asp:Label>
    <script>navHomeSeller()</script>
        <div>
        </div>
    </form>
</body>
</html>
