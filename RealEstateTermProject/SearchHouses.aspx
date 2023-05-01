<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHouses.aspx.cs" Inherits="RealEstateTermProject.SearchHouses" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/nav.js"></script>
    <link href="styles/SearchHouses.css" rel="stylesheet" />
    <title></title>
</head>
<body>



    <script>nav();</script>
    <backgroundimage>
        <imagetitle>
            Looking for something specific? You're in the right place!
        </imagetitle>
        <img src="https://images.familyhomeplans.com/cdn-cgi/image/fit=scale-down,quality=85/plans/44207/44207-b600.jpg" />
    </backgroundimage>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ScriptManager>
        <allcontent>
            <searchcriteria>
                <h2 id="lblSearchByCriteria" runat="server">Search for a house by One of the following criteria:</h2>
                <asp:Button ID="btnsubmitCriteria" runat="server" OnClick="btnsubmitCriteria_Click" Text="Submit criteria" />
                
                <h2 id="lblSearch" runat="server">Search for a house by</h2>
                <asp:Button ID="btnSearchHouse" CssClass="button" runat="server" Text="Search House" OnClick="btnSearchHouse_Click" />

                <asp:HyperLink ID="hyperlinkBack" CssClass="button" runat="server" NavigateUrl="~/SearchHouses.aspx">Back to Search</asp:HyperLink>

                <h2 id="lblState" runat="server">State</h2>
                <asp:DropDownList ID="ddlStates" AppendDataBoundItems="true" DataTextField="State" runat="server">
                </asp:DropDownList>


                <h2 id="lblCity" runat="server" >City</h2>
                <asp:DropDownList ID="ddlCity" runat="server" AppendDataBoundItems="true" DataTextField="City">
                </asp:DropDownList>
                <asp:Label ID="lblNumofBedrooms" runat="server" Text="Number of Bedrooms"></asp:Label>


                <h2 id="lblPropertyType" runat="server" >Property Type</h2>
                <asp:DropDownList ID="ddlPropertyType" AppendDataBoundItems="true" DataTextField="PropertyType" runat="server">
                </asp:DropDownList>

                <asp:DropDownList ID="ddlnumofBathrooms" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3+</asp:ListItem>
                </asp:DropDownList>

                <h2 id="lblPrice" runat="server" >Price</h2>
                <asp:DropDownList ID="ddlPrice" runat="server">
                    <asp:ListItem>Lower than or equal to 100,000</asp:ListItem>
                    <asp:ListItem>Greater than 100,000 or equal to 200,000</asp:ListItem>
                    <asp:ListItem>Greater than 200,000</asp:ListItem>
                </asp:DropDownList>

                <asp:DropDownList ID="AjaxComboCriteria" runat="server">
                    <asp:ListItem>State/Price/PropertyType</asp:ListItem>
                    <asp:ListItem>City/Price</asp:ListItem>
                    <asp:ListItem>State/Price/Number of bedrooms</asp:ListItem>
                    <asp:ListItem>Price/Number of bathrooms</asp:ListItem>
                </asp:DropDownList>

            </searchcriteria>
            <content id="content" runat="server">
            </content>
            <homeinfo id="homeInfo" runat="server" visible="false">
                <backdrop id="backdrop" onclick="hideHomeInfo()"></backdrop>
                <homeinfofull>
                    <mainimage>
                        <img id="image" runat="server" />
                        <homeaddress id="homeAddress" runat="server">
                        </homeaddress>
                    </mainimage>
                    <homeinfocontent>
                        <contentbox style="flex-basis: 100%; flex-direction: column; border-bottom: .1rem solid royalblue">
                            <h2>Home Description</h2>
                            <h3 id="homeDescription" runat="server"></h3>
                        </contentbox>
                        <contentbox>
                            <h2>Beds</h2>
                            <h3 id="beds" runat="server"></h3>
                            <h2>Bathrooms</h2>
                            <h3 id="bathrooms" runat="server"></h3>
                            <h2>Property Type</h2>
                            <h3 id="propertyType" runat="server"></h3>
                            <h2>Square Footage</h2>
                            <h3 id="houseSize" runat="server"></h3>
                        </contentbox>
                        <contentbox>
                            <h2>Amenities</h2>
                            <h3 id="amenities" runat="server"></h3>
                            <h2>Utilities</h2>
                            <h3 id="utilities" runat="server"></h3>
                            <h2>Garages</h2>
                            <h3 id="garages" runat="server"></h3>
                            <h2>Year Built</h2>
                            <h3 id="houseYear" runat="server"></h3>
                        </contentbox>
                        <contentbox>
                            <h2>Asking Price</h2>
                            <h3 id="askingPrice" runat="server"></h3>
                            <h2>State</h2>
                            <h3 id="state" runat="server"></h3>
                            <h2>City</h2>
                            <h3 id="city" runat="server"></h3>
                        </contentbox>
                        <contentbox3 runat="server">
                            <h1 style="align-self: center">Comments</h1>
                            <input id="userComment" placeholder="Write your own comment here!" runat="server" />
                            <asp:Button Text="Upload Comment" OnClick="UploadComment_Click" runat="server" />
                            <commentbox id="comments" runat="server">
                            </commentbox>
                        </contentbox3>
                        <contentbox3 runat="server">
                            <h1 style="align-self: center">Home Layout</h1>
                            <commentbox id="homeSizes" runat="server">
                            </commentbox>
                        </contentbox3>
                        <contentbox3 style="margin-left: 1rem;" runat="server">
                            <h1 style="align-self: center">Images</h1>
                            <images>
                                <imagebox id="imageBox" runat="server">
                                </imagebox>
                            </images>

                        </contentbox3>
                        <contentbox style="flex-direction: row;">
                            <input id="offerBox" type="number" placeholder="Offer" runat="server" />
                            <asp:Button ID="makeOffer" Text="Make Offer" OnClick="MakeOffer_Click" runat="server" />
                            <asp:Button ID="requestVisit" Text="Request Visit" OnClick="ShowScheduleVisit_Click" runat="server" />
                        </contentbox>
                    </homeinfocontent>
                </homeinfofull>
            </homeinfo>
            <requestvisit id="requestVisitContent" visible="false" runat="server">
                <backdrop id="backdrop2" style="z-index: 200;"></backdrop>
                <requestvisitcontent>
                    <contentbox2>
                        <label for="visitDate">Visit Date</label>
                        <input id="visitDate" type="date" runat="server" />
                        <label for="visitTime">Visit Time</label>
                        <asp:DropDownList ID="visitTime" runat="server">
                            <asp:ListItem>9am</asp:ListItem>
                            <asp:ListItem>10am</asp:ListItem>
                            <asp:ListItem>11am</asp:ListItem>
                            <asp:ListItem>12am</asp:ListItem>
                            <asp:ListItem>1pm</asp:ListItem>
                            <asp:ListItem>2pm</asp:ListItem>
                            <asp:ListItem>3pm</asp:ListItem>
                            <asp:ListItem>4pm</asp:ListItem>
                            <asp:ListItem>5pm</asp:ListItem>
                        </asp:DropDownList>
                    </contentbox2>
                    <buttonbox>
                        <asp:Button ID="scheduleVisit" Text="Schedule Visit" OnClick="ScheduleVisit_Click" runat="server" />
                        <asp:Button ID="cancelRequest" Text="Cancel Request" OnClick="CancelRequest_Click" runat="server" />
                    </buttonbox>
                </requestvisitcontent>
            </requestvisit>
        </allcontent>
    </form>
    <script>                              
        function hideHomeInfo() {
            homeInfo = document.getElementById("homeInfo");

            homeInfo.style.visibility = "hidden";

            location = location;
        }
    </script>
</body>
</html>
