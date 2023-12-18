namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyFourMoreLinkedListsTests
    {
        [Theory]
        [InlineData("6\r\n1\r\n2\r\n2\r\n3\r\n3\r\n4", "1 2 3 4 ")]
        [InlineData("20\r\n3\r\n9\r\n9\r\n11\r\n11\r\n11\r\n11\r\n89\r\n89\r\n100\r\n100\r\n101\r\n102\r\n103\r\n108\r\n200\r\n250\r\n250\r\n250\r\n250", "3 9 11 89 100 101 102 103 108 200 250 ")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyFourMoreLinkedLists.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
