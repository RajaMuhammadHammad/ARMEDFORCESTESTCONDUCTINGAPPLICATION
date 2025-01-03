using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class QuestionRepository
    {
        private string connectionString;

        public QuestionRepository()
        {
            connectionString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
        }

        public List<string> GetQuestions()
        {
            List<string> questions = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT QuestionText FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        questions.Add(reader.GetString(0));

                    }
                }
            }

            return questions;
        }


        public List<string> GetOption1()
        {
            List<string> option1 = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Option1 FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        option1.Add(reader.GetString(0));

                    }
                }
            }

            return option1;
        }

        public List<string> GetOption2()
        {
            List<string> option2 = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Option2 FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        option2.Add(reader.GetString(0));

                    }
                }
            }

            return option2;
        }

        public List<string> GetOption3()
        {
            List<string> option3 = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Option3 FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        option3.Add(reader.GetString(0));

                    }
                }
            }

            return option3;
        }

        public List<string> GetOption4()
        {
            List<string> option4 = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Option4 FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        option4.Add(reader.GetString(0));

                    }
                }
            }

            return option4;
        }

        public List<string> GetCorrectAnswer()
        {
            List<string> option4 = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CorrectAnswer FROM IntQuestions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        option4.Add(reader.GetString(0));

                    }
                }
            }

            return option4;
        }
    }
}
