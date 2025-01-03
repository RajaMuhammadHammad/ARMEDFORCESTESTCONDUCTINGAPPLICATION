using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class PhysicaltestUpdaterecordAdmin : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideInputFields(); // Initially hide input fields
                lblErrorMessage.Visible = false;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Validate ID and CNIC before showing input fields
            string id = TextBox1.Text.Trim();
            string cnic = TextBox2.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(cnic))
            {
                lblErrorMessage.Text = "Please enter both ID and CNIC.";
                lblErrorMessage.Visible = true;
                HideInputFields(); // Ensure input fields are hidden
                return;
            }

            // Perform validation against your database or any other logic
            bool isValid = ValidateIDAndCNIC(id, cnic); // Implement this method

            if (isValid)
            {
                // Show input fields
                ShowInputFields();
                lblErrorMessage.Visible = false;
            }
            else
            {
                lblErrorMessage.Text = "Invalid ID or CNIC.";
                lblErrorMessage.Visible = true;
                HideInputFields(); // Ensure input fields are hidden
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("UpdatePhysicalTest", sqlConnection);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@ID", TextBox1.Text.Trim()); // Add the ID parameter
                sql.Parameters.AddWithValue("@DateOfTest", TextBox3.Text);
                sql.Parameters.AddWithValue("@Incharge", TextBox4.Text);
                sql.Parameters.AddWithValue("@RunningTiming", TextBox5.Text);
                sql.Parameters.AddWithValue("@PushUps", TextBox6.Text);
                sql.Parameters.AddWithValue("@SitUps", TextBox7.Text);
                sql.Parameters.AddWithValue("@ChinUps", TextBox8.Text);
                sql.Parameters.AddWithValue("@TestRemarks", DropDownList6.Text);

                sqlConnection.Open();
                int rowsAffected = sql.ExecuteNonQuery();
                // Handle success or show appropriate message
                lblErrorMessage.Text = rowsAffected > 0 ?  "No records updated.": "Update successful.";
                lblErrorMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "There is an error: " + ex.Message;
                lblErrorMessage.Visible = true;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void HideInputFields()
        {
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            DropDownList6.Visible = false;
            Label11.Visible = false;
            Label17.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label18.Visible = false;
            Label15.Visible = false;
            Button1.Visible = false; // Show "Validate" button
        }

        private void ShowInputFields()
        {
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            DropDownList6.Visible = true;
            Label11.Visible = true;
            Label17.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label18.Visible = true;
            Label15.Visible = true;
            Button1.Visible = true; // Hide "Validate" button
            Button4.Visible = false;
        }

        // Method to validate ID and CNIC against your database
        private bool ValidateIDAndCNIC(string id, string cnic)
        {
            bool isValid = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM PhysicalTest WHERE ID = @ID AND CNIC = @CNIC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@CNIC", cnic);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        isValid = true; // Record exists
                    }
                }
            }
            catch (Exception e)
            {
                // Handle any exceptions here, such as logging or displaying an error message
                isValid = false;
                // Example: Console.WriteLine("Error validating ID and CNIC: " + ex.Message);
            }

            return isValid;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("PhysicalTestAdminModule.aspx");

        }
    }
}
