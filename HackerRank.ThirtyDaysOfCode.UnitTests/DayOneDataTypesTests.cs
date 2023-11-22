namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayOneDataTypesTests
    {
        [Theory]
        [InlineData(12, 4.0, "is the best place to learn and practice coding!")]
        [InlineData(1000, 100.0, "is a technology company that focuses on competitive programming challenges for both consumers and businesses.")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(int val1, double val2, string val3)
        {
            // Arrange
            string[] values = { val1.ToString(), string.Format("{0:0.0}", val2), val3 };
            string s = string.Join(Environment.NewLine, values);
            StringReader reader = new(s);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            string[] args = { };
            string expected = string.Concat(
                val1 + DayOneDataTypes.Solution.i, Environment.NewLine,
                string.Format("{0:0.0}", val2 + DayOneDataTypes.Solution.d),
                Environment.NewLine,
                DayOneDataTypes.Solution.s, val3, Environment.NewLine);

            // Act
            DayOneDataTypes.Solution.Main(args);

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
