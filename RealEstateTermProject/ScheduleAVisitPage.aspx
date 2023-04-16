<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleAVisitPage.aspx.cs" Inherits="RealEstateTermProject.ScheduleAVisitPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/nav.js"></script>
</head>
<body>
     <script>nav()</script>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblScheduleAvisit" runat="server" Font-Bold="True" Font-Size="110px" ForeColor="RoyalBlue" style="z-index: 1; left: 152px; top: 45px; position: absolute" Text="Schedule  A Visit"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 456px; top: 286px; position: absolute; height: 22px; width: 193px;" TextMode="Date"></asp:TextBox>
            <asp:TextBox ID="txtTime" runat="server" style="z-index: 1; left: 456px; top: 367px; position: absolute; height: 23px; width: 191px" TextMode="Time"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="RoyalBlue" style="z-index: 1; left: 464px; top: 255px; position: absolute" Text="Date:"></asp:Label>
            <asp:Button ID="Button1" runat="server" BackColor="RoyalBlue" Font-Size="Large" ForeColor="White" OnClick="Button1_Click" style="z-index: 1; left: 486px; top: 426px; position: absolute; height: 32px; width: 147px" Text="Submit Visit" />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="RoyalBlue" style="z-index: 1; left: 463px; top: 333px; position: absolute" Text="Time:"></asp:Label>
        </div>
    </form>
</body>
</html>
