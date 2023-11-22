namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayZeroHelloWorldTests
    {
        private const string HelloWorld = "Hello, World.";

        [Theory]
        [InlineData("Welcome to 30 Days of Code!")]
        [InlineData("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.")]
        public void Solution_Main_ShouldPrintResult_WhenInputString(string inputString)
        {
            // Arrange
            StringReader reader = new(inputString);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };
            string expected = string.Concat(
                HelloWorld, Environment.NewLine,
                inputString, Environment.NewLine);

            // Act
            DayZeroHelloWorld.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
