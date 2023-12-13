namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayNineteenInterfacesTests
    {
        [Theory]
        [InlineData("6", "I implemented: AdvancedArithmetic\r\n12\r\n")]
        [InlineData("1", "I implemented: AdvancedArithmetic\r\n1\r\n")]
        [InlineData("20", "I implemented: AdvancedArithmetic\r\n42\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValue(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };

            // Act
            DayNineteenInterfaces.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
