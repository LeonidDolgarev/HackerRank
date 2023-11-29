namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DaySevenArraysTests
    {
        [Theory]
        [InlineData("4\r\n1 4 3 2", "2 3 4 1\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DaySevenArrays.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
