<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellingPage.aspx.cs" Inherits="RealEstateTermProject.SellingPage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/navHomeSeller.js"></script>
    <link href="styles/SellingPage.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">

        <div class="SellSolobtn">
            <!-- <asp:Button ID="btnSellonOwn" runat="server" BackColor="RoyalBlue" ForeColor="Black" OnClick="Button1_Click" Text="Sell on your own" />-->

        </div>



        <script>navHomeSeller()</script>
        <sellinginfo id="sellingInfo" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <label for="address">Address</label>
            <input id="address" runat="server" />
            <label for="propertyType">Property Type</label>
            <input id="propertyType" runat="server" />
            <label for="homeSize">Home Size</label>
            <input id="homeSize" runat="server" />
            <label for="numOfBed">Number of Bedrooms</label>
            <input id="numOfBed" runat="server" />
            <label for="amenities">Amenities</label>
            <input id="amenities" runat="server" />
            <label for="houseYear">House Year</label>
            <input id="houseYear" runat="server" />
            <label for="garage">Garage</label>
            <input id="garage" runat="server" />
            <label for="utilities">Utilities</label>
            <input id="utilities" runat="server" />
            <label for="homeDescription">Home Description</label>
            <input id="homeDescription" runat="server" />
            <label for="askingPrice">Asking Price</label>
            <input id="askingPrice" runat="server" />
            <label for="houseImages">House Images</label>
            <input id="houseImages" runat="server" />
            <label for="state">State</label>
            <input id="state" runat="server" />
            <label for="numOfBath">Number of Bathrooms</label>
            <input id="numOfBath" runat="server" />
            <label for="city">
                City
            </label>
            <asp:FileUpload ID="image1" runat="server"/>
            <asp:Button ID="sell0" Text="Upload File" OnClick="UploadFile" runat="server" />
            <asp:Button ID="addImage" Text="Add Image Button" OnClick="AddFileUpload" runat="server" />
            <asp:UpdatePanel ID="upImages" CssClass="updatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <label for="FileUpload1" class="fileUpload">swag</label>
                    <label for="FileUpload2" class="fileUpload">swag</label>
                    <label for="FileUpload3" class="fileUpload">swag</label>
                    <label for="FileUpload4" class="fileUpload">swag</label>
                    <label for="FileUpload5" class="fileUpload">swag</label>
                    <label for="FileUpload6" class="fileUpload">swag</label>
                    <label for="FileUpload7" class="fileUpload">swag</label>
                    <label for="FileUpload8" class="fileUpload">swag</label>
                    <label for="FileUpload9" class="fileUpload">swag</label>
                    <label for="FileUpload10" class="fileUpload">swag</label>
                    <label for="FileUpload11" class="fileUpload">swag</label>
                    <label for="FileUpload12" class="fileUpload">swag</label>
                    <label for="FileUpload13" class="fileUpload">swag</label>
                    <label for="FileUpload14" class="fileUpload">swag</label>
                    <label for="FileUpload15" class="fileUpload">swag</label>
                    <label for="FileUpload16" class="fileUpload">swag</label>
                    <label for="FileUpload17" class="fileUpload">swag</label>
                    <label for="FileUpload18" class="fileUpload">swag</label>
                    <label for="FileUpload19" class="fileUpload">swag</label>
                    <label for="FileUpload20" class="fileUpload">swag</label>
                    <asp:FileUpload ID="FileUpload1" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload2" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload3" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload4" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload5" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload6" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload7" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload8" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload9" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload10" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload11" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload12" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload13" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload14" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload15" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload16" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload17" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload18" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload19" CssClass="fileUpload" Visible="false" runat="server"/>
                    <asp:FileUpload ID="FileUpload20" CssClass="fileUpload" Visible="false" runat="server"/>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="addImage" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
             <!--&nbsp;<input id="city" runat="server" />
            <asp:UpdatePanel ID="upControl" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                </ContentTemplate>

            </asp:UpdatePanel>
            <asp:Button ID="btnAddImages" Text="Add Image" OnClick="AddFileUpload" runat="server" />
           <asp:Button ID="sell" Text="Sell House" OnClick="Button1_Click" runat="server" />

            &nbsp;<asp:UpdatePanel ID="upResult" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnAddImages" EventName="Click" />
                </Triggers>
                <ContentTemplate>
                    <asp:Label ID="fart" Text="fatass" runat="server"></asp:Label>
                </ContentTemplate>

            </asp:UpdatePanel>-->


        </sellinginfo>







    </form>

</body>
</html>
