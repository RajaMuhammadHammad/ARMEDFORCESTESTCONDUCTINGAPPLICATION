using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Registrationform : System.Web.UI.Page
    {

        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";


        protected void Page_Load(object sender, EventArgs e)
        {
           Label6.Visible = false;

        }

        // Button click event for checking CNIC existence and navigating to next page
        public void Button1_Click(object sender, EventArgs e)
        {
            Label6.Visible = true;

            string cnic = TextBox2.Text;

            try
            {
                if (CheckCnicExistence(cnic) >= 2)
                {
                    Label6.Text = "You can't proceed because you already applied two times.";
                }
                else
                {
                    // Proceed to the registration form if CNIC is valid
                    Response.Redirect("SelectRegistrationForm.aspx");
                }
            }
            catch (Exception ex)
            {
                Label6.Text = "There is an error: " + ex.Message;
            }
        }

        // Helper method to check CNIC existence in the database
        public int CheckCnicExistence(string cnic)
        {
            int count = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand sql = new SqlCommand("CheckCNICExistence", sqlConnection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    sql.Parameters.AddWithValue("@CNIC", cnic);

                    sqlConnection.Open();
                    count = Convert.ToInt32(sql.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    // You can log the exception here if needed
                    throw new ApplicationException("Error checking CNIC existence.", ex);
                }
            }

            return count;
        }

        // Button click event for redirecting to another page
        public void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("presenatation2.aspx");
        }
    }
}
