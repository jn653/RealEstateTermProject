<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordPage.aspx.cs" Inherits="RealEstateTermProject.ForgotPasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
          body{
         
           background-color:#2b2e5b;
       }
        .actionBox {
            z-index: 1;
            left: 310px;
            top: 78px;
            position: absolute;
            height: 577px;
            width: 577px;
            background-color: white;
            border:solid 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/pics/leftarrowimage-removebg-preview.png" style="z-index: 1; left: 20px; top: 37px; position: absolute; height: 20px; width: 28px" />
            <asp:HyperLink ID="hyperlinkReturntoLogin" runat="server" ForeColor="Lime" NavigateUrl="~/LoginPage.aspx" style="z-index: 1; left: 56px; top: 36px; position: absolute">Return to Log In</asp:HyperLink>
        </div>
        
        <div class ="actionBox">
        </div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="50pt" ForeColor="Lime" style="z-index: 1; left: 468px; top: 82px; position: absolute" Text="Willow"></asp:Label>
            <asp:Label ID="lblInstructions" runat="server" ForeColor="Lime" style="z-index: 1; left: 377px; top: 213px; position: absolute" Text="Enter the email address associated with your account"></asp:Label>
            <asp:Label ID="lblquestion" runat="server" ForeColor="Lime" style="z-index: 1; left: 301px; top: 351px; position: absolute" Text="(Make random generator to randomly select security question)"></asp:Label>
        <asp:TextBox ID="txtSecuityQuestionAnswer" runat="server" style="z-index: 1; left: 511px; top: 399px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUsernameandPassword" runat="server" ForeColor="Lime" style="z-index: 1; left: 324px; top: 569px; position: absolute">(this is where the user&#39;s username and password will appear)</asp:Label>
            <asp:TextBox ID="txtEmailForgotPassword" runat="server" style="z-index: 1; left: 506px; top: 338px; position: absolute"></asp:TextBox>
        
        <asp:Label ID="lblEmail" runat="server" ForeColor="Lime" style="z-index: 1; left: 530px; top: 312px; position: absolute" Text="Email:"></asp:Label>
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 528px; top: 443px; position: absolute" Text="Continue" OnClick="btnContinue_Click" />
    </form>
</body>
</html>
