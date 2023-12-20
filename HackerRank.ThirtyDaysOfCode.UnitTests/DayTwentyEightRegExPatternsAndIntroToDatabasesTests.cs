namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyEightRegExPatternsAndIntroToDatabasesTests
    {
        [Theory]
        [InlineData("6\r\nriya riya@gmail.com\r\njulia julia@julia.me\r\njulia sjulia@gmail.com\r\njulia julia@gmail.com\r\nsamantha samantha@gmail.com\r\ntanya tanya@gmail.com", "julia\r\njulia\r\nriya\r\nsamantha\r\ntanya\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyEightRegExPatternsAndIntroToDatabases.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
