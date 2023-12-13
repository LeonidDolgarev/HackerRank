namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyOneGenericsTests
    {
        [Theory]
        [InlineData("3\r\n1\r\n2\r\n3\r\n2\r\nHello\r\nWorld", "1\r\n2\r\n3\r\nHello\r\nWorld\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyOneGenerics.Printer.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
