namespace HackerRank.ThirtyDaysOfCode.UnitTests
{
    public class DayTwelveInheritanceTests
    {
        [Theory]
        [InlineData("Heraldo Memelli 8135627\r\n2\r\n100 80", "Name: Memelli, Heraldo\nID: 8135627\r\nGrade: O\n\r\n")]
        public void Solution_Main_ShouldPrintResult_WhenInputValues(string input, string expected)
        {
            // Arrange
            StringReader reader = new(input);
            Console.SetIn(reader);

            StringWriter writer = new();
            Console.SetOut(writer);

            // Act
            DayTwelveInheritance.Solution.Main();

            // Assert
            Assert.Equal(expected, writer.ToString());
        }
    }
}
