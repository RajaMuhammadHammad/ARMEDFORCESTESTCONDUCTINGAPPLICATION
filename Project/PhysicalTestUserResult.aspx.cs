using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class PhysicalTestUserResult : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
            Label5.Visible = false;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Label4.Visible = true;
                SqlCommand sql = new SqlCommand("SearchTestRemarksByID", sqlConnection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", TextBox1.Text.Trim());

                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); // Since we expect a single value, we just read the first row
                    string testRemarks = reader["TestRemarks"].ToString();
                    Label3.Text = testRemarks;
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "No Record found with the given ID.";
                    Label3.Text = ""; // Clear label if no record found
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

            try
            {
                Label5.Visible = true;
                SqlCommand sql = new SqlCommand("SearchPhysicalTestByID", sqlConnection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", TextBox1.Text.Trim());

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

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Physicaltestpresentation.aspx");
        }
    }
}