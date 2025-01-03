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
    public partial class Finalizingresult : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PageVisited"] != null)
            {
                TextBox1.Visible = false;
                Button1.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                GridView1.Visible = false;
                Label2.Text = "The application is already open.";
                //    Label2.Visible = false;
                Button1.Enabled = false;
                return;
            }
            else
            {
                Label2.Visible = false;
                Session["PageVisited"] = true;
            }


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("AdminFinalResult.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGridView();

        }
        private void BindGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM FinalResultView", sqlConnection);
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

        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand sql = new SqlCommand("SearchFinalResultByID", sqlConnection);
                sqlConnection.Open();

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
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
            try
            {
                SqlCommand sql = new SqlCommand("PopulateFinalResult", sqlConnection);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();
                int rowsAffected = sql.ExecuteNonQuery();
                // Handle success or show appropriate message
               lblErrorMessage.Text = rowsAffected > 0 ? "FinalResult table populated successfully." : "No records to populate.";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}