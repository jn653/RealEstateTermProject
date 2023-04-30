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
    <script>navHomeSeller()</script>
    <backgroundimage>
        <imagetitle>
            Sell your home with us and join our millions of happy customers!
        </imagetitle>
        <img src="pics/backgrounds/SellingPageBackground.png" />
    </backgroundimage>

    <content>

        <form id="form1" runat="server">

            <sellinginfo id="sellingInfo" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <sellinginfobox>
                    <label for="address">Address</label>
                    <input id="address" runat="server" required />
                    <label for="propertyType">Property Type</label>
                    <input id="propertyType" runat="server" required />
                    <label for="homeSize">Home Size</label>
                    <input type="number" id="homeSize" runat="server" required />
                    <label for="numOfBed">Number of Bedrooms</label>
                    <input type="number" id="numOfBed" runat="server" required />
                    <label for="amenities">Amenities</label>
                    <input id="amenities" runat="server" required />
                </sellinginfobox>
                <sellinginfobox>
                    <label for="houseYear">House Year</label>
                    <input type="number" id="houseYear" runat="server" required />
                    <label for="garage">Garage</label>
                    <input type="number" id="garage" runat="server" required />
                    <label for="utilities">Utilities</label>
                    <input id="utilities" runat="server" />
                    <label for="homeDescription">Home Description</label>
                    <input id="homeDescription" runat="server" required />
                    <label for="askingPrice">Asking Price</label>
                    <input type="number" id="askingPrice" runat="server" required />
                </sellinginfobox>
                <sellinginfobox>
                    <label for="state">State</label>
                    <input id="state" runat="server" required />
                    <label for="numOfBath">Number of Bathrooms</label>
                    <input type="number" id="numOfBath" runat="server" required />
                    <label for="city">City</label>
                    <input id="city" runat="server" required />
                </sellinginfobox>
                <sellinginfobox style="overflow: scroll;">
                    <contentbox2 id="contentBox2" runat="server">
                        <asp:Label Text="Room Sizes" runat="server"></asp:Label>
                        <div class="break"></div>
                        <sizes id="s0">
                            <sizesbox>
                                <input id="l0" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w0" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl0" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s1">
                            <sizesbox>
                                <input id="l1" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w1" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl1" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s2">
                            <sizesbox>
                                <input id="l2" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w2" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl2" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s3">
                            <sizesbox>
                                <input id="l3" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w3" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl3" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s4">
                            <sizesbox>
                                <input id="l4" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w4" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl4" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s5">
                            <sizesbox>
                                <input id="l5" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w5" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl5" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s6">
                            <sizesbox>
                                <input id="l6" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w6" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl6" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s7">
                            <sizesbox>
                                <input id="l7" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w7" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl7" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s8">
                            <sizesbox>
                                <input id="l8" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w8" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl8" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s9">
                            <sizesbox>
                                <input id="l9" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w9" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl9" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                        <div class="break"></div>
                        <sizes id="s10">
                            <sizesbox>
                                <input id="l10" type="number" class="length" placeholder="Length" runat="server" />
                                <input id="w10" type="number" class="width" placeholder="Width" runat="server" />
                            </sizesbox>
                            <label>
                                Room Description
                                <asp:DropDownList ID="sddl10" runat="server">
                                <asp:ListItem Value="Bedroom"></asp:ListItem>
                                <asp:ListItem>Living Room</asp:ListItem>
                                <asp:ListItem>Bathroom</asp:ListItem>
                                <asp:ListItem>Basement</asp:ListItem>
                                <asp:ListItem>Attic</asp:ListItem>
                            </asp:DropDownList>
                            </label>
                        </sizes>
                    </contentbox2>

                </sellinginfobox>
                <sellinginfobox style="overflow: scroll; flex-grow: 4;">
                    <asp:UpdatePanel ID="upImages" CssClass="updatePanel" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <contentbox id="contentBox" runat="server">
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
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="dlImages" EventName="SelectedIndexChanged" />
                        </Triggers>

                    </asp:UpdatePanel>

                </sellinginfobox>
            </sellinginfo>
            <asp:Button ID="uploadHouse" Text="Sell House Individually" OnClick="Button1_Click" runat="server" />
            <asp:Button ID="findRealtor" Text="Find a Realtor" OnClick="findRealtor_Click" runat="server" />
        </form>
    </content>
    <script>
        function changeButton(id) {
            var fl = document.getElementById('fl' + id);
            var im = document.getElementById('im' + id);

            im.className = "hasContent";

            var flReader = new FileReader();
            flReader.readAsDataURL(fl.files[0]);
            flReader.onloadend = function (event) {
                var img = document.getElementById('im' + id);
                img.src = event.target.result;
            }
            /*
            im.src = 
            lbl.innerHTML = fl.value.substring(fl.value.lastIndexOf('\\') + 1);*/
            console.log(id);
        }
    </script>
</body>
</html>
