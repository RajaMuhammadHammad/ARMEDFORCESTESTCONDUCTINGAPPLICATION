using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class presenatation2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrationform.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("FinalResult.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("presentation3.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecordsofTest.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medicalpresentation.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Physicaltestpresentation.aspx");
        }


        protected void Button7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}