using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Medical
{
    public partial class UpdateMedicalrecods : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("UpdateMedicalTest", sqlConnection);
                sqlConnection.Open();

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", TextBox1.Text.Trim()); // Add the ID parameter
                sql.Parameters.AddWithValue("@CNIC", TextBox2.Text.Trim()); // Add the CNIC parameter
                sql.Parameters.AddWithValue("@DateOfTest", TextBox3.Text);
                sql.Parameters.AddWithValue("@ConductingDoctor", TextBox4.Text);
                sql.Parameters.AddWithValue("@VisionTest", DropDownList1.Text);
                sql.Parameters.AddWithValue("@HearingTest", DropDownList2.Text);
                sql.Parameters.AddWithValue("@BloodPressure", DropDownList3.Text);
                sql.Parameters.AddWithValue("@Height", TextBox5.Text);
                sql.Parameters.AddWithValue("@Weight", TextBox6.Text);
                sql.Parameters.AddWithValue("@BMI", TextBox7.Text);
                sql.Parameters.AddWithValue("@Allergies", DropDownList4.Text);
                sql.Parameters.AddWithValue("@PastMedicalHistory", DropDownList5.Text);
                sql.Parameters.AddWithValue("@TestRemarks", DropDownList6.Text);

                int rowsAffected = sql.ExecuteNonQuery();
                // Handle success or show appropriate message
                lblErrorMessage.Text = rowsAffected > 0 ? "Update successful." : "No records updated.";
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
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            DropDownList3.Visible = false;
            DropDownList4.Visible = false;
            DropDownList5.Visible = false;
            DropDownList6.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
            Label14.Visible = false;
            Label15.Visible = false;
            Label16.Visible = false;
            Label17.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label18.Visible = false;

            Button1.Visible = false; // Show "Validate" button
        }

        private void ShowInputFields()
        {
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            DropDownList3.Visible = true;
            DropDownList4.Visible = true;
            DropDownList5.Visible = true;
            DropDownList6.Visible = true;
            Label11.Visible = true;
            Label12.Visible = true;
            Label13.Visible = true;
            Label14.Visible = true;
            Label15.Visible = true;
            Label16.Visible = true;
            Label17.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label18.Visible = true;

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

                    string query = "SELECT COUNT(*) FROM MedicalTest WHERE ID = @ID AND CNIC = @CNIC";
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("Medicalpresentation.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
