<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignupPage.aspx.cs" Inherits="RealEstateTermProject.SignupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
       body{
         
           background-color:#2b2e5b;
       }

       .LoginBox{
           width:557px;
           height:712px;
            z-index: 1;
            left: 743px;
            top: -2px;
            position: absolute;
           /* background-color:grey;*/
        }
        .BackgroundScreen {
            height: 610px;
            width: 741px;
            margin-top: 0px;
        }

        

       
          #form1 {
              width: 1331px;
          }

        

       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
   <div class ="BackgroundScreen">

            <asp:Image ID="Image3" runat="server" Height="701px" ImageUrl="~/pics/loginPageHouseTermProject.jpg" Width="731px" style="margin-top: 0px" />

        </div>
        <div class ="LoginBox">
        
            <asp:Image ID="Image1" ImageUrl ="~/pics/emailforProject-removebg-preview.png"  runat="server" style="z-index: 1; left: 19px; top: 309px; position: absolute; height: 38px; width: 33px; bottom: 365px;" />
            <asp:Panel ID="Panel1" runat="server" BackColor="#999999" ForeColor="#999999" style="z-index: 1; left: 17px; top: 347px; position: absolute; height: 1px; width: 384px">
            </asp:Panel>
        <asp:Label ID="lblPassword" runat="server" ForeColor="Lime" style="z-index: 1; left: 16px; top: 210px; position: absolute" Text="Password:"></asp:Label>
        
            <asp:Image ID="Image2" ImageUrl ="~/pics/loginUsernameTermProject.png"  runat="server" style="z-index: 1; left: 22px; top: 166px; position: absolute; height: 38px; width: 33px; right: 540px;" />
            <asp:Panel ID="Panel2" runat="server" BackColor="#999999" ForeColor="#999999" style="z-index: 1; left: 21px; top: 208px; position: absolute; height: 1px; width: 384px">
            </asp:Panel>
            <asp:Button ID="btnSignUp" runat="server" BackColor="Lime" style="z-index: 1; left: 73px; top: 664px; position: absolute; width: 379px" Text="Sign Up" OnClick="btnSignUp_Click" />
            <asp:Label ID="Label1" runat="server" ForeColor="Lime" style="z-index: 1; left: 182px; top: 512px; position: absolute" Text="Account Type:"></asp:Label>
            <asp:HyperLink ID="hyperlinkLogIn" runat="server" NavigateUrl="~/LoginPage.aspx" style="z-index: 1; left: 438px; top: 108px; position: absolute" Font-Bold="True" Font-Italic="True" ForeColor="Lime">Log In</asp:HyperLink>
            <asp:Label ID="Label2" runat="server" Font-Size="Smaller" ForeColor="Lime" style="z-index: 1; left: 280px; top: 112px; position: absolute; width: 155px" Text="Already have an account?"></asp:Label>
            <asp:TextBox ID="txtCreatePassword" runat="server" BorderStyle="None" ForeColor="Black" placeholder="Create Password" style="z-index: 1; left: 59px; top: 246px; position: absolute; width: 323px"></asp:TextBox>
            <asp:TextBox ID="txtCreateUsername" runat="server" BorderStyle="None" ForeColor="Black" placeholder="Create Username" style="z-index: 1; left: 60px; top: 176px; position: absolute; width: 323px"></asp:TextBox>
            <asp:RadioButton ID="radiobtnHomeSeller" GroupName ="AccountType" runat="server" ForeColor="Lime" style="z-index: 1; left: 179px; top: 544px; position: absolute" Text="Home Seller" />
            <asp:RadioButton ID="radiobtnHomeBuyer" GroupName ="AccountType" runat="server" ForeColor="Lime" style="z-index: 1; left: 179px; top: 574px; position: absolute" Text="Home Buyer" />
            <asp:TextBox ID="txtEmail" runat="server" ForeColor="Black" placeholder="Email" style="z-index: 1; left: 56px; top: 313px; position: absolute; width: 323px"></asp:TextBox>
        
            <asp:Image ID="Image4" ImageUrl ="~/pics/passwordTermProject.png"  runat="server" style="z-index: 1; left: 20px; top: 234px; position: absolute; height: 38px; width: 33px; bottom: 440px;" />
            <asp:Panel ID="Panel3" runat="server" BackColor="#999999" ForeColor="#999999" style="z-index: 1; left: 17px; top: 277px; position: absolute; height: 1px; width: 384px">
            </asp:Panel>
        
        
            <asp:Label ID="lblseucrityquestion3question" runat="server" ForeColor="Lime" style="z-index: 1; left: 21px; top: 474px; position: absolute" Text="What is the name of your best friend?"></asp:Label>
            <asp:TextBox ID="txtSecurityquestion2Answer" runat="server" BorderStyle="None" ForeColor="Silver"  style="z-index: 1; left: 270px; top: 433px; position: absolute; width: 208px"></asp:TextBox>
        
        
            <asp:Label ID="labelSecurityquestion2" runat="server" ForeColor="Lime" style="z-index: 1; left: 162px; top: 355px; position: absolute" Text="Security questions"></asp:Label>
        
        
            <asp:Label ID="lblseucrityquestion1question0" runat="server" ForeColor="Lime" style="z-index: 1; left: 21px; top: 388px; position: absolute" Text="What city were you born in?"></asp:Label>
            <asp:TextBox ID="txtSecurityquestion1Answer" runat="server" BorderStyle="None" ForeColor="Silver"  style="z-index: 1; left: 267px; top: 392px; position: absolute; width: 208px"></asp:TextBox>
        
        
            <asp:Label ID="lblseucrityquestion2question0" runat="server" ForeColor="Lime" style="z-index: 1; left: 22px; top: 432px; position: absolute" Text="What is your mom's middle name?"></asp:Label>
            <asp:TextBox ID="txtSecurityquestion3Answer" runat="server" BorderStyle="None" ForeColor="Silver"  style="z-index: 1; left: 271px; top: 475px; position: absolute; width: 208px"></asp:TextBox>
        </div>
        <asp:Label ID="loginlabel" runat="server" Font-Bold="True" Font-Size="30" ForeColor="Lime" style="z-index: 1; left: 766px; top: 14px; position: absolute; width: 500px; height: 88px;" Text="Welcome to Willow"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" ForeColor="Lime" style="z-index: 1; left: 764px; top: 137px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" ForeColor="Lime" style="z-index: 1; left: 756px; top: 284px; position: absolute" Text="Email:"></asp:Label>
        <asp:RadioButton ID="radiobtnRealEstateAgent" GroupName ="AccountType" runat="server" ForeColor="Lime" style="z-index: 1; left: 924px; top: 602px; position: absolute; width: 171px;" Text="Real Estate Agent" />
    </form>
</body>
</html>
