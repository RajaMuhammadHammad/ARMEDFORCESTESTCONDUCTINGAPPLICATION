using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Presentation1 : System.Web.UI.Page
    {
        // Page_Load is only called once when the page is first loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowDisclaimerAlert();
            }
        }

        // Method to show the disclaimer alert
        private void ShowDisclaimerAlert()
        {
            string script = @"alert('Disclaimer:\\r\\n\\r\\nThis ISSB Testing Application is developed for educational purposes and is not affiliated with or endorsed by the Inter Services Selection Board of Pakistan. All content is either original or sourced from publicly available materials believed to be in the public domain. If any copyrighted material is identified, please contact us for prompt removal. We make no warranties regarding the accuracy or reliability of the information provided.');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }

        // Unified method to handle page redirection
        private void RedirectToPage(string pageUrl)
        {
            Response.Redirect(pageUrl);
        }

        // Button event handlers for page redirection
        protected void Button2_Click(object sender, EventArgs e)
        {
            RedirectToPage("presenatation2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RedirectToPage("ISSB1.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            RedirectToPage("Disclaimer.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            RedirectToPage("Instruction.aspx");
        }

        // Close application
        protected void Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Placeholder event handlers for ImageButton click events
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            // Implement your ImageButton1 click functionality here
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            // Implement your ImageButton2 click functionality here
        }
    }
}
