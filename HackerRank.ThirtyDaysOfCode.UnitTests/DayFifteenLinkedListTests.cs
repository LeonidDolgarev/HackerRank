namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayFifteenLinkedListTests
    {
        [Theory]
        [InlineData("4\r\n2\r\n3\r\n4\r\n1", "2 3 4 1 ")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayFifteenLinkedList.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
