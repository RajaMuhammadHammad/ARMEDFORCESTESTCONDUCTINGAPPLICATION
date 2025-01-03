using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Physicaltestpresentation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PhysicalTestAdminLogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PhysicalTestUserResult.aspx");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("presenatation2.aspx");

        }
    }
}