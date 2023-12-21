namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyNineBitwiseAndTests
    {
        [Theory]
        [InlineData("3\r\n5 2\r\n8 5\r\n2 2", "1\r\n4\r\n0\r\n")]
        [InlineData("2\r\n9 2\r\n8 3", "1\r\n2\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyNineBitwiseAnd.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
