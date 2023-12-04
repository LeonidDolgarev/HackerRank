namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayThirteenAbstractClasses
    {
        private abstract class Book
        {
            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        //Write MyBook class
        private sealed class MyBook : Book
        {
            private readonly int _price;

            internal MyBook(in String title, in String author, int price)
                : base(title, author)
            {
                _price = price;
            }

            public override void display()
            {
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Price: {_price}");
            }
        }

        public sealed class Solution
        {
            public static void Main(String[] args)
            {
                String title = Console.ReadLine();
                String author = Console.ReadLine();
                int price = Int32.Parse(Console.ReadLine());
                Book new_novel = new MyBook(title, author, price);
                new_novel.display();
            }
        }
    }
}
