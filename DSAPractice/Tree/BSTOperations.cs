
namespace DSAPractice.Tree
{
    internal class BSTOperations
    {
        // max depth/height
        internal static int MaxDepth(BSTNode root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            int ans = 1 + Math.Max(leftDepth, rightDepth);

            return ans;
        }

        // balanced check

        internal static bool IsBalanced(BSTNode root)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null) return true;

            bool leftBalanced = IsBalanced(root.left);
            bool rigthBalanced = IsBalanced(root.right);

            bool selfBalanced = Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) >= 1;

            return leftBalanced && rigthBalanced && selfBalanced;
        }

        // diameter of a tree
        internal static int Diameter(BSTNode root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return 1 + leftDepth + rightDepth;
        }
    }
}
