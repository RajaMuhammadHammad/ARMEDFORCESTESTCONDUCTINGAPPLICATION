using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Audit : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_AuditPakistanNavy ORDER BY AuditTime DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                // For example:
                Response.Write($"Error: {ex.Message}");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_AuditClearTest  ORDER BY AuditTime DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                // For example:
                Response.Write($"Error: {ex.Message}");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_MedicalTestAudit  ORDER BY AuditTime DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                // For example:
                Response.Write($"Error: {ex.Message}");
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session["PageVisited"] = null;
            Response.Redirect("presenatation2.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_FinalResultAudit  ORDER BY AuditTime DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                // For example:
                Response.Write($"Error: {ex.Message}");
            }
        }
    }
}