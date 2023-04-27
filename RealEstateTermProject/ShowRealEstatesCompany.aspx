<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowRealEstatesCompany.aspx.cs" Inherits="RealEstateTermProject.ShowRealEstatesCompany" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/navHomeSeller.js"></script>
    <title></title>
</head>
<body>
     <script>navHomeSeller()</script>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvShowRealEstate" runat="server"  style="z-index: 1; left: 261px; top: 354px; position: absolute; height: 111px; width: 289px" OnSelectedIndexChanged="gvShowRealEstate_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Choose an Agent">
                        <ItemTemplate>
                            <asp:CheckBox ID="checkboxChoose" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblAgentChosen" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="RoyalBlue" style="z-index: 1; left: 371px; top: 308px; position: absolute" Text="Label"></asp:Label>
            <asp:Button ID="btnAccept" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnAccept_Click" style="z-index: 1; left: 974px; top: 482px; position: absolute; height: 41px; width: 145px" Text="Accept" />
            <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="RoyalBlue" style="z-index: 1; left: 118px; top: 231px; position: absolute" Text="Instructions: click the checkbox for the agent you want and then click the accept button to choose that agent to sell with"></asp:Label>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size= "85" ForeColor="RoyalBlue" style="z-index: 1; left: 188px; top: 45px; position: absolute" Text="Find An Agent"></asp:Label>
        </div>
    </form>
</body>
</html>
