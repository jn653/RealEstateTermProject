<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RealEstateTermProject.LoginPage" %>

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
        </div>
        <div class ="BackgroundScreen">

            <asp:Image ID="Image3" runat="server" Height="672px" ImageUrl="~/pics/loginPageHouseTermProject.jpg" Width="778px" />

        </div>
        <div class ="LoginBox">
        
            <asp:Image ID="Image1" ImageUrl ="~/pics/passwordTermProject.png"  runat="server" style="z-index: 1; left: 44px; top: 423px; position: absolute; height: 38px; width: 33px; bottom: 143px;" />
            <asp:Panel ID="Panel1" runat="server" BackColor="#999999" ForeColor="#999999" style="z-index: 1; left: 41px; top: 465px; position: absolute; height: 1px; width: 384px">
            </asp:Panel>
        <asp:Label ID="lblPassword" runat="server" ForeColor="RoyalBlue" style="z-index: 1; left: 46px; top: 388px; position: absolute" Text="Password:"></asp:Label>
        
            <asp:Image ID="Image2" ImageUrl ="~/pics/loginUsernameTermProject.png"  runat="server" style="z-index: 1; left: 44px; top: 320px; position: absolute; height: 38px; width: 33px;" />
            <asp:Panel ID="Panel2" runat="server" BackColor="#999999" ForeColor="#999999" style="z-index: 1; left: 40px; top: 368px; position: absolute; height: 1px; width: 384px">
            </asp:Panel>
            <asp:Label ID="Label1" runat="server" Font-Size="Smaller" ForeColor="RoyalBlue" style="z-index: 1; left: 195px; top: 226px; position: absolute; width: 141px" Text="Don't have an account?"></asp:Label>
            <asp:Button ID="btnLogIn" runat="server" BackColor="RoyalBlue" style="z-index: 1; left: 45px; top: 585px; position: absolute; width: 363px" Text="Log In" OnClick="btnLogIn_Click" />
            <asp:HyperLink ID="hyperlinkForgotPassword" runat="server" Font-Italic="True" Font-Size="Small" ForeColor="RoyalBlue" style="z-index: 1; left: 249px; top: 477px; position: absolute; width: 240px" NavigateUrl="~/ForgotPasswordPage.aspx">Forgot Username/Password?</asp:HyperLink>
            <asp:TextBox ID="txtPassword" runat="server" BorderStyle="None" ForeColor="Silver" style="z-index: 1; left: 81px; top: 431px; position: absolute; width: 323px">Password</asp:TextBox>
            <asp:TextBox ID="txtUsername" runat="server" BorderStyle="None" ForeColor="Silver"  style="z-index: 1; left: 82px; top: 332px; position: absolute; width: 323px">Username</asp:TextBox>
            <asp:HyperLink ID="hyperlinkSignUP" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="RoyalBlue" NavigateUrl="~/SignupPage.aspx" style="z-index: 1; left: 338px; top: 219px; position: absolute">SignUp</asp:HyperLink>
        </div>
        <asp:Label ID="loginlabel" runat="server" Font-Bold="True" Font-Size="40pt" ForeColor="RoyalBlue" style="z-index: 1; left: 815px; top: 49px; position: absolute; width: 500px; height: 174px;" Text="Welcome to Willow"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" ForeColor="RoyalBlue" style="z-index: 1; left: 825px; top: 327px; position: absolute" Text="Username:"></asp:Label>
    </form>
</body>
</html>
