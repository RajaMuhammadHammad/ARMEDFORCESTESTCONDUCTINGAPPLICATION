using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class UserMedicalpresentation : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
            Label5.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Label4.Visible = true;
                GetMedicalTestRemarks(TextBox1.Text.Trim());
                Label5.Visible = true;
                GetSearchData(TextBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "Error: " + ex.Message;
            }
        }

        private void GetMedicalTestRemarks(string searchID)
        {
            SqlCommand sql = new SqlCommand("SearchMedicalTestRemarks", sqlConnection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", searchID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string testRemarks = reader["TestRemarks"].ToString();
                    Label3.Text = testRemarks;
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "No Record found with the given ID.";
                    Label3.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void GetSearchData(string searchID)
        {
            SqlCommand sql = new SqlCommand("Search_data", sqlConnection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SearchID", searchID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                if (reader.HasRows)
                {
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "No Record found with the given ID.";
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medicalpresentation.aspx");
        }
    }
}
