namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwoOperators
    {
        private sealed class Result
        {
            /*
             * Complete the 'solve' function below.
             *
             * The function accepts following parameters:
             *  1. DOUBLE meal_cost
             *  2. INTEGER tip_percent
             *  3. INTEGER tax_percent
             */

            public static void Solve(double meal_cost, int tip_percent, int tax_percent)
            {
                double tip = tip_percent * meal_cost / 100;
                double tax = meal_cost * tax_percent / 100;
                double total_cost = meal_cost + tip + tax;

                Console.WriteLine(Math.Round(total_cost));
            }
        }

        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

                int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

                int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

                Result.Solve(meal_cost, tip_percent, tax_percent);
            }
        }
    }
}
