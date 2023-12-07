namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DaySixteenExceptionsStringToInteger
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                string S = Console.ReadLine();

                try
                {
                    int n = Int32.Parse(S);
                    Console.Write(n);
                }
                catch
                {
                    Console.Write("Bad String");
                }
            }
        }
    }
}
