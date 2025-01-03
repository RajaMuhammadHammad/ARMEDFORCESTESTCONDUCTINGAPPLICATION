using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Medical
{
    public partial class InsertMedicalInformation : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";

        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("InsertMedicalTest", sqlConnection);
                sqlConnection.Open();

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
                sql.Parameters.AddWithValue("@CNIC", TextBox2.Text);
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



                sql.ExecuteNonQuery();

                lblErrorMessage.Text = "";
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
            Session["PageVisited"] = null;
            Response.Redirect("MedicalAdminModule.aspx");

        }
    }
}