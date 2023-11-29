namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayEightDictionariesAndMapsTests
    {
        [Theory]
        [InlineData("3\r\nsam 99912222\r\ntom 11122222\r\nharry 12299933\r\nsam\r\nedward\r\nharry", "sam=99912222\r\nNot found\r\nharry=12299933\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayEightDictionariesAndMaps.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
