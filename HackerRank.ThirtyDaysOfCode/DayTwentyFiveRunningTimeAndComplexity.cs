namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentyFiveRunningTimeAndComplexity
    {
        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(IsPrime(n) ? "Prime" : "Not prime");
                }

                bool IsPrime(int n)
                {
                    if (n <= 1) return false;
                    if (n == 2) return true;
                    if (n % 2 == 0) return false;

                    int sqrt = (int)Math.Floor(Math.Sqrt(n));

                    for (int i = 3; i <= sqrt; i += 2)
                    {
                        if (n % i == 0) return false;
                    }

                    return true;
                }
            }
        }
    }
}
