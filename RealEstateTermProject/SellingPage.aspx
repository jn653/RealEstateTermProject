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
            
            <asp:UpdatePanel ID="upImages" CssClass="updatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <label for="FileUpload1" id="fileUploadLabel1" runat="server" class="fileUpload">Upload Image<input id="imageCaption1" runat="server"/></label>
                    <label for="FileUpload2" id="fileUploadLabel2" runat="server" class="fileUpload">Upload Image<input id="imageCaption2" runat="server"/></label>
                    <label for="FileUpload3" id="fileUploadLabel3" runat="server" class="fileUpload">Upload Image<input id="imageCaption3" runat="server"/></label>
                    <label for="FileUpload4" id="fileUploadLabel4" runat="server" class="fileUpload">Upload Image<input id="imageCaption4" runat="server"/></label>
                    <label for="FileUpload5" id="fileUploadLabel5" runat="server" class="fileUpload">Upload Image<input id="imageCaption5" runat="server"/></label>
                    <label for="FileUpload6" id="fileUploadLabel6" runat="server" class="fileUpload">Upload Image<input id="imageCaption6" runat="server"/></label>
                    <label for="FileUpload7" id="fileUploadLabel7" runat="server" class="fileUpload">Upload Image<input id="imageCaption7" runat="server"/></label>
                    <label for="FileUpload8" id="fileUploadLabel8" runat="server" class="fileUpload">Upload Image<input id="imageCaption8" runat="server"/></label>
                    <label for="FileUpload9" id="fileUploadLabel9" runat="server" class="fileUpload">Upload Image<input id="imageCaption9" runat="server"/></label>
                    <label for="FileUpload10" id="fileUploadLabel10" runat="server" class="fileUpload">Upload Image<input id="imageCaption10" runat="server"/></label>
                    <label for="FileUpload11" id="fileUploadLabel11" runat="server" class="fileUpload">Upload Image<input id="imageCaption11" runat="server"/></label>
                    <label for="FileUpload12" id="fileUploadLabel12" runat="server" class="fileUpload">Upload Image<input id="imageCaption12" runat="server"/></label>
                    <label for="FileUpload13" id="fileUploadLabel13" runat="server" class="fileUpload">Upload Image<input id="imageCaption13" runat="server"/></label>
                    <label for="FileUpload14" id="fileUploadLabel14" runat="server" class="fileUpload">Upload Image<input id="imageCaption14" runat="server"/></label>
                    <label for="FileUpload15" id="fileUploadLabel15" runat="server" class="fileUpload">Upload Image<input id="imageCaption15" runat="server"/></label>
                    <label for="FileUpload16" id="fileUploadLabel16" runat="server" class="fileUpload">Upload Image<input id="imageCaption16" runat="server"/></label>
                    <label for="FileUpload17" id="fileUploadLabel17" runat="server" class="fileUpload">Upload Image<input id="imageCaption17" runat="server"/></label>
                    <label for="FileUpload18" id="fileUploadLabel18" runat="server" class="fileUpload">Upload Image<input id="imageCaption18" runat="server"/></label>
                    <label for="FileUpload19" id="fileUploadLabel19" runat="server" class="fileUpload">Upload Image<input id="imageCaption19" runat="server"/></label>
                    <label for="FileUpload20" id="fileUploadLabel20" runat="server" class="fileUpload">Upload Image<input id="imageCaption20" runat="server"/></label>
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
            <asp:Button ID="addImage" Text="Add Image Button" OnClick="AddFileUpload" runat="server" />
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
