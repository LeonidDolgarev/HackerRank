namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentyThreeBstLevelOrderTraversal
    {
        private sealed class Node
        {
            public Node? left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        public sealed class Solution
        {
            private static void levelOrder(Node? root)
            {
                //Write your code here
                var queue = new Queue<Node?>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    Node? node = queue.Dequeue();
                    Console.Write($"{node?.data} ");

                    if (node?.left is not null) queue.Enqueue(node.left);
                    if (node?.right is not null) queue.Enqueue(node.right);
                }
            }

            private static Node insert(Node? root, int data)
            {
                if (root == null)
                {
                    return new Node(data);
                }
                else
                {
                    Node cur;
                    if (data <= root.data)
                    {
                        cur = insert(root.left, data);
                        root.left = cur;
                    }
                    else
                    {
                        cur = insert(root.right, data);
                        root.right = cur;
                    }
                    return root;
                }
            }

            public static void Main(String[] args)
            {
                Node? root = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    root = insert(root, data);
                }
                levelOrder(root);
            }
        }
    }
}
