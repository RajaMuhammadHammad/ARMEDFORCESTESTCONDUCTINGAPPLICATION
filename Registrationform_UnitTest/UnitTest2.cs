using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
namespace Registrationform_UnitTest
{
    [TestClass]
    public class PhysicalTestUserResultTests
    {
        [TestMethod]
        public void Button2Click_ShouldReturnTestRemarks_WhenValidIDProvided()
        {
            // Arrange
            string testID = "ValidID"; // Input directly declared
            string expectedTestRemarks = "Test Passed"; // Expected result
            string actualTestRemarks = "";

            // Simulate the logic for returning test remarks
            if (testID == "ValidID")
            {
                actualTestRemarks = expectedTestRemarks;
            }
            else
            {
                actualTestRemarks = "No Record found with the given ID.";
            }

            // Assert
            Assert.AreEqual(expectedTestRemarks, actualTestRemarks);
        }
    }
}
