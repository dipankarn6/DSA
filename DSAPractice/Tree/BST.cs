namespace DSAPractice.Tree
{
    internal class BST
    {
        // level order traversal - BFS

        internal static void LevelOrder(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while(queue.Count > 0)
            {
                var front = queue.Dequeue();

                if (front == null)
                {
                    Console.WriteLine();
                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }
                }

                else
                {
                    Console.Write(front.data + " ");

                    if (front.left != null)
                    {
                        queue.Enqueue(front.left);
                    }

                    if (front.right != null)
                    {
                        queue.Enqueue(front.right);
                    }
                }
            }
        }

        // DFS - IN, PRE, POST - Recursive

        internal static void InOrder(TreeNode root)
        {
            if (root == null) return;

            InOrder(root.left);

            Console.Write(root.data + " ");

            InOrder(root.right);

        }

        internal static void PreOrder(TreeNode root)
        {
            if (root == null) return;

            Console.Write(root.data + " ");

            PreOrder(root.left);

            PreOrder(root.right);

        }

        internal static void PostOrder(TreeNode root)
        {
            if (root == null) return;

            PostOrder(root.left);

            PostOrder(root.right);

            Console.Write(root.data + " ");
        }

    }
}
