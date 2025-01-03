using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Medical
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";

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
                //Label2.Visible = false;
                Button1.Enabled = false;
                return;
            }
            else
            {
                Label2.Visible = false;
                Session["PageVisited"] = true;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Validate ID and password before redirecting
            string id = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                Label2.Text = "Please enter both ID and Password.";
                Label2.Visible = true;
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

                return;
            }

            bool isValid = ValidateIDAndCNIC(id, password);

            if (isValid)
            {
                // Redirect to new form upon successful login
                Response.Redirect("MedicalAdminModule.aspx");
            }
            else
            {
                Label2.Text = "Invalid ID or Password.";
                Label2.Visible = true;
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

        private bool ValidateIDAndCNIC(string id, string password)
        {
            bool isValid = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM MedicalAdmin_View WHERE ID = @ID AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        isValid = true; // Record exists
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                isValid = false;
                Console.WriteLine("Error validating ID and Password: " + ex.Message);
            }

            return isValid;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("Medicalpresentation.aspx");
        }
    }
}
