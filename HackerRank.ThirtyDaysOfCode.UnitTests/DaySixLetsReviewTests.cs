namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DaySixLetsReviewTests
    {
        [Theory]
        [InlineData("2\r\nHacker\r\nRank", "Hce akr\r\nRn ak\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DaySixLetsReview.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
