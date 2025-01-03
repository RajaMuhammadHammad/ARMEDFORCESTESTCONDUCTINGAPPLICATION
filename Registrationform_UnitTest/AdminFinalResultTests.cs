using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Project.Tests
{
    [TestClass]
    public class AdminFinalResultTests
    {
        [TestMethod]
        public void PageLoad_ShouldDisableControls_WhenSessionPageVisitedIsSet()
        {
            // Arrange
            var session = new Dictionary<string, object> { { "PageVisited", true } };
            var adminPage = new MockAdminFinalResult(session);

            // Act
            adminPage.SimulatePageLoad();

            // Assert
            Assert.IsFalse(adminPage.TextBox1Visible, "TextBox1 should be hidden.");
            Assert.IsFalse(adminPage.TextBox2Visible, "TextBox2 should be hidden.");
            Assert.IsFalse(adminPage.Button1Visible, "Button1 should be hidden.");
            Assert.AreEqual("The application is already open.", adminPage.Label2Text, "Label2 should indicate the application is already open.");
        }

        [TestMethod]
        public void Button2_Click_ShouldShowError_WhenIDOrPasswordIsEmpty()
        {
            // Arrange
            var adminPage = new MockAdminFinalResult();

            // Act
            adminPage.SimulateButton2Click(string.Empty, string.Empty);

            // Assert
            Assert.AreEqual("Please enter both ID and Password.", adminPage.Label2Text, "Label2 should show an error message for empty fields.");
        }

        [TestMethod]
        public void Button2_Click_ShouldRedirect_WhenIDAndPasswordAreValid()
        {
            // Arrange
            var adminPage = new MockAdminFinalResult();
            adminPage.MockDatabase.Add("123", "password123");

            // Act
            adminPage.SimulateButton2Click("123", "password123");

            // Assert
            Assert.AreEqual("Finalizingresult.aspx", adminPage.RedirectedUrl, "User should be redirected to the correct page.");
        }

        [TestMethod]
        public void Button2_Click_ShouldShowError_WhenIDAndPasswordAreInvalid()
        {
            // Arrange
            var adminPage = new MockAdminFinalResult();

            // Act
            adminPage.SimulateButton2Click("invalidID", "invalidPassword");

            // Assert
            Assert.AreEqual("Invalid ID or Password.", adminPage.Label2Text, "Label2 should show an error message for invalid credentials.");
        }

        [TestMethod]
        public void Button3_Click_ShouldResetSessionAndRedirect()
        {
            // Arrange
            var session = new Dictionary<string, object> { { "PageVisited", true } };
            var adminPage = new MockAdminFinalResult(session);

            // Act
            adminPage.SimulateButton3Click();

            // Assert
            Assert.IsNull(session["PageVisited"], "Session should be reset.");
            Assert.AreEqual("FinalResult.aspx", adminPage.RedirectedUrl, "User should be redirected to the correct page.");
        }
    }

    // Mock class for AdminFinalResult
    public class MockAdminFinalResult
    {
        public Dictionary<string, object> Session { get; }
        public Dictionary<string, string> MockDatabase { get; }
        public string Label2Text { get; private set; }
        public bool TextBox1Visible { get; private set; }
        public bool TextBox2Visible { get; private set; }
        public bool Button1Visible { get; private set; }
        public string RedirectedUrl { get; private set; }

        public MockAdminFinalResult(Dictionary<string, object> session = null)
        {
            Session = session ?? new Dictionary<string, object>();
            MockDatabase = new Dictionary<string, string>();
            ResetControls();
        }

        public void SimulatePageLoad()
        {
            if (Session.ContainsKey("PageVisited"))
            {
                TextBox1Visible = false;
                TextBox2Visible = false;
                Button1Visible = false;
                Label2Text = "The application is already open.";
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
                Label2Text = "Please enter both ID and Password.";
                return;
            }

            if (MockDatabase.ContainsKey(id) && MockDatabase[id] == password)
            {
                RedirectedUrl = "Finalizingresult.aspx";
            }
            else
            {
                Label2Text = "Invalid ID or Password.";
            }
        }

        public void SimulateButton3Click()
        {
            Session.Remove("PageVisited");
            RedirectedUrl = "FinalResult.aspx";
        }

        private void ResetControls()
        {
            TextBox1Visible = true;
            TextBox2Visible = true;
            Button1Visible = true;
            Label2Text = string.Empty;
            RedirectedUrl = null;
        }
    }
}
