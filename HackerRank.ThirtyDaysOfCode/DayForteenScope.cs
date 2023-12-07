namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayFourteenScope
    {
        private sealed class Difference
        {
            private int[] elements;
            public int maximumDifference;

            // Add your code here
            public Difference(int[] a)
            {
                elements = a;
            }

            public void computeDifference()
            {
                int minElement = int.MaxValue;
                int maxElement = int.MinValue;

                for (int i = 0; i < elements.Length; i++)
                {
                    minElement = Math.Min(elements[i], minElement);
                    maxElement = Math.Max(elements[i], maxElement);
                }

                maximumDifference = maxElement - minElement;
            }
        }

        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                Convert.ToInt32(Console.ReadLine());

                int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                Difference d = new Difference(a);

                d.computeDifference();

                Console.Write(d.maximumDifference);
            }
        }
    }
}
