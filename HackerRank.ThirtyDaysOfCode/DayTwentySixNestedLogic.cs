using System.Globalization;

namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentySixNestedLogic
    {
        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                string[] formats = { "d M yyyy", "d M yy", "d M y" };
                DateTime returnedDate = DateTime.ParseExact(Console.ReadLine(), formats, CultureInfo.InvariantCulture);
                DateTime dueDate = DateTime.ParseExact(Console.ReadLine(), formats, CultureInfo.InvariantCulture);
                int fine = calculateFine(returnedDate, dueDate);

                Console.Write(fine);

                int calculateFine(in DateTime returnedDate, in DateTime dueDate)
                {
                    if (dueDate > returnedDate)
                        return 0;

                    if (returnedDate.Month == dueDate.Month)
                        return (returnedDate.Day - dueDate.Day) * 15;

                    if (returnedDate.Year == dueDate.Year)
                        return (returnedDate.Month - dueDate.Month) * 500;

                    return 10000;
                }
            }
        }
    }
}
