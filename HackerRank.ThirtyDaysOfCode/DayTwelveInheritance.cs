namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwelveInheritance
    {
        private class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        private sealed class Student : Person
        {
            private int[] testScores;

            /*	
            *   Class Constructor
            *   
            *   Parameters: 
            *   firstName - A string denoting the Person's first name.
            *   lastName - A string denoting the Person's last name.
            *   id - An integer denoting the Person's ID number.
            *   scores - An array of integers denoting the Person's test scores.
            */
            // Write your constructor here
            internal Student(string firstName, string lastName, int id, int[] scores)
                : base(firstName, lastName, id)
            {
                testScores = scores;
            }

            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
            internal char Calculate() =>
                AverageScore() switch
                {
                    >= 90 and <= 100 => 'O',
                    >= 80 and < 90 => 'E',
                    >= 70 and < 80 => 'A',
                    >= 55 and < 70 => 'P',
                    >= 40 and < 50 => 'D',
                    < 40 => 'T',
                };

            private double AverageScore()
            {
                double sum = 0;
                foreach (var score in testScores.AsSpan())
                {
                    sum += score;
                }

                return sum / testScores.Length;
            }
        }

        public class Solution
        {
            public static void Main()
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }
        }
    }
}
