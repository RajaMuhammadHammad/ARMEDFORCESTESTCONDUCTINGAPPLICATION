using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessesLayer
{
    public class ISSBFORMDAL
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False");

        public void InsertData(String ForcetoApply, string name, string fname, string cnic, string fcnic, string gender, string status, string religion, string province, string domicile, String dob, string email, string postalAddress, string permanentAddress, string candidateMobile, string fatherMobile)
        {

            //Response.write("<script>alert<script>");

            string query = @"INSERT INTO ISSBREG (ForcetoApply,Name, Fname, CNIC, FCNIC, Gender, Status, Religion, Province, Domicile, DOB,  Email, PostalAddress, PermanentAddress, CandidateMobile, FatherMobile) " +
                           "VALUES (@ForcetoApply,@Name, @Fname, @CNIC, @FCNIC, @Gender, @Status, @Religion, @Province, @Domicile, @DOB, @Email, @PostalAddress, @PermanentAddress, @CandidateMobile, @FatherMobile)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ForcetoApply", ForcetoApply);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Fname", fname);
                cmd.Parameters.AddWithValue("@CNIC", cnic);
                cmd.Parameters.AddWithValue("@FCNIC", fcnic);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Religion", religion);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Domicile", domicile);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PostalAddress", postalAddress);
                cmd.Parameters.AddWithValue("@PermanentAddress", permanentAddress);
                cmd.Parameters.AddWithValue("@CandidateMobile", candidateMobile);
                cmd.Parameters.AddWithValue("@FatherMobile", fatherMobile);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
