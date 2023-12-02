namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayElevenTwoDimensionalArrays
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < 6; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }

                int max = int.MinValue;
                int n = arr.Count - 3 + 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        max = Math.Max(max, hourglassSum(ref arr, i, j));
                    }
                }

                Console.WriteLine(max);

                int hourglassSum(ref List<List<int>> arr, int i, int j) =>
                    arr[i][j] + arr[i][j + 1] + +arr[i][j + 2]
                    + arr[i + 1][j + 1]
                    + arr[i + 2][j] + arr[i + 2][j + 1] + +arr[i + 2][j + 2];
            }
        }
    }
}
