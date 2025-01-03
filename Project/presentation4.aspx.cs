using BusinessLogicLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class presentation4 : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                // Retrieve the ID and CNIC from the login business logic
                Loginbll lgopen = new Loginbll();
                string id = Loginbll.id.ToString();
                string cnic = Loginbll.cnic;

                // Display the ID and CNIC on the page
                Label1.Text = id;
                LabelCNIC.Text = cnic;
            }
        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Extract the ID from the label text
                string idText = Label1.Text.Trim();
                int id = int.Parse(idText);

                // Retrieve the CNIC from the label text
                string cnicText = LabelCNIC.Text.Trim();

                // Retrieve selected Force from dropdown list
                string selectedForce = DropDownList1.SelectedValue;

                SqlCommand sql = new SqlCommand("InsertClearTestID", sqlConnection);
                sqlConnection.Open();

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", id);
                sql.Parameters.AddWithValue("@CNIC", cnicText);
                sql.Parameters.AddWithValue("@ForcetoApply", selectedForce);
                sql.ExecuteNonQuery();

                Session["PageVisited"] = null;
                Response.Redirect("presenatation2.aspx");
            }
            catch (Exception ex)
            {
                Label2.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
