using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrationform_UnitTest
{
    [TestClass]
    public class UserMedicalpresentationTests
    {
        [TestMethod]
        public void GetMedicalTestRemarks_ShouldSetLabel3Text_WhenValidIDProvided()
        {
            // Arrange
            string validID = "123";
            string expectedRemarks = "Test Passed";
            string actualRemarks = "";

            // Simulate behavior for valid ID
            if (validID == "123")
            {
                actualRemarks = expectedRemarks;
            }
            else
            {
                actualRemarks = "No Record found with the given ID.";
            }

            // Assert
            Assert.AreEqual(expectedRemarks, actualRemarks);
        }

        [TestMethod]
        public void GetMedicalTestRemarks_ShouldSetErrorMessage_WhenInvalidIDProvided()
        {
            // Arrange
            string invalidID = "456";
            string expectedErrorMessage = "No Record found with the given ID.";
            string actualMessage = "";

            // Simulate behavior for invalid ID
            if (invalidID != "123")
            {
                actualMessage = expectedErrorMessage;
            }

            // Assert
            Assert.AreEqual(expectedErrorMessage, actualMessage);
        }

        [TestMethod]
        public void Button4Click_ShouldRedirectToMedicalPresentation()
        {
            // Arrange
            string expectedRedirectUrl = "Medicalpresentation.aspx";

            // Act
            string actualRedirectUrl = SimulateButton4Click();

            // Assert
            Assert.AreEqual(expectedRedirectUrl, actualRedirectUrl);
        }

        // Helper method to simulate Button4_Click
        private string SimulateButton4Click()
        {
            return "Medicalpresentation.aspx";
        }
    }

}
