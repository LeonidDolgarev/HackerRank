namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayNineteenInterfaces
    {
        public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }

        public sealed class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) sum += i;
                }

                return sum;
            }
        }

        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int n = Int32.Parse(Console.ReadLine());
                AdvancedArithmetic myCalculator = new Calculator();
                int sum = myCalculator.divisorSum(n);
                Console.WriteLine("I implemented: AdvancedArithmetic\r\n" + sum);
            }
        }
    }
}
