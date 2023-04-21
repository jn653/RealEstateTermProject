<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRealEstateInfoPage.aspx.cs" Inherits="RealEstateTermProject.AddRealEstateInfoPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
          body{
         
           background-color:#2b2e5b;
       }
        .actionBox {
            border-style: solid;
            border-color: inherit;
            border-width: 10px;
            z-index: 1;
            left: 795px;
            top: 3px;
            position: absolute;
            height: 663px;
            width: 445px;
            background-color: #2b2e5b;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <div class ="actionBox">
            <asp:Button ID="btnLogin" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnLogin_Click" style="z-index: 1; left: 116px; top: 547px; position: absolute; width: 140px" Text="Login" />
        </div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="50pt" ForeColor="Lime" style="z-index: 1; left: 862px; top: 56px; position: absolute" Text="Willow"></asp:Label>
        <asp:Label ID="companynamelbl" runat="server" ForeColor="RoyalBlue" style="z-index: 1; left: 818px; top: 274px; position: absolute" Text="Company Name:"></asp:Label>
        <asp:TextBox ID="txtboxCompanyName" runat="server" style="z-index: 1; left: 1002px; top: 276px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtboxPhoneNumber" runat="server" style="z-index: 1; left: 1003px; top: 340px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtboxAgentName" runat="server" style="z-index: 1; left: 1004px; top: 407px; position: absolute"></asp:TextBox>
      <div class ="BackgroundScreen">
            

            <asp:Image ID="Image3" runat="server" Height="672px" ImageUrl="~/pics/loginPageHouseTermProject.jpg" Width="778px" />

            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="RoyalBlue" style="z-index: 1; left: 812px; top: 207px; position: absolute" Text="Enter your real estate company information"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="RoyalBlue" style="z-index: 1; left: 818px; top: 338px; position: absolute" Text="Phone Number:"></asp:Label>
            <asp:Label ID="Label3" runat="server" ForeColor="RoyalBlue" style="z-index: 1; left: 835px; top: 406px; position: absolute" Text="Agent Name:"></asp:Label>
            <asp:Button ID="btnSubmitINfo" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="Button1_Click" style="z-index: 1; left: 931px; top: 509px; position: absolute" Text="Submit Info" />
            <asp:Button ID="btnCheckInfo" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="Button1_Click1" style="z-index: 1; left: 929px; top: 489px; position: absolute" Text="Check Info" />
            <asp:Label ID="lblDisplay" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="RoyalBlue" style="z-index: 1; left: 837px; top: 206px; position: absolute" Text="Label"></asp:Label>

        </div>
        <div class ="LoginBox">
        
        </div>
        </form>
</body>
</html>
