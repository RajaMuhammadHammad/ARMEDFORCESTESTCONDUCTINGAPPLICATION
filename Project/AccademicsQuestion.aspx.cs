using Businesslogiclayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sampletest
{
    public partial class AccademicsQuestion : System.Web.UI.Page
    {
        private AcademicsQuestionbll bLogic;
        private string[] questions, Option1, Option2, Option3, Option4, correctAnswers;
        private string[] userAnswers;
        private int currentQuestionIndex;
        private int timeleft = 1020;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Loginbll lgopen = new Loginbll();
                string id = Loginbll.id.ToString();
                string cnic = Loginbll.cnic;

                // Display the ID and CNIC on the page
                Label2.Text = $"ID: {id}";
                Label3.Text = $"CNIC: {cnic}";
                Timer1.Enabled = true;
                bLogic = new AcademicsQuestionbll();
                questions = bLogic.GetQuestions()?.ToArray();
                Option1 = bLogic.GetOption1()?.ToArray();
                Option2 = bLogic.GetOption2()?.ToArray();
                Option3 = bLogic.GetOption3()?.ToArray();
                Option4 = bLogic.GetOption4()?.ToArray();
                correctAnswers = bLogic.GetCorrectAnswers()?.ToArray(); // Fetch correct answers from BLL

                if (questions == null || Option1 == null || Option2 == null || Option3 == null || Option4 == null || correctAnswers == null)
                {
                    Label1.Text = "Error: Unable to load questions or options.";
                    Button2.Enabled = false;
                    Button5.Visible = false;
                    return;
                }

                userAnswers = new string[questions.Length]; // Initialize user answers array

                ViewState["questions"] = questions; // Store questions in ViewState
                ViewState["Option1"] = Option1;
                ViewState["Option2"] = Option2;
                ViewState["Option3"] = Option3;
                ViewState["Option4"] = Option4;
                ViewState["correctAnswers"] = correctAnswers; // Store correct answers in ViewState
                ViewState["userAnswers"] = userAnswers; // Store user answers in ViewState
                ViewState["currentQuestionIndex"] = 0; // Store current question index in ViewState
                ViewState["timeleft"] = timeleft;

                DisplayCurrentQuestion();
                Button2.Visible = false; // Ensure Button2 is hidden initially
                Button5.Visible=false;
            }
            else
            {
                questions = (string[])ViewState["questions"]; // Retrieve questions from ViewState
                Option1 = (string[])ViewState["Option1"];
                Option2 = (string[])ViewState["Option2"];
                Option3 = (string[])ViewState["Option3"];
                Option4 = (string[])ViewState["Option4"];
                correctAnswers = (string[])ViewState["correctAnswers"]; // Retrieve correct answers from ViewState
                userAnswers = (string[])ViewState["userAnswers"]; // Retrieve user answers from ViewState
                currentQuestionIndex = (int)ViewState["currentQuestionIndex"]; // Retrieve current question index from ViewState
                timeleft = (int)ViewState["timeleft"];
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Update the timer
            if (timeleft > 0)
            {
                timeleft--;
                ViewState["timeleft"] = timeleft; // Timer value ko ViewState mein store karein
                int minutes = timeleft / 60;
                int seconds = timeleft % 60;

                // Update the timer label
                timerlabel.Text = $"{minutes:D2}:{seconds:D2}";

                // Check if time is up
                if (timeleft <= 0)
                {
                    Timer1.Enabled = false;
                    timerlabel.Text = "Time's up!";
                    EvaluateResults();
                    DisplayCurrentQuestion(); // Display end message
                }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Save the selected answer
            if (RadioButton1.Checked)
            {
                userAnswers[currentQuestionIndex] = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                userAnswers[currentQuestionIndex] = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                userAnswers[currentQuestionIndex] = RadioButton3.Text;
            }
            else if (RadioButton4.Checked)
            {
                userAnswers[currentQuestionIndex] = RadioButton4.Text;
            }

            // Check if any option was selected before proceeding
            if (string.IsNullOrEmpty(userAnswers[currentQuestionIndex]))
            {
                // Show a message to the user indicating that they must select an option
                // You can display this message in a label or using a JavaScript alert
                return;
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Length)
            {
                ViewState["currentQuestionIndex"] = currentQuestionIndex; // Update ViewState with new index
                DisplayCurrentQuestion();
                Count.Text = currentQuestionIndex.ToString();
            }
            else
            {
                EvaluateResults(); // Evaluate results at the end
                Timer1.Enabled = false;
            }
            ExecuteOnAllChildren<RadioButton>(this, a => { a.Checked = false; });

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("presentation4.aspx");
        }

        private void DisplayCurrentQuestion()
        {
            if (timeleft > 0 && currentQuestionIndex < questions.Length)
            {
                Label1.Text = questions[currentQuestionIndex];
                RadioButton1.Text = Option1[currentQuestionIndex];
                RadioButton2.Text = Option2[currentQuestionIndex];
                RadioButton3.Text = Option3[currentQuestionIndex];
                RadioButton4.Text = Option4[currentQuestionIndex];
            }
            else
            {
                Timer1.Enabled = false;
            }
        }

        private void EvaluateResults()
        {

            if (userAnswers == null || correctAnswers == null)
            {
                lblErrorMessage.Text = "Error: Unable to evaluate results due to missing data.";
                return;
            }

            int correctCount = 0;
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    correctCount++;
                }
            }

            double score = (double)correctCount / correctAnswers.Length * 100;
            if (score >= 30)
            {
                lblErrorMessage.Text = "You passed the test.";
                Button2.Visible = true;
                Button5.Visible= false;
            }
            else
            {
                lblErrorMessage.Text = "You failed the test.";
                Button2.Visible = false;
                Button5.Visible = true;
                
            }

            RadioButton1.Visible = false;
            RadioButton2.Visible = false;
            RadioButton3.Visible = false;
            RadioButton4.Visible = false;
            Button3.Visible = false;
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Add logic to handle radio button selection if needed
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("presenatation2.aspx");
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Add logic to handle radio button selection if needed
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Add logic to handle radio button selection if needed
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Add logic to handle radio button selection if needed
        }

        private void ExecuteOnAllChildren<T>(Control parent, Action<T> action) where T : Control
        {
            foreach (Control child in parent.Controls)
            {
                if (child is T control)
                {
                    action(control);
                }
                if (child.HasControls())
                {
                    ExecuteOnAllChildren(child, action);
                }
            }
        }

        private bool InsertTestData(string ID)
        {
            string connectionString = "Data Source=DESKTOP-LPLM965\\SQLEXPRESS;Initial Catalog=projectss;Integrated Security=True;Encrypt=False";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO ClearTest (ID) VALUES (@ID)";
                        command.Parameters.AddWithValue("@ID", ID);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                // For debugging purposes, you can also use Response.Write to display the exception message
                Response.Write($"Error: {ex.Message}");
                return false;
            }

        }
    }
}
