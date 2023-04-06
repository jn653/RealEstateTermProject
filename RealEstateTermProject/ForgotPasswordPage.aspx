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
            <asp:Image ID="Image1" runat="server" ImageUrl="~/pics/leftarrowimage-removebg-preview.png" style="z-index: 1; left: 20px; top: 37px; position: absolute; height: 20px; width: 28px" />
            <asp:HyperLink ID="hyperlinkReturntoLogin" runat="server" ForeColor="Lime" NavigateUrl="~/LoginPage.aspx" style="z-index: 1; left: 56px; top: 36px; position: absolute">Return to Log In</asp:HyperLink>
        </div>
        
        <div class ="actionBox">
            <asp:Label runat="server" Text="Label" ID="lblquestion" ForeColor="Lime" style="z-index: 1; left: 87px; top: 347px; position: absolute"></asp:Label>
        </div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="50pt" ForeColor="Lime" style="z-index: 1; left: 862px; top: 76px; position: absolute" Text="Willow"></asp:Label>
            <asp:Label ID="lblInstructions" runat="server" ForeColor="Lime" style="z-index: 1; left: 855px; top: 205px; position: absolute; bottom: 449px; width: 289px;" Text="Enter the email address associated with your account"></asp:Label>        <asp:TextBox ID="txtSecuityQuestionAnswer" runat="server" style="z-index: 1; left: 944px; top: 401px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUsernameandPassword" runat="server" ForeColor="Lime" style="z-index: 1; left: 814px; top: 543px; position: absolute; width: 413px;">(this is where the user&#39;s username and password will appear)</asp:Label>
            <asp:Button ID="submitbtn" runat="server" OnClick="submitbtn_Click" style="z-index: 1; left: 956px; top: 474px; position: absolute" Text="Submit Answer" />
            <asp:TextBox ID="txtEmailForgotPassword" runat="server" style="z-index: 1; left: 912px; top: 316px; position: absolute"></asp:TextBox>
        
        <asp:Label ID="lblEmail" runat="server" ForeColor="Lime" style="z-index: 1; left: 968px; top: 281px; position: absolute" Text="Email:"></asp:Label>
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 940px; top: 404px; position: absolute" Text="Continue" OnClick="btnContinue_Click" />
      <div class ="BackgroundScreen">
            

            <asp:Image ID="Image3" runat="server" Height="672px" ImageUrl="~/pics/loginPageHouseTermProject.jpg" Width="778px" />

        </div>
        <div class ="LoginBox">
        
        </div>
        </form>
</body>
</html>
