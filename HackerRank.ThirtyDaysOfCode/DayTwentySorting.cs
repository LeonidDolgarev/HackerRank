namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentySorting
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                // Write your code here
                int numberOfSwaps = BubbleSort(a, a.Count);

                Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
                Console.WriteLine($"First Element: {a.First()}");
                Console.WriteLine($"Last Element: {a.Last()}");
            }

            private static int BubbleSort(in List<int> a, int n)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        // Swap adjacent elements if they are in decreasing order
                        if (a[j] > a[j + 1])
                        {
                            swap(a, j, j + 1);
                            numberOfSwaps++;
                        }
                    }

                    // If no elements were swapped during a traversal, array is sorted
                    if (numberOfSwaps == 0)
                    {
                        break;
                    }
                }

                return numberOfSwaps;
            }

            private static void swap<T>(List<T> list, int i, int j) =>
                (list[i], list[j]) = (list[j], list[i]);
        }
    }
}
