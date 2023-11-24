namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayThreeIntroToConditionalStatements
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int N = Convert.ToInt32(Console.ReadLine().Trim());
                var isEven = (int n) => n % 2 == 0;

                /*
                If  is odd, print Weird
                If  is even and in the inclusive range of 2 to 5, print Not Weird
                If  is even and in the inclusive range of 6 to 20, print Weird
                If  is even and greater than 20, print Not Weird
                */
                string? result = isEven(N) switch
                {
                    false => "Weird",
                    true when N >= 2 && N <= 5 => "Not Weird",
                    true when N >= 6 && N <= 20 => "Weird",
                    true when N > 20 => "Not Weird",
                    _ => null,
                };

                if (result is not null) Console.WriteLine(result);
            }
        }
    }
}
