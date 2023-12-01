namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTenBinaryNumbersTests
    {
        [Theory]
        [InlineData("5", "1\r\n")]
        [InlineData("6", "2\r\n")]
        [InlineData("13", "2\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTenBinaryNumbers.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
