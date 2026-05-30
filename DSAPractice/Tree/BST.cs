namespace DSAPractice.BST
{
    internal class BST
    {
        // create tree
        internal static BSTNode CreateTree()
        {
            var root = new BSTNode(6)
            {
                left = new BSTNode(4),
                right = new BSTNode(7)
            };

            root.left.left = new BSTNode(3);
            root.left.right = new BSTNode(5);


            root.right.left = new BSTNode(4);
            root.right.right = new BSTNode(9);

            return root;
        }

        // level order traversal - BFS

        internal static void LevelOrder(BSTNode root)
        {
            var queue = new Queue<BSTNode>();
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

        internal static void InOrder(BSTNode root)
        {
            if (root == null) return;

            InOrder(root.left);

            Console.Write(root.data + " ");

            InOrder(root.right);

        }

        internal static void PreOrder(BSTNode root)
        {
            if (root == null) return;

            Console.Write(root.data + " ");

            PreOrder(root.left);

            PreOrder(root.right);

        }

        internal static void PostOrder(BSTNode root)
        {
            if (root == null) return;

            PostOrder(root.left);

            PostOrder(root.right);

            Console.Write(root.data + " ");
        }

    }
}
