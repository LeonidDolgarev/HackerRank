namespace HackerRank.ProblemSolving.UnitTests
{
    public class SolveMeFirstTests
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(100, 1000)]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(int val1, int val2)
        {
            // Arrange
            int[] values = { val1, val2 };
            string s = string.Join(Environment.NewLine, values);
            StringReader reader = new(s);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };
            int expected = val1 + val2;

            // Act
            SolveMeFirst.Solution.Main(args);

            // Assert
            Assert.Equal($"{expected}{Environment.NewLine}", writer.ToString());
        }
    }
}