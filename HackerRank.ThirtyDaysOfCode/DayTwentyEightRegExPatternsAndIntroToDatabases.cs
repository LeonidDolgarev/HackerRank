namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentyEightRegExPatternsAndIntroToDatabases
    {
        public sealed class Solution
        {
            public static void Main(string[] args)
            {
                int N = Convert.ToInt32(Console.ReadLine().Trim());

                var names = new List<string>();
                for (int NItr = 0; NItr < N; NItr++)
                {
                    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                    string firstName = firstMultipleInput[0];

                    string emailID = firstMultipleInput[1];

                    if (emailID.EndsWith("@gmail.com")) names.Add(firstName);
                }

                names.Sort();
                names.ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
