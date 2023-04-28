<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeShowingsPage.aspx.cs" Inherits="RealEstateTermProject.HomeShowingsPage" %>

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
            <img src="https://images.unsplash.com/photo-1568605114967-8130f3a36994?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" />
        </content>
    <form id="form1" runat="server">
        <div>
        </div>
        
         <table style="z-index: 1; left: 361px; top: 186px; position: absolute; height: 340px; width: 460px; right: 169px">
            <tr style="color:darkorchid">
                <th height="10px" style="background-color:white"> Visitor </th>
                <th style="background-color:white"> Address </th>
                <th style="background-color:white"> Date </th>
                <th style="background-color:white"> Time </th>
                
                
            </tr>
             <asp:Repeater ID="HouseVisitsRepeater" runat="server">
                 <ItemTemplate>
                <tr style="background-color:white">
                    <td height="300" width ="25px" align ="center" style="background-color:white">
                        <asp:Label ID="lblVisitorUsername" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitorUsername") %>'></asp:Label>
                    </td>
                     <td width ="25px" align ="center" style="background-color:white">
                        <asp:Label ID="LblHouseAddress" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "HouseAddress") %>'></asp:Label>
                    </td>
                     <td width ="25px" align ="center" style="background-color:white">
                        <asp:Label ID="LblVisitingDate" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitDate") %>'></asp:Label>
                    </td>

                     <td width ="25px" align ="center" style="background-color:white">
                        <asp:Label ID="LblVisitingTime" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "VisitTime") %>'></asp:Label>
                    </td>
                </tr >
                     </ItemTemplate>
        </asp:Repeater>
        </table>
            
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="80px" ForeColor="RoyalBlue" style="z-index: 1; left: 359px; top: 62px; position: absolute" Text="Scheduled Visits"></asp:Label>
    </form>
</body>
</html>
