using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealEstateTermProject
{
    public partial class SignupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {



            // depedning on what radio button is clicked will determine what landing page loads
            if (radiobtnHomeSeller.Checked == true)
            {
                Response.Redirect("LandingPageforHomeSeller.aspx");
            }
            else if (radiobtnRealEstateAgent.Checked == true)
            {
                Response.Redirect("LandingPageforRealEstateAgent.aspx");
            }
            else
                Response.Redirect("LandingPage.aspx");
        }
    }
    }
