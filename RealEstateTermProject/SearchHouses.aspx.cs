using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealEstateTermProject
{
    public partial class SearchHouses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            
            lblState.Visible = false;
            lblPropertyType.Visible = false;
            lblPrice.Visible = false;
            ddlPrice.Visible = false;
            ddlPropertyType.Visible = false;
        }

        protected void btnsubmitCriteria_Click(object sender, EventArgs e)
        {
            if (ddlCriteria.SelectedValue.Equals("State/Price/PropertyType"))
            {
                lblSearch.Visible = true;
                
                lblState.Visible = true;
                lblPrice.Visible = true;
                lblPropertyType.Visible = true;
                ddlPrice.Visible = true;
                ddlPropertyType.Visible = true;


                lblSearchByCriteria.Visible = false;
                ddlCriteria.Visible = false;
                btnsubmitCriteria.Visible = false;
            }
        }
    }
}