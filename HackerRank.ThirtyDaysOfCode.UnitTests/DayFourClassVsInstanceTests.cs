namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayFourClassVsInstanceTests
    {
        [Theory]
        [InlineData("4\r\n-1\r\n10\r\n16\r\n18", "Age is not valid, setting age to 0.\r\nYou are young.\r\nYou are young.\r\n\r\nYou are young.\r\nYou are a teenager.\r\n\r\nYou are a teenager.\r\nYou are old.\r\n\r\nYou are old.\r\nYou are old.\r\n\r\n")]
        public void Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayFourClassVsInstance.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
