namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyThreeBstLevelOrderTraversalTests
    {
        [Theory]
        [InlineData("6\r\n3\r\n5\r\n4\r\n7\r\n2\r\n1", "3 2 5 1 4 7 ")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyThreeBstLevelOrderTraversal.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
