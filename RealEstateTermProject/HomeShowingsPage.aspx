<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeShowingsPage.aspx.cs" Inherits="RealEstateTermProject.HomeShowingsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/navHomeSeller.js"></script>
</head>
<body>
     <script>navHomeSeller()</script>
    <form id="form1" runat="server">
        <div>
        </div>
         <table style="z-index: 1; left: 298px; top: 186px; position: absolute; height: 340px; width: 460px; right: 232px">
            <tr style="color:darkorchid">
                <th> Visitor </th>
                <th> Date </th>
                <th> Time </th>
                
            </tr>
             <asp:Repeater ID="HouseVisitsRepeater" runat="server">
                 <ItemTemplate>
                <tr>
                    <td width ="25px" align ="center">
                        <asp:Label ID="lblVisitorUsername" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitorUsername") %>'></asp:Label>
                    </td>
                     <td width ="25px" align ="center">
                        <asp:Label ID="LblVisitingDate" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitDate") %>'></asp:Label>
                    </td>

                     <td width ="25px" align ="center">
                        <asp:Label ID="LblVisitingTime" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitTime") %>'></asp:Label>
                    </td>
                </tr>
                     </ItemTemplate>
        </asp:Repeater>
        </table>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="80px" ForeColor="RoyalBlue" style="z-index: 1; left: 246px; top: 120px; position: absolute" Text="Scheduled Visits"></asp:Label>
    </form>
</body>
</html>
