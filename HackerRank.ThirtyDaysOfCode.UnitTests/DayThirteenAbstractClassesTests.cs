namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayThirteenAbstractClassesTests
    {
        [Theory]
        [InlineData("The Alchemist\r\nPaulo Coelho\r\n248", "Title: The Alchemist\r\nAuthor: Paulo Coelho\r\nPrice: 248\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayThirteenAbstractClasses.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
