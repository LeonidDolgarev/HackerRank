namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DaySeventeenMoreExceptions
    {
        private sealed class Calculator
        {
            internal int power(int n, int p)
            {
                if (n < 0 || p < 0)
                    throw new ArgumentException("n and p should be non-negative");

                if (p == 0) return 1;

                int r = 1;
                while (p > 0)
                {
                    r *= n;
                    p--;
                }

                return r;
            }
        }

        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                Calculator myCalculator = new Calculator();
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    string[] num = Console.ReadLine().Split();
                    int n = int.Parse(num[0]);
                    int p = int.Parse(num[1]);
                    try
                    {
                        int ans = myCalculator.power(n, p);
                        Console.WriteLine(ans);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
            }
        }
    }
}
