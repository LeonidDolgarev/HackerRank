namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayFourClassVsInstance
    {
        private class Person
        {
            public int age;
            public Person(int initialAge)
            {
                // Add some more code to run some checks on initialAge
                if (initialAge < 0)
                {
                    Console.WriteLine("Age is not valid, setting age to 0.");
                    return;
                }
                age = initialAge;
            }
            public void amIOld()
            {
                // Do some computations in here and print out the correct statement to the console
                string result = age switch
                {
                    < 13 => "You are young.",
                    >= 13 and < 18 => "You are a teenager.",
                    _ => "You are old."
                };

                Console.WriteLine(result);
            }

            public void yearPasses()
            {
                // Increment the age of the person in here
                age++;
            }
        }

        public static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
}
