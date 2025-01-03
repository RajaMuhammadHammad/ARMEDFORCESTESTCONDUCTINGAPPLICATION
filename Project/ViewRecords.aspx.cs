using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medical
{
    public partial class ViewRecords : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
           // BindGridView();
        }


        private void BindGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MedicalTest_View", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("Search_data", sqlConnection);
                sqlConnection.Open();

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@SearchID", int.Parse(TextBox1.Text));
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "No Employee found with the given ID.";
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("Medicalpresentation.aspx");
        }
    }
}