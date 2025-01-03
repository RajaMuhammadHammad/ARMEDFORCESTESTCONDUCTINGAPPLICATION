    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace DataAcessesLayer
    {
        public class Login
        {
            private static string connectionString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
            static int id;
            static string cnic;
            public bool ValidateUser(string CNIC, string ID)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT CNIC FROM PakistanNavy WHERE CNIC = @CNIC AND ID = @ID";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            try
                            {
                                id = Convert.ToInt32(ID);
                                command.Parameters.AddWithValue("@CNIC", CNIC);
                                command.Parameters.AddWithValue("@ID", ID);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    id= Convert.ToInt32(ID);
                                    cnic = CNIC;
                                    return true;

                                }
                                else {
                                    return false;
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Log the exception (logging mechanism not shown here)
                    // Optionally, rethrow or handle the exception as needed
                    throw new Exception("An error occurred while validating the user.", ex);
                }
            }
        }
    }
