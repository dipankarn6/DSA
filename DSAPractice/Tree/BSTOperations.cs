
namespace DSAPractice.Tree
{
    internal class BSTOperations
    {
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

            bool selfBalanced = root.data > root.left.data && root.data < root.right.data;

            return leftBalanced && rigthBalanced && selfBalanced;
        }
    }
}
