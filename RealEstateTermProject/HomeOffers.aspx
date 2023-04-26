<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeOffers.aspx.cs" Inherits="RealEstateTermProject.HomeOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="js/navHomeSeller.js"></script>
      <link href="styles/LandingPage.css" rel="stylesheet" />
</head>
<body>
    <script>navHomeSeller()</script>
    <content>
            <img src="https://images.unsplash.com/photo-1600596542815-ffad4c1539a9?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8Nnx8fGVufDB8fHx8&w=1000&q=80" />
        </content>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gvHomeOffers" runat="server" style="z-index: 1; left: 385px; top: 250px; position: absolute; height: 133px; width: 187px" BackColor="White">
            <Columns>
                <asp:TemplateField HeaderText="Accept Offer">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkbtnAccept" runat="server" OnClick="linkbtnAccept_Click1">Accept</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Deny Offer">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkbtnDeny" runat="server" OnClick="linkbtnDeny_Click2">Deny</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="75" ForeColor="RoyalBlue" style="z-index: 1; left: 359px; top: 62px; position: absolute" Text="Home Offers"></asp:Label>
    </form>
</body>
</html>
