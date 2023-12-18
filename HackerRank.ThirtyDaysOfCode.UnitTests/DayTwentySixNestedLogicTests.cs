namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentySixNestedLogicTests
    {
        [Theory]
        [InlineData("9 6 2015\r\n6 6 2015", "45")]
        [InlineData("8 4 12\r\n1 1 1", "10000")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentySixNestedLogic.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
