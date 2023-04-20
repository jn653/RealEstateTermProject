<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellingPage.aspx.cs" Inherits="RealEstateTermProject.SellingPage" %>

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
                
                    <label for="address">Address</label>
                    <input id="address" runat="server"/>
                    <label for="propertyType">Property Type</label>
                    <input id="propertyType" runat="server"/>
                    <label for="homeSize">Home Size</label>
                    <input id="homeSize" runat="server"/>
                    <label for="numOfBed">Number of Bedrooms</label>
                    <input id="numOfBed" runat="server"/>
                    <label for="amenities">Amenities</label>
                    <input id="amenities" runat="server"/>
                    <label for="houseYear">House Year</label>
                    <input id="houseYear" runat="server"/>
                    <label for="garage">Garage</label>
                    <input id="garage" runat="server"/>
                    <label for="utilities">Utilities</label>
                    <input id="utilities" runat="server"/>
                    <label for="homeDescription">Home Description</label>
                    <input id="homeDescription" runat="server"/>
                    <label for="askingPrice">Asking Price</label>
                    <input id="askingPrice" runat="server"/>
                    <label for="houseImages">House Images</label>
                    <input id="houseImages" runat="server"/>
                    <label for="state">State</label>
                    <input id="state" runat="server"/>
                    <label for="numOfBath">Number of Bathrooms</label>
                    <input id="numOfBath" runat="server"/>
                    <label for="city">City<asp:Button ID="sell0" Text="Sell House" OnClick="Button1_Click" runat="server" />
            </label>
                    &nbsp;<input id="city" runat="server"/>
                <asp:Button ID="sell" Text="Sell House" OnClick="Button1_Click" runat="server" />

                <asp:Button ID="Button1" Text="Sell House" OnClick="Button1_Click" runat="server" />

            </sellinginfo>

    </form>

</body>
</html>
