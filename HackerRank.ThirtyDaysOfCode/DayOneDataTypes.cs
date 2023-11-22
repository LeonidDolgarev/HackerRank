namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayOneDataTypes
    {
        public sealed class Solution
        {
            public const int i = 4;
            public const double d = 4.0;
            public const string s = "HackerRank ";

            public static void Main(string[] args)
            {
                // Declare second integer, double, and String variables.
                int val1;
                double val2;
                string? val3;

                // Read and save an integer, double, and String to your variables.
                val1 = Convert.ToInt32(Console.ReadLine());
                val2 = Convert.ToDouble(Console.ReadLine());
                val3 = Console.ReadLine();

                // Print the sum of both integer variables on a new line.
                Console.WriteLine(val1 + i);

                // Print the sum of the double variables on a new line.
                Console.WriteLine(string.Format("{0:0.0}", val2 + d));

                // Concatenate and print the String variables on a new line
                // The 's' variable above should be printed first.
                Console.WriteLine(string.Concat(s, val3));
            }
        }
    }
}
