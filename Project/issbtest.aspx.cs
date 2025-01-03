using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class issbtest : System.Web.UI.Page
    {
        private static string connString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayAlertMessage();
                HideButtons();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteStoredProcedure();
                ShowNextButtons();
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
            OpenUrlInBrowser("https://forms.office.com/r/XC7b9pD8Ru");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            OpenUrlInBrowser("https://forms.office.com/r/h4LJx6JLCX");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        // New extracted methods
        private void DisplayAlertMessage()
        {
            string script = "alert('Note:\\r\\n\\r\\n Again This is Just For Educational Purpose In this Session you have to solve only two test of Psysoholgy Remaing All test is not conducting through this platform');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }

        private void HideButtons()
        {
            Button5.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
        }

        private void ExecuteStoredProcedure()
        {
            SqlCommand sql = new SqlCommand("InsertIntoPsyctest", sqlConnection);
            sqlConnection.Open();
            sql.CommandType = System.Data.CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            sql.Parameters.AddWithValue("@CNIC", TextBox2.Text);
            sql.ExecuteNonQuery();
        }

        private void ShowNextButtons()
        {
            lblErrorMessage0.Visible = false;
            lblErrorMessage1.Visible = false;
            Button2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button5.Visible = true;
            Button6.Visible = true;
            Button7.Visible = true;
            lblErrorMessage.Text = "";
        }

        private void OpenUrlInBrowser(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Unable to open the URL.');</script>");
            }
        }
    }
}
