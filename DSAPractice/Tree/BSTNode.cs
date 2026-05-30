namespace DSAPractice.Tree
{
    internal class BSTNode
    {
        public readonly int data;
        public BSTNode? left;
        public BSTNode? right;

        internal BSTNode(int value)
        {
            this.data = value;
            this.left = null;
            this.right = null;
        }

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


            root.right.right.left = new BSTNode(8);
            root.right.right.right = new BSTNode(13);

            return root;
        }
    }
}
