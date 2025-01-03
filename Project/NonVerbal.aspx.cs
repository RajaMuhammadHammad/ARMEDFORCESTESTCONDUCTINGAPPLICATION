using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businesslogiclayer;
using BusinessLogicLayer;

namespace sampletest
{
    public partial class Non_Verbal : System.Web.UI.Page
    {
        private NonVerablQuestion bLogic;
        private string[] Option1, Option2, Option3, Option4, correctAnswers;
        private string[] userAnswers;
        private int currentQuestionIndex;
        private int timeleft = 140;

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

                ViewState["currentIndex"] = 0;
                Timer1.Enabled = true;
                bLogic = new NonVerablQuestion();

                Option1 = bLogic.GetGetOption1()?.ToArray();
                Option2 = bLogic.GetGetOption2()?.ToArray();
                Option3 = bLogic.GetGetOption3()?.ToArray();
                Option4 = bLogic.GetGetOption4()?.ToArray();
                correctAnswers = bLogic.GetCorrectAnswers()?.ToArray(); // Fetch correct answers from BLL

                if (Option1 == null || Option2 == null || Option3 == null || Option4 == null || correctAnswers == null)
                {
                    Button1.Enabled = false;
                    return;
                }
                userAnswers = new string[Option1.Length];

                ViewState["Option1"] = Option1;
                ViewState["Option2"] = Option2;
                ViewState["Option3"] = Option3;
                ViewState["Option4"] = Option4;
                ViewState["correctAnswers"] = correctAnswers; // Store correct answers in ViewState
                ViewState["userAnswers"] = userAnswers; // Store user answers in ViewState
                ViewState["currentQuestionIndex"] = 0; // Store current question index in ViewState
                ViewState["timeleft"] = timeleft;

                // Initialize userAnswers array

                DisplayImage();
                Button2.Visible = false; // Ensure Button2 is hidden initially
                Button5.Visible = false;
            }
            else
            {
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
                    DisplayImage(); // Display end message
                }
            }
        }

        private void DisplayImage()
        {
            try
            {
                int currentIndex = (int)ViewState["currentIndex"];
                string imageUrl = string.Empty;

                switch (currentIndex)
                {
                    case 0:
                        imageUrl = "~/Non Verabal Question/Question 1.jpeg";
                        break;
                    case 1:
                        imageUrl = "~/Non Verabal Question/Question 2.jpeg";
                        break;
                    case 2:
                        imageUrl = "~/Non Verabal Question/Question 3.jpeg";
                        break;
                    case 3:
                        imageUrl = "~/Non Verabal Question/Question 4.jpeg";
                        break;
                    case 4:
                        imageUrl = "~/Non Verabal Question/Question 5.jpeg";
                        break;
                    case 5:
                        imageUrl = "~/Non Verabal Question/Question 6.jpeg";
                        break;
                    case 6:
                        imageUrl = "~/Non Verabal Question/Question 7.jpeg";
                        break;
                    case 7:
                        imageUrl = "~/Non Verabal Question/Question 8.jpeg";
                        break;
                    case 8:
                        imageUrl = "~/Non Verabal Question/Question 9.jpeg";
                        break;
                    case 9:
                        imageUrl = "~/Non Verabal Question/Question 10.jpeg";
                        break;
                    case 10:
                        imageUrl = "~/Non Verabal Question/Question 11.jpeg";
                        break;
                    case 11:
                        imageUrl = "~/Non Verabal Question/Question 12.jpeg";
                        break;
                    case 12:
                        imageUrl = "~/Non Verabal Question/Question 13.jpeg";
                        break;
                    case 13:
                        imageUrl = "~/Non Verabal Question/Question 14.jpeg";
                        break;
                    case 14:
                        imageUrl = "~/Non Verabal Question/Question 15.jpeg";
                        break;
                    case 15:
                        imageUrl = "~/Non Verabal Question/Question 16.jpeg";
                        break;
                    case 16:
                        imageUrl = "~/Non Verabal Question/Question 17.jpeg";
                        break;
                    default:
                        lblErrorMessage.Text = "No more images to display.";
                        return;
                }
                Image1.ImageUrl = imageUrl;

                //Display only the options fetched from the database
                RadioButton1.Text = Option1[currentIndex];
                RadioButton2.Text = Option2[currentIndex];
                RadioButton3.Text = Option3[currentIndex];
                RadioButton4.Text = Option4[currentIndex];
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "There is an error: " + ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Handle image display logic
                currentQuestionIndex = (int)ViewState["currentIndex"];
                currentQuestionIndex++;
                if (currentQuestionIndex >= 17) // Total number of images
                {
                    // Display result when reaching the last question
                    EvaluateResults();
                    Timer1.Enabled = false; // Stop the timer
                    return;
                }
                ViewState["currentIndex"] = currentQuestionIndex;
                Count.Text = currentQuestionIndex.ToString();
                DisplayImage();

                // Your existing code
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "There is an error with image display: " + ex.Message;
            }
            ExecuteOnAllChildren<RadioButton>(this, a => { a.Checked = false; });
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
                Button5.Visible = false;
            }
            else
            {
                lblErrorMessage.Text = "You failed the test.";
                Button2.Visible = false;
                Button5.Visible= true;
            }

            RadioButton1.Visible = false;
            RadioButton2.Visible = false;
            RadioButton3.Visible = false;
            RadioButton4.Visible = false;
            Image1.Visible = false;
            Button1.Visible = false;
        }

        private void ExecuteOnAllChildren<T>(Control parent, Action<T> action) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T)
                {
                    action((T)control);

                    if (control.HasControls())
                    {
                        ExecuteOnAllChildren(control, action);
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccademicsQuestion.aspx");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateUserAnswer(rb, 1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("presenatation2.aspx");

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateUserAnswer(rb, 2);
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateUserAnswer(rb, 3);
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateUserAnswer(rb, 4);
        }

        private void UpdateUserAnswer(RadioButton rb, int optionNumber)
        {
            int index = (int)ViewState["currentIndex"];
            userAnswers[index] = rb.Text;
        }
    }
}
