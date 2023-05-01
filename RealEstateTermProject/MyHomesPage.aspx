<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyHomesPage.aspx.cs" EnableEventValidation="false" Inherits="RealEstateTermProject.MyHomesPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/navHomeSeller.js"></script>
</head>
<body>
    <script>navHomeSeller()</script>
    <form id="form1" runat="server">
        <asp:GridView ID="gvMyHomes" runat="server" style="z-index: 1; left: 30px; top: 311px; position: absolute; height: 180px; width: 289px" AutoGenerateColumns="False" OnRowDeletingCommand ="gvMyHomes_RowCommand" OnSelectedIndexChanged="gvMyHomes_SelectedIndexChanged" OnRowCommand ="gvMyHomes_RowCommand" >
            <Columns>
                <asp:BoundField DataField="HouseId" HeaderText="ID" SortExpression="Address" />
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
                <asp:TemplateField HeaderText="Update House">
                    <ItemTemplate>
                        <asp:Button Text="Update;" runat="server" OnClick="btnUpdate_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Update House" ShowHeader="True" Text="Update" />
                
            </Columns>
        </asp:GridView>
        <asp:GridView ID="gvHouseFeedback" runat="server" style="z-index: 1; left: 662px; top: 526px; position: absolute; height: 180px; width: 289px">
        </asp:GridView>
        <asp:Label ID="lblConfim" runat="server" style="z-index: 1; left: 375px; top: 247px; position: absolute"></asp:Label>
        <asp:Label ID="lblMyHomes" runat="server" Font-Bold="True" Font-Size="65" ForeColor="RoyalBlue" style="z-index: 1; left: 367px; top: 99px; position: absolute" Text="My Homes"></asp:Label>
    </form>
</body>
</html>
