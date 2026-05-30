namespace DSAPractice.BST
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
    }
}
