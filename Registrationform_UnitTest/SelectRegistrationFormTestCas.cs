using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project;
using System;

namespace Registrationform_UnitTest
{
    [TestClass]
    public class SelectRegistrationFormTestCas
    {
        [TestMethod]
        public void Button1_Click_RedirectsToNavyRegistration()
        {
            // Arrange
            var page = new SelectRegistrationForm();
            var mockRedirect = new Mock<Action<string>>();
            page.RedirectMethod = mockRedirect.Object;

            // Act
            page.Button1_Click(null, null);

            // Assert
            mockRedirect.Verify(r => r("NavyRegistration.aspx"), Times.Once);
        }

        [TestMethod]
        public void Button2_Click_RedirectsToSlip()
        {
            // Arrange
            var page = new SelectRegistrationForm();
            var mockRedirect = new Mock<Action<string>>();
            page.RedirectMethod = mockRedirect.Object;

            // Act
            page.Button2_Click(null, null);

            // Assert
            mockRedirect.Verify(r => r("Slip.aspx"), Times.Once);
        }

        [TestMethod]
        public void Button4_Click_RedirectsToRegistrationForm()
        {
            // Arrange
            var page = new SelectRegistrationForm();
            var mockRedirect = new Mock<Action<string>>();
            page.RedirectMethod = mockRedirect.Object;

            // Act
            page.Button4_Click(null, null);

            // Assert
            mockRedirect.Verify(r => r("Registrationform.aspx"), Times.Once);
        }
    }
}
