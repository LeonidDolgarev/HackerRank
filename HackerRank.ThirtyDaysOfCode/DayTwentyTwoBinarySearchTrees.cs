namespace HackerRank.ThirtyDaysOfCode
{
    public sealed class DayTwentyTwoBinarySearchTrees
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
            private static int getHeight(in Node? root)
            {
                //Write your code here
                if (root is null) return -1;

                int leftHeight = getHeight(root.left);
                int rightHeight = getHeight(root.right);

                return Math.Max(leftHeight, rightHeight) + 1;
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
                int height = getHeight(root);
                Console.WriteLine(height);
            }
        }
    }
}
