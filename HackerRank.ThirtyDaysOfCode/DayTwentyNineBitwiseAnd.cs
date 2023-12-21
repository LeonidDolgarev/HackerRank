namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentyNineBitwiseAnd
    {
        public sealed class Result
        {
            /*
             * Complete the 'bitwiseAnd' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER N
             *  2. INTEGER K
             */
            public static int bitwiseAnd(int N, int K)
            {
                return ((K | (K - 1)) > N) ? K - 2 : K - 1;
            }
        }

        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int t = Convert.ToInt32(Console.ReadLine().Trim());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                    int count = Convert.ToInt32(firstMultipleInput[0]);

                    int lim = Convert.ToInt32(firstMultipleInput[1]);

                    int res = Result.bitwiseAnd(count, lim);

                    Console.WriteLine(res);
                }
            }
        }
    }
}
