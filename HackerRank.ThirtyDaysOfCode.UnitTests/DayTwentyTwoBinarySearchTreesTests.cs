namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyTwoBinarySearchTreesTests
    {
        [Theory]
        [InlineData("7\r\n3\r\n5\r\n2\r\n1\r\n4\r\n6\r\n7", "3\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyTwoBinarySearchTrees.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
