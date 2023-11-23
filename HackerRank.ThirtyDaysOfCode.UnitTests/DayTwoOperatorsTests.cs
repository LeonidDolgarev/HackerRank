namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwoOperatorsTests
    {
        [Theory]
        [InlineData("12,00\r\n20\r\n8", "15\r\n")]
        [InlineData("15,50\r\n15\r\n10", "19\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwoOperators.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
