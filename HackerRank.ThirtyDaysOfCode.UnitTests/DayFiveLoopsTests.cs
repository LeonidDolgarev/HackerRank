namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayFiveLoopsTests
    {
        [Theory]
        [InlineData("2", "2 x 1 = 2\r\n2 x 2 = 4\r\n2 x 3 = 6\r\n2 x 4 = 8\r\n2 x 5 = 10\r\n2 x 6 = 12\r\n2 x 7 = 14\r\n2 x 8 = 16\r\n2 x 9 = 18\r\n2 x 10 = 20\r\n")]
        [InlineData("3", "3 x 1 = 3\r\n3 x 2 = 6\r\n3 x 3 = 9\r\n3 x 4 = 12\r\n3 x 5 = 15\r\n3 x 6 = 18\r\n3 x 7 = 21\r\n3 x 8 = 24\r\n3 x 9 = 27\r\n3 x 10 = 30\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayFiveLoops.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
