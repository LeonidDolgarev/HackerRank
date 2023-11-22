namespace HackerRank.ProblemSolving
{
    public sealed class SolveMeFirst
    {
        public sealed class Solution
        {
            private static int SolveMeFirst(int a, int b)
            {
                return a + b;
            }

            public static void Main(String[] args)
            {
                int val1 = Convert.ToInt32(Console.ReadLine());
                int val2 = Convert.ToInt32(Console.ReadLine());
                int sum = SolveMeFirst(val1, val2);
                Console.WriteLine(sum);
            }
        }
    }
}
