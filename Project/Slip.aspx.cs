using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Registration_View
{
    public partial class Slip : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            ExportButton.Visible = false;

            if (!IsPostBack)
            {
           
            }

        }

        //private void BindGridView()
        //{
           
        //}


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("SearchPakistanNavyByCNIC", sqlConnection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@CNIC", TextBox1.Text.Trim());

                sqlConnection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                ExportButton.Visible = true;
                if (reader.HasRows)
                {
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    lblErrorMessage.Text = "";

                }
                else
                {
                    lblErrorMessage.Text = "No Record found with the given CNIC.";
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
        protected void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Path to save the text file
                string filePath = Server.MapPath("~/Slip.txt");

                // Create or overwrite the text file
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Iterate through each row in the GridView
                    foreach (GridViewRow row in GridView1.Rows)
                    {
                        // Extract data from each cell in the row
                        string id = row.Cells[0].Text.Trim();
                        string forcetoApply = row.Cells[1].Text.Trim();
                        string name = row.Cells[2].Text.Trim();
                        string fname = row.Cells[3].Text.Trim();
                        string cnic = row.Cells[4].Text.Trim();
                        string fCnic = row.Cells[5].Text.Trim();
                        string gender = row.Cells[6].Text.Trim();
                        string status = row.Cells[7].Text.Trim();
                        string religion = row.Cells[8].Text.Trim();
                        string province = row.Cells[9].Text.Trim();
                        string domicile = row.Cells[10].Text.Trim();
                        string dob = row.Cells[11].Text.Trim();
                        string email = row.Cells[12].Text.Trim();
                        string postalAddress = row.Cells[13].Text.Trim();
                        string permanentAddress = row.Cells[14].Text.Trim();
                        string candidateMobile = row.Cells[15].Text.Trim();
                        string fatherMobile = row.Cells[16].Text.Trim();

                        sw.WriteLine("\t\t\t\t\t\t  ARMED FORCES INITIAL TESTS \t\t\t\t\t ");
                        sw.WriteLine("\t\t\t\t\t\t      Registration Slip      \t\t\t\t\t ");

                        // Write each field on a new line
                        sw.WriteLine("ID: " + id);
                        sw.WriteLine("Force to Apply: " + forcetoApply);
                        sw.WriteLine("Name: " + name);
                        sw.WriteLine("Father's Name: " + fname);
                        sw.WriteLine("CNIC: " + cnic);
                        sw.WriteLine("Father's CNIC: " + fCnic);
                        sw.WriteLine("Gender: " + gender);
                        sw.WriteLine("Status: " + status);
                        sw.WriteLine("Religion: " + religion);
                        sw.WriteLine("Province: " + province);
                        sw.WriteLine("Domicile: " + domicile);
                        sw.WriteLine("DOB: " + dob);
                        sw.WriteLine("Email: " + email);
                        sw.WriteLine("Postal Address: " + postalAddress);
                        sw.WriteLine("Permanent Address: " + permanentAddress);
                        sw.WriteLine("Candidate Mobile: " + candidateMobile);
                        sw.WriteLine("Father Mobile: " + fatherMobile);
                        sw.WriteLine(); // Add an empty line between records
                    }
                }

                // Provide the file to download
                Response.Clear();
                Response.ContentType = "text/plain";
                Response.AppendHeader("Content-Disposition", "attachment; filename=TextFile1.txt");
                Response.TransmitFile(filePath);
                Response.Flush();
                Response.End();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "Error exporting data: " + ex.Message;
            }
        }


    }
}
