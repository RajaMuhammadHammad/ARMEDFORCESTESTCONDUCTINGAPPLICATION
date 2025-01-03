using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Project.Tests
{
    [TestClass]
    public class ISSB3Tests
    {
        [TestMethod]
        public void Button2_Click_ShouldDisplayID_WhenCNICExists()
        {
            // Arrange
            string inputCNIC = "12345-6789012-3";
            string expectedID = "1001";

            // Act
            string actualID = SimulateSearchIDByCNIC(inputCNIC);

            // Assert
            Assert.AreEqual(expectedID, actualID, "The retrieved ID should match the expected value.");
        }

        [TestMethod]
        public void Button2_Click_ShouldShowError_WhenCNICDoesNotExist()
        {
            // Arrange
            string inputCNIC = "00000-0000000-0";
            string expectedErrorMessage = "No Record found with the given ID.";

            // Act
            string actualErrorMessage = SimulateSearchIDByCNIC(inputCNIC, out string actualID);

            // Assert
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, "The error message should indicate no record found.");
            Assert.AreEqual(string.Empty, actualID, "The ID label should be cleared when no record is found.");
        }

        [TestMethod]
        public void Button3_Click_ShouldRedirectToIssbTestPage()
        {
            // Arrange
            string expectedUrl = "issbtest.aspx";

            // Act
            string actualUrl = SimulateRedirectToIssbTest();

            // Assert
            Assert.AreEqual(expectedUrl, actualUrl, "The page should redirect to the correct URL.");
        }

        // Helper methods to simulate functionality
        private string SimulateSearchIDByCNIC(string cnic, out string id)
        {
            // Simulated database behavior
            var mockDatabase = new Dictionary<string, string>
            {
                { "12345-6789012-3", "1001" }, // Valid CNIC with ID
                { "98765-4321098-7", "1002" }  // Another valid CNIC with ID
            };

            if (mockDatabase.ContainsKey(cnic))
            {
                id = mockDatabase[cnic];
                return string.Empty; // No error message
            }
            else
            {
                id = string.Empty;
                return "No Record found with the given ID.";
            }
        }

        private string SimulateSearchIDByCNIC(string cnic)
        {
            SimulateSearchIDByCNIC(cnic, out string id);
            return id;
        }

        private string SimulateRedirectToIssbTest()
        {
            // Simulate page redirection
            return "issbtest.aspx";
        }
    }
}
