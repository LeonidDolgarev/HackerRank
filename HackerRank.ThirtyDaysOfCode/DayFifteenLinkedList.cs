namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayFifteenLinkedList
    {
        public sealed class Node
        {
            public int data;
            public Node? next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public sealed class Solution
        {
            public static Node? insert(Node? head, int data)
            {
                //Complete this method
                var node = new Node(data);
                if (head is null) return node;

                var tail = head;
                while (tail.next is not null)
                {
                    tail = tail.next;
                }

                tail.next = node;

                return head;
            }

            public static void display(Node head)
            {
                Node? start = head;
                while (start != null)
                {
                    Console.Write(start.data + " ");
                    start = start.next;
                }
            }
            public static void Main(String[] args)
            {
                Node? head = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    head = insert(head, data);
                }
                display(head);
            }
        }
    }
}
