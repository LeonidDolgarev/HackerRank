namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwentyFiveRunningTimeAndComplexityTests
    {
        [Theory]
        [InlineData("3\r\n12\r\n5\r\n7", "Not prime\r\nPrime\r\nPrime\r\n")]
        [InlineData("2\r\n31\r\n33", "Prime\r\nNot prime\r\n")]
        [InlineData("30\r\n1\r\n4\r\n9\r\n16\r\n25\r\n36\r\n49\r\n64\r\n81\r\n100\r\n121\r\n144\r\n169\r\n196\r\n225\r\n256\r\n289\r\n324\r\n361\r\n400\r\n441\r\n484\r\n529\r\n576\r\n625\r\n676\r\n729\r\n784\r\n841\r\n907", "Not prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nNot prime\r\nPrime\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayTwentyFiveRunningTimeAndComplexity.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
