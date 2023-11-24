namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayThreeIntroToConditionalStatementsTests
    {
        [Theory]
        [InlineData("3", "Weird\r\n")]
        [InlineData("24", "Not Weird\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayThreeIntroToConditionalStatements.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
