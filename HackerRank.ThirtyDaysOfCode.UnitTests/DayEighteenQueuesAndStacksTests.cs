namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayEighteenQueuesAndStacksTests
    {
        [Theory]
        [InlineData("racecar", "The word, racecar, is a palindrome.")]
        [InlineData("yes", "The word, yes, is not a palindrome.")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayEighteenQueuesAndStacks.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
