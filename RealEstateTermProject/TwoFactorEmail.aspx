<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TwoFactorEmail.aspx.cs" Inherits="RealEstateTermProject.TwoFactorEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
       body{
         
           background-color:#2b2e5b;
       }

       .LoginBox{
           width:426px;
           height:650px;
            z-index: 1;
            left: 790px;
            top: 45px;
            position: absolute;
           /* background-color:grey;*/
        }
        .BackgroundScreen {
            height: 610px;
            width: 777px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblinstructions1" runat="server" Font-Size="Small" ForeColor="RoyalBlue" style="z-index: 1; left: 813px; top: 168px; position: absolute; width: 589px" Text="A six digit code was sent to your email for verification."></asp:Label>
            <asp:TextBox ID="txtSixDigit" runat="server" style="z-index: 1; left: 931px; top: 284px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" BackColor="RoyalBlue" ForeColor="White" OnClick="btnSubmit_Click" style="z-index: 1; left: 982px; top: 387px; position: absolute" Text="Submit" />
            <asp:Label ID="lblinstructions2" runat="server" Font-Size="Small" ForeColor="RoyalBlue" style="z-index: 1; left: 811px; top: 215px; position: absolute" Text="Enter the six digit number to log into your account"></asp:Label>
            <asp:HyperLink ID="hyperlinkReturntoLogin" runat="server" ForeColor="Lime" NavigateUrl="~/LoginPage.aspx" style="z-index: 1; left: 82px; top: 52px; position: absolute">Return to Log In</asp:HyperLink>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/pics/leftarrowimage-removebg-preview.png" style="z-index: 1; left: 28px; top: 56px; position: absolute; height: 20px; width: 28px" />
        </div>
          <div class ="BackgroundScreen">

            <asp:Image ID="Image3" runat="server" Height="672px" ImageUrl="~/pics/loginPageHouseTermProject.jpg" Width="778px" />

        </div>
        <asp:Label ID="loginlabel" runat="server" Font-Bold="True" Font-Size="40pt" ForeColor="RoyalBlue" style="z-index: 1; left: 906px; top: 47px; position: absolute; width: 500px; height: 174px;" Text="Willow"></asp:Label>

    </form>
</body>
</html>
