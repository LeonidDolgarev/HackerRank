namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentySortingTests
    {
        [Theory]
        [InlineData("3\r\n1 2 3", "Array is sorted in 0 swaps.\r\nFirst Element: 1\r\nLast Element: 3\r\n")]
        [InlineData("3\r\n3 2 1", "Array is sorted in 3 swaps.\r\nFirst Element: 1\r\nLast Element: 3\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentySorting.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
