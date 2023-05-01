/*
 ||============================== HOW TO USE ==============================||
    
     *TO INSERT INTO SOLUTION:
    - Drag and drop nav.css from the "styles" folder into the solution
    - Drag and drop nav.js from the "js" folder into the solution
    - Insert "<script> nav() </script>" at the very top of the body
        - The navbar will then create itself, requiring no other actions
          from the user

    *TO ADD A LINK:
    - Simply add a new link with the required parameters to the "links"
      array
        - The function will automatically add any new links and will update
          for every page that is using the nav.js function

 ||========================================================================|| 
 */


function navHomeSeller() {

    var head = document.head;
    var style = document.createElement("link");

    style.type = "text/css";
    style.rel = "stylesheet";
    style.href = "styles/nav.css";

    head.appendChild(style); // <----------- Adds the nav styling for ease of use

    body = document.getElementsByTagName("body")[0];

    navBar = document.createElement("nav");
    navTitle = document.createElement("navTitle");
    linkBox = document.createElement("linkBox");

    navBar.style

    navTitle.innerHTML = "Willow";

    let links = [
        {
            "href": "LandingPageforHomeSeller.aspx",
            "innerHTML": "Home"
        },
       
        {
            "href": "SellingPage.aspx",
            "innerHTML": "Sell"
        },
        {
            "href": "RequestedSellings.aspx",
            "innerHTML": "Requested Sellings"
        },
        {
            "href": "MyHomesPage.aspx",
            "innerHTML": "My Homes"
        },
        {
            "href": "HomeShowingsPage.aspx",
            "innerHTML": "Home Showings"
        },
        {
            "href": "HomeOffers.aspx",
            "innerHTML": "Home Offers"
        },
        {
            "href": "LoginPage.aspx",
            "innerHTML": "Sign Out"
        }
    ];

    for (i = 0; i < links.length; i++) {
        newlink = document.createElement("a");
        newlink.href = links[i].href;
        newlink.innerHTML = links[i].innerHTML;
        linkBox.appendChild(newlink);
    }

    navBar.appendChild(navTitle);
    navBar.appendChild(linkBox);

    body.appendChild(navBar);
}