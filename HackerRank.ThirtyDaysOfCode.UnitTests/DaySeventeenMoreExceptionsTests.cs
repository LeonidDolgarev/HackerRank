namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DaySeventeenMoreExceptionsTests
    {
        [Theory]
        [InlineData("4\r\n3 5\r\n2 4\r\n-1 -2\r\n-1 3", "243\r\n16\r\nn and p should be non-negative\r\nn and p should be non-negative\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DaySeventeenMoreExceptions.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
