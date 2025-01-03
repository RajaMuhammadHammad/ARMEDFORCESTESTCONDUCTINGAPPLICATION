using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace Project.Tests
{
    public class UserFinalResultTests
    {
        private readonly Mock<SqlConnection> mockConnection;
        private readonly Mock<SqlCommand> mockCommand;
        private readonly Mock<SqlDataReader> mockReader;
        private readonly UserFinalResult userFinalResult;

        public UserFinalResultTests()
        {
            mockConnection = new Mock<SqlConnection>();
            mockCommand = new Mock<SqlCommand>();
            mockReader = new Mock<SqlDataReader>();
            userFinalResult = new UserFinalResult();
        }

        [Fact]
        public void GetCombinedRemarks_ShouldReturnRemarks_WhenRecordExists()
        {
            // Arrange
            string testId = "123";
            string expectedRemarks = "This is a test remark.";

            // Mocking the SqlCommand behavior
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
            mockReader.Setup(m => m.HasRows).Returns(true);
            mockReader.Setup(m => m.Read()).Callback(() =>
            {
                mockReader.Setup(m => m["CombinedRemarks"]).Returns(expectedRemarks);
            });

            mockConnection.Setup(m => m.Open());
            mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = userFinalResult.GetCombinedRemarks(testId);

            // Assert
            Assert.Equal(expectedRemarks, result);
        }

        [Fact]
        public void GetFinalResults_ShouldReturnDataTable_WhenRecordsExist()
        {
            // Arrange
            string testId = "123";
            DataTable expectedTable = new DataTable();
            expectedTable.Columns.Add("Column1");
            expectedTable.Rows.Add("Test Data");

            // Mocking the SqlCommand behavior
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
            mockReader.Setup(m => m.HasRows).Returns(true);
            mockReader.Setup(m => m.Read()).Callback(() =>
            {
                mockReader.Setup(m => m["Column1"]).Returns("Test Data");
            });

            mockConnection.Setup(m => m.Open());
            mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = userFinalResult.GetFinalResults(testId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Data", result.Rows[0]["Column1"]);
        }

        [Fact]
        public void GetCombinedRemarks_ShouldReturnNull_WhenNoRecordFound()
        {
            // Arrange
            string testId = "999"; // An ID that doesn't exist in the mock database

            // Mocking the SqlCommand behavior
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
            mockReader.Setup(m => m.HasRows).Returns(false);

            mockConnection.Setup(m => m.Open());
            mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = userFinalResult.GetCombinedRemarks(testId);

            // Assert
            Assert.Null(result);
        }
    }
}
    