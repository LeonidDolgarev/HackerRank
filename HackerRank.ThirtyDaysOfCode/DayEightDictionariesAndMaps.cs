namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayEightDictionariesAndMaps
    {
        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                Dictionary<string, string> phoneBook = new();
                for (int i = 0; i < n; i++)
                {
                    var line = Console.ReadLine()?.Trim().Split(" ");
                    string name = line[0];
                    string phoneNumber = line[1];
                    phoneBook.Add(name, phoneNumber);
                }

                string? query;
                while ((query = Console.ReadLine()?.Trim()) is not null)
                {
                    if (phoneBook.ContainsKey(query)) Console.WriteLine($"{query}={phoneBook[query]}");
                    else Console.WriteLine("Not found");
                }
            }
        }
    }
}
