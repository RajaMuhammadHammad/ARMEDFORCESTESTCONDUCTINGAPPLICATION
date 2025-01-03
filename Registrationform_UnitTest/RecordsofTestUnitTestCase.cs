using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Project.Tests
{
    [TestClass]
    public class RecordsofTestTests
    {
        [TestMethod]
        public void PageLoad_ShouldDisableControls_WhenSessionPageVisitedIsSet()
        {
            // Arrange
            var session = new Dictionary<string, object> { { "PageVisited", true } };
            var recordPage = new MockRecordsofTest(session);

            // Act
            recordPage.SimulatePageLoad();

            // Assert
            Assert.IsFalse(recordPage.TextBox1Visible, "TextBox1 should be hidden.");
            Assert.AreEqual("The application is already open.", recordPage.Label2Text, "Label2 should indicate the application is already open.");
            Assert.IsFalse(recordPage.Button1Enabled, "Button1 should be disabled.");
        }

        [TestMethod]
        public void Button2_Click_ShouldShowError_WhenIDOrPasswordIsEmpty()
        {
            // Arrange
            var recordPage = new MockRecordsofTest();

            // Act
            recordPage.SimulateButton2Click(string.Empty, string.Empty);

            // Assert
            Assert.AreEqual("Please enter both ID and Password.", recordPage.Label2Text, "Label2 should show an error message for empty fields.");
        }

        [TestMethod]
        public void Button2_Click_ShouldRedirect_WhenIDAndPasswordAreValid()
        {
            // Arrange
            var recordPage = new MockRecordsofTest();
            recordPage.MockDatabase.Add("123", "password123");

            // Act
            recordPage.SimulateButton2Click("123", "password123");

            // Assert
            Assert.AreEqual("Audit.aspx", recordPage.RedirectedUrl, "User should be redirected to the correct page.");
        }

        [TestMethod]
        public void Button2_Click_ShouldShowError_WhenIDAndPasswordAreInvalid()
        {
            // Arrange
            var recordPage = new MockRecordsofTest();

            // Act
            recordPage.SimulateButton2Click("invalidID", "invalidPassword");

            // Assert
            Assert.AreEqual("Invalid ID or Password.", recordPage.Label2Text, "Label2 should show an error message for invalid credentials.");
        }

        [TestMethod]
        public void Button3_Click_ShouldResetSessionAndRedirect()
        {
            // Arrange
            var session = new Dictionary<string, object> { { "PageVisited", true } };
            var recordPage = new MockRecordsofTest(session);

            // Act
            recordPage.SimulateButton3Click();

            // Assert
            Assert.IsNull(session["PageVisited"], "Session should be reset.");
            Assert.AreEqual("presenatation2.aspx", recordPage.RedirectedUrl, "User should be redirected to the correct page.");
        }
    }

    // Mock class for RecordsofTest
    public class MockRecordsofTest
    {
        public Dictionary<string, object> Session { get; }
        public Dictionary<string, string> MockDatabase { get; }
        public string Label2Text { get; private set; }
        public bool TextBox1Visible { get; private set; }
        public bool Button1Enabled { get; private set; }
        public string RedirectedUrl { get; private set; }

        public MockRecordsofTest(Dictionary<string, object> session = null)
        {
            Session = session ?? new Dictionary<string, object>();
            MockDatabase = new Dictionary<string, string>();
            ResetControls();
        }

        public void SimulatePageLoad()
        {
            if (Session.ContainsKey("PageVisited"))
            {
                SetControlsVisibility(false);
                Label2Text = "The application is already open.";
                Button1Enabled = false;
            }
            else
            {
                Session["PageVisited"] = true;
                Label2Text = string.Empty;
            }
        }

        public void SimulateButton2Click(string id, string password)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Please enter both ID and Password.");
                return;
            }

            if (MockDatabase.ContainsKey(id) && MockDatabase[id] == password)
            {
                RedirectedUrl = "Audit.aspx";
            }
            else
            {
                ShowErrorMessage("Invalid ID or Password.");
            }
        }

        public void SimulateButton3Click()
        {
            Session.Remove("PageVisited");
            RedirectedUrl = "presenatation2.aspx";
        }

        public void ShowErrorMessage(string message)
        {
            Label2Text = message;
            SetControlsVisibility(true);
        }

        public void SetControlsVisibility(bool isVisible)
        {
            TextBox1Visible = isVisible;
            Button1Enabled = isVisible;
        }

        private void ResetControls()
        {
            TextBox1Visible = true;
            Button1Enabled = true;
            Label2Text = string.Empty;
            RedirectedUrl = null;
        }
    }
}
