using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class RecordsofTest : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        
        public void Page_Load(object sender, EventArgs e)
        {
            if (Session["PageVisited"] != null)
            {
                SetControlsVisibility(false);
                Label2.Text = "The application is already open.";
                Button1.Enabled = false;
                return;
            }

            Label2.Visible = false;
            Session["PageVisited"] = true;
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Please enter both ID and Password.");
                return;
            }

            if (ValidateIDAndCNIC(id, password))
            {
                Response.Redirect("Audit.aspx");
            }
            else
            {
                ShowErrorMessage("Invalid ID or Password.");
            }
        }

        public bool ValidateIDAndCNIC(string id, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM FinalSelectionAdmin_View WHERE ID = @ID AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Password", password);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error validating ID and Password: " + ex.Message);
                return false;
            }
        }

        public void ShowErrorMessage(string message)
        {
            Label2.Text = message;
            Label2.Visible = true;
            SetControlsVisibility(true);
        }

        public void SetControlsVisibility(bool isVisible)
        {
            TextBox1.Visible = isVisible;
            TextBox2.Visible = isVisible;
            Button1.Visible = isVisible;
            Button2.Visible = isVisible;
            Image3.Visible = isVisible;
            Image2.Visible = isVisible;
            Image1.Visible = isVisible;
            Label1.Visible = isVisible;
            Label3.Visible = isVisible;
            Label4.Visible = isVisible;
            Label5.Visible = isVisible;
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("presenatation2.aspx");
        }
    }
}
