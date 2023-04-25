<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HouseSurveyQuestions.aspx.cs" Inherits="RealEstateTermProject.HouseSurveyQuestions" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/nav.js"></script>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            z-index: 1;
            left: 799px;
            top: 488px;
            position: absolute;
        }
        #textAreaFeedback {
            z-index: 1;
            left: 805px;
            top: 407px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlLocationSafe" runat="server" style="z-index: 1; left: 105px; top: 447px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblHouseRating" runat="server" style="z-index: 1; left: 752px; top: 177px; position: absolute" Text="What rating would you give the house?"></asp:Label>
     <script>nav()</script>
        <div>
            <asp:Label ID="lblHousePrice" runat="server" style="z-index: 1; left: 10px; top: 166px; position: absolute" Text="How reasonable is the price for the house?"></asp:Label>
            <asp:Label ID="lblLocationQuestion" runat="server" style="z-index: 1; left: 9px; top: 410px; position: absolute" Text="On a Scale of 1 to 5, how safe is the location?"></asp:Label>
            <asp:RadioButtonList ID="radiobtnReasonablePrice" runat="server" style="z-index: 1; left: 90px; top: 196px; position: absolute; height: 150px; width: 108px">
                <asp:ListItem>Not very reasonable</asp:ListItem>
                <asp:ListItem>Somewhat reasonable</asp:ListItem>
                <asp:ListItem>Very reasonable</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <asp:DropDownList ID="ddlHouseRating" runat="server" style="z-index: 1; left: 842px; top: 236px; position: absolute">
            <asp:ListItem>1 Star</asp:ListItem>
            <asp:ListItem>2 Stars</asp:ListItem>
            <asp:ListItem>3 Stars</asp:ListItem>
            <asp:ListItem>4 Stars</asp:ListItem>
            <asp:ListItem>5 Stars</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lbladditionalfeedback" runat="server" style="z-index: 1; left: 774px; top: 335px; position: absolute" Text="Any additional feedback you may have:"></asp:Label>
    <p>
        <textarea id="textAreaFeedback" runat="server" cols="20" name="S1" rows="2"></textarea><asp:Button ID="btnSubmit" runat="server" BackColor="RoyalBlue" ForeColor="White" style="z-index: 1; left: 474px; top: 555px; position: absolute; height: 44px; width: 232px" Text="Submit Feedback" OnClick="btnSubmit_Click" />
        <asp:Label ID="lbltitle" runat="server" Font-Bold="True" Font-Size="30" ForeColor="RoyalBlue" style="z-index: 1; left: 118px; top: 77px; position: absolute; height: 174px; width: 655px;" Text="Label"></asp:Label>
        </p>
    </form>
    </body>
</html>
