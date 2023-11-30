namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayNineRecursion3
    {
        public sealed class Result
        {
            /*
             * Complete the 'factorial' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER n as parameter.
             */

            public static int factorial(int n)
            {
                if (n <= 1) return 1;
                return n * factorial(n - 1);
            }

        }

        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.factorial(n);

                Console.WriteLine(result);
            }
        }
    }
}
