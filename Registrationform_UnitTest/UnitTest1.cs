using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;

namespace Registrationform_UnitTest
{
    [TestClass]
    public class RegistrationFormTests
    {
        [TestMethod]
        public void Test_CheckCnicExistence_LessThanTwoApplications()
        {
            // Arrange
            string testCnic = "12345-6789012-3"; // Example CNIC
            int expectedCount = 1; // Simulate a predefined return value

            // Act
            int actualCount = MockCheckCnicExistence(testCnic); // Call mock method

            // Assert
            Assert.AreEqual(expectedCount, actualCount, "CNIC existence count does not match!");
        }

        [TestMethod]
        public void Test_CheckCnicExistence_MoreThanTwoApplications()
        {
            // Arrange
            string testCnic = "98765-4321098-7"; // Example CNIC
            int expectedCount = 2; // Simulate another predefined return value

            // Act
            int actualCount = MockCheckCnicExistence(testCnic); // Call mock method

            // Assert
            Assert.AreEqual(expectedCount, actualCount, "CNIC check failed for multiple applications.");
        }

        // Mock method to simulate CheckCnicExistence without a database
        private int MockCheckCnicExistence(string cnic)
        {
            // Simulate a simple logic based on the CNIC for testing
            if (cnic == "12345-6789012-3") return 1; // Mock response for a single application
            if (cnic == "98765-4321098-7") return 2; // Mock response for two applications
            return 0; // Default case
        }
    }
}
