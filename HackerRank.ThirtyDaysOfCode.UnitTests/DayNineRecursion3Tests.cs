namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayNineRecursion3Tests
    {
        [Theory]
        [InlineData("3", "6\r\n")]
        [InlineData("11", "39916800\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayNineRecursion3.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
