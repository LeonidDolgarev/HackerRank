namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DaySevenArrays
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> reversed = new(arr);
                reversed.Reverse();

                Console.WriteLine(string.Join(" ", reversed));
            }
        }
    }
}
