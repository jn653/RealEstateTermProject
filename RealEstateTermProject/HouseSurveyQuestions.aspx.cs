using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealEstateTermProject
{
    public partial class HouseSurveyQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbltitle.Text = "Feedback For House With Address: ";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string price;
            if (radiobtnReasonablePrice.Text.Equals("Not very reasonable"))
            {
                price = "Not very reasonable";
            }
            else
                if (radiobtnReasonablePrice.Text.Equals("Somewhat reasonable"))
            {
                price = "Somwhat reasonable";
            }
            else
                price = "Very reasonable";
        }
    }
}