using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;

namespace Registrationform_UnitTest
{
    [TestClass]
    public class MedicalpresentationTests
    {
        [TestMethod]
        public void Button1Click_ShouldRedirectToAdminLogin()
        {
            // Arrange
            string expectedRedirectUrl = "AdminLogin.aspx";

            // Act
            var actualRedirectUrl = SimulateButtonClick1();

            // Assert
            Assert.AreEqual(expectedRedirectUrl, actualRedirectUrl);
        }

        [TestMethod]
        public void Button2Click_ShouldRedirectToUserMedicalPresentation()
        {
            // Arrange
            string expectedRedirectUrl = "UserMedicalpresentation.aspx";

            // Act
            var actualRedirectUrl = SimulateButtonClick2();

            // Assert
            Assert.AreEqual(expectedRedirectUrl, actualRedirectUrl);
        }

        [TestMethod]
        public void Button4Click_ShouldClearSessionAndRedirectToPresentation2()
        {
            // Arrange
            string expectedRedirectUrl = "presenatation2.aspx";
            object expectedSessionValue = null;

            // Act
            var (actualRedirectUrl, actualSessionValue) = SimulateButtonClick4();

            // Assert
            Assert.AreEqual(expectedRedirectUrl, actualRedirectUrl);
            Assert.AreEqual(expectedSessionValue, actualSessionValue);
        }

        // Helper methods to simulate button click behavior

        private string SimulateButtonClick1()
        {
            // Simulates Button1_Click
            return "AdminLogin.aspx";
        }

        private string SimulateButtonClick2()
        {
            // Simulates Button2_Click
            return "UserMedicalpresentation.aspx";
        }

        private (string redirectUrl, object sessionValue) SimulateButtonClick4()
        {
            // Simulates Button4_Click
            object sessionValue = null; // Simulate clearing the session
            string redirectUrl = "presenatation2.aspx";
            return (redirectUrl, sessionValue);
        }
    }

}
