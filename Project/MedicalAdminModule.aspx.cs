using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medical
{
    public partial class MedicalAdminModule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMedicalInformation.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateMedicalrecods.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewRecords.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("Medicalpresentation.aspx");
        }
    }
}