namespace DSAPractice.Tree
{
    internal class TreeNode
    {
        public readonly int data;
        public TreeNode? left;
        public TreeNode? right;

        internal TreeNode(int value)
        {
            this.data = value;
            this.left = null;
            this.right = null;
        }

        // create tree
        internal static TreeNode CreateTree()
        {
            var root = new TreeNode(6)
            {
                left = new TreeNode(4),
                right = new TreeNode(7)
            };

            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(5);


            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(9);

            //root.left.left.left = new BSTNode(1);
            //root.left.left.left.left = new BSTNode(0);

            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(13);

            return root;
        }

        internal static TreeNode CreateTree2()
        {
            var root = new TreeNode(6)
            {
                left = new TreeNode(4),
                right = new TreeNode(7)
            };

            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(5);


            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(9);

            //root.left.left.left = new BSTNode(1);
            //root.left.left.left.left = new BSTNode(0);

            root.right.right.left = new TreeNode(8);

            return root;
        }
    }
}
