<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowRealEstatesCompany.aspx.cs" Inherits="RealEstateTermProject.ShowRealEstatesCompany" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/nav.js"></script>
    <title></title>
</head>
<body>
     <script>nav()</script>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvShowRealEstate" runat="server" AutoGenerateColumns="False"  style="z-index: 1; left: 157px; top: 236px; position: absolute; height: 111px; width: 289px" OnSelectedIndexChanged="gvShowRealEstate_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Real Estate Agent" />
                    <asp:TemplateField HeaderText="View Company Info">
                        <ItemTemplate>
                            <asp:Button ID="Veiw" runat="server" OnClick="ViewButton" Text="View" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblcomapnyinfo" runat="server" style="z-index: 1; left: 949px; top: 90px; position: absolute" Text="Company Information"></asp:Label>
            <asp:Label ID="lblAgentName" runat="server" style="z-index: 1; left: 939px; top: 241px; position: absolute" Text="Agent Name:"></asp:Label>
            <asp:Label ID="lblComapnyName" runat="server" style="z-index: 1; left: 939px; top: 369px; position: absolute" Text="Comapny Name:"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 940px; top: 469px; position: absolute" Text="Phone Number:"></asp:Label>
        </div>
    </form>
</body>
</html>
