namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTenBinaryNumbers
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                string s = Convert.ToString(n, 2);
                int max = 0;
                int k = 0;
                foreach (char c in s)
                {
                    if (c == '1')
                    {
                        k++;
                        if (k > max) max = k;
                    }
                    else k = 0;
                }

                // More performant solution but less readable
                //int max = 0; // Initialize the maximum number of consecutive 1s
                //int k = 0; // Initialize the current count of consecutive 1s
                //while (n > 0)
                //{ // Loop until n becomes zero
                //    n = n & (n << 1); // Perform a bitwise AND operation with n and n left-shifted by one bit
                //    k++; // Increment the count
                //    max = Math.Max(max, k); // Update the maximum if needed
                //}

                Console.WriteLine(max);
            }
        }
    }
}
