using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
namespace Project
{
    public partial class presentation3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PageVisited"] != null)
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                Image3.Visible = false;
                Image2.Visible = false;
                Image1.Visible = false;
                Label1.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;

                Label2.Text = "The application is already open.";

                Button1.Enabled = false;
                return;
            }
            else
            {
                Label2.Visible = false;
                Session["PageVisited"] = true;
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          Loginbll  lgopen = new Loginbll();
           
            string CNIC = TextBox1.Text;
            string rollno = TextBox2.Text;

            bool isValidated = lgopen.ValidateUser(CNIC, rollno);

            if (isValidated == true )
            {
                Response.Redirect("test.aspx");
            }
            else
            {
                  Response.Write("<script>alert('Invalid cridentials');</script>");
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
                Image3.Visible = true;
                Image2.Visible = true;
                Image1.Visible = true;
                Label1.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("presenatation2.aspx");

        }
    }
}
