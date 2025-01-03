using System;
using System.Web;

namespace Project
{
    public partial class SelectRegistrationForm : System.Web.UI.Page
    {
        // Dependency injection for redirection
        public Action<string> RedirectMethod { get; set; } = url => HttpContext.Current.Response.Redirect(url);

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            RedirectMethod("NavyRegistration.aspx");
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            RedirectMethod("Slip.aspx");
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            RedirectMethod("Registrationform.aspx");
        }
    }
}
