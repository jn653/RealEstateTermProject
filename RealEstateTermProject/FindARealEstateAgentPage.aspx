<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindARealEstateAgentPage.aspx.cs" Inherits="RealEstateTermProject.FindARealEstateAgentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/navHomeSeller.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <script>navHomeSeller()</script>
        <div>
        </div>
        <table style="z-index: 1; left: 189px; top: 84px; position: absolute; height: 104px; width: 433px; right: 824px">
            <tr style="color:darkorchid">
                <th> Real Estate Agent</th>
            </tr>
             <asp:Repeater ID="RealEstateAgentReapeater" runat="server">
                 <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblAgentUsername" runat="server"
                            Text='<%# DataBinder.Eval(Container.DataItem, "RealEstateAgentUsername") %>'></asp:Label>
                    </td>
                </tr>
                     </ItemTemplate>
        </asp:Repeater>
        </table>
    </form>
</body>
</html>
