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
                <sellinginfobox>
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
                </sellinginfobox>
                <sellinginfobox>
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
                </sellinginfobox>
                <sellinginfobox>
                    <label for="houseImages">House Images</label>
                    <input id="houseImages" runat="server" />
                    <label for="state">State</label>
                    <input id="state" runat="server" />
                    <label for="numOfBath">Number of Bathrooms</label>
                    <input id="numOfBath" runat="server" />
                    <label for="city">City</label>
                    <input id="city" runat="server" />
                </sellinginfobox>
                <sellinginfobox style="overflow:scroll; padding:0rem;">
                    <asp:UpdatePanel ID="upImages" CssClass="updatePanel" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <contentbox id="contentBox" runat="server">
                                <asp:Button Text="Upload File" OnClick="UploadFile" runat="server" />
                                <asp:Label Text="Images" runat="server"></asp:Label>
                                <asp:DropDownList AutoPostBack="true" ID="dlImages" runat="server" OnSelectedIndexChanged="AddFileUpload">
                                    <asp:ListItem Value="0">
                                    </asp:ListItem>
                                    <asp:ListItem Value="1">
                                    </asp:ListItem>
                                    <asp:ListItem Value="2">
                                    </asp:ListItem>
                                    <asp:ListItem Value="3">
                                    </asp:ListItem>
                                    <asp:ListItem Value="4">
                                    </asp:ListItem>
                                    <asp:ListItem Value="5">
                                    </asp:ListItem>
                                    <asp:ListItem Value="6">
                                    </asp:ListItem>
                                    <asp:ListItem Value="7">
                                    </asp:ListItem>
                                    <asp:ListItem Value="8">
                                    </asp:ListItem>
                                    <asp:ListItem Value="9">
                                    </asp:ListItem>
                                    <asp:ListItem Value="10">
                                    </asp:ListItem>
                                    <asp:ListItem Value="11">
                                    </asp:ListItem>
                                    <asp:ListItem Value="12">
                                    </asp:ListItem>
                                    <asp:ListItem Value="13">
                                    </asp:ListItem>
                                    <asp:ListItem Value="14">
                                    </asp:ListItem>
                                    <asp:ListItem Value="15">
                                    </asp:ListItem>
                                </asp:DropDownList>
                                <div class="break"></div>
                            </contentbox>
                            <asp:Button OnClick="UploadFile" runat="server" />
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="dlImages" EventName="SelectedIndexChanged" />
                        </Triggers>

                    </asp:UpdatePanel>

                </sellinginfobox>
        </sellinginfo>
    </form>

</body>
</html>
