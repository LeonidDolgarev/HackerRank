using System.Text;

namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DaySixLetsReview
    {
        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                int n = Convert.ToInt32(Console.ReadLine()?.Trim());
                bool isEven(int n) => n % 2 == 0;

                for (int i = 0; i < n; i++)
                {
                    string S = Console.ReadLine()?.Trim() ?? string.Empty;
                    StringBuilder odd = new();
                    StringBuilder even = new();

                    for (int j = 0; j < S.Length; j++)
                    {
                        if (isEven(j)) even.Append(S[j]);
                        else odd.Append(S[j]);
                    }

                    Console.WriteLine($"{even} {odd}");
                }
            }
        }
    }
}
