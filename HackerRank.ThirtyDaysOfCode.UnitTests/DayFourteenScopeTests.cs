namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayFourteenScopeTests
    {
        [Theory]
        //[InlineData("3\r\n1 2 5", "4")]
        [InlineData("5\r\n8 19 3 2 7", "17")]
        //[InlineData("5\r\n8 8 8 8 8", "0")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayFourteenScope.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
