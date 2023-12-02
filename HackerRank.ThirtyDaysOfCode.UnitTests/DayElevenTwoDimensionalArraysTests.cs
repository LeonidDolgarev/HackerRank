namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayElevenTwoDimensionalArraysTests
    {
        [Theory]
        [InlineData("1 1 1 0 0 0\r\n0 1 0 0 0 0\r\n1 1 1 0 0 0\r\n0 0 0 0 0 0\r\n0 0 0 0 0 0\r\n0 0 0 0 0 0", "7\r\n")]
        [InlineData("1 1 1 0 0 0\r\n0 1 0 0 0 0\r\n1 1 1 0 0 0\r\n0 0 2 4 4 0\r\n0 0 0 2 0 0\r\n0 0 1 2 4 0", "19\r\n")]
        [InlineData("-1 -1 0 -9 -2 -2\r\n-2 -1 -6 -8 -2 -5\r\n-1 -1 -1 -2 -3 -4\r\n-1 -9 -2 -4 -4 -5\r\n-7 -3 -3 -2 -9 -9\r\n-1 -3 -1 -2 -4 -5", "-6\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayElevenTwoDimensionalArrays.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
