namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DaySixteenExceptionsStringToIntegerTests
    {
        [Theory]
        [InlineData("3", "3")]
        [InlineData("za", "Bad String")]
        [InlineData("3134", "3134")]
        [InlineData("abc", "Bad String")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DaySixteenExceptionsStringToInteger.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
