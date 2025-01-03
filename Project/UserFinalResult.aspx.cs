using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class UserFinalResult : System.Web.UI.Page
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
                string id = TextBox1.Text.Trim();
                string remarks = GetCombinedRemarks(id);

                if (remarks != null)
                {
                    Label3.Text = remarks;
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "No Record found with the given ID.";
                    Label3.Text = "";
                }

                Label5.Visible = true;
                DataTable finalResults = GetFinalResults(id);

                if (finalResults != null && finalResults.Rows.Count > 0)
                {
                    GridView1.DataSource = finalResults;
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
        }

        private string GetCombinedRemarks(string id)
        {
            string remarks = null;
            try
            {
                SqlCommand sql = new SqlCommand("SearchCombinedRemarksByID", sqlConnection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", id);

                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    remarks = reader["CombinedRemarks"].ToString();
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

            return remarks;
        }

        private DataTable GetFinalResults(string id)
        {
            DataTable finalResults = null;
            try
            {
                SqlCommand sql = new SqlCommand("SearchFinalResultByID", sqlConnection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", id);

                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    finalResults = new DataTable();
                    finalResults.Load(reader);
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

            return finalResults;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("presenatation2.aspx");
        }
    }
}
    