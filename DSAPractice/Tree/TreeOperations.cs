
namespace DSAPractice.Tree
{
    internal class TreeOperations
    {
        // max depth/height
        internal static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            int ans = 1 + Math.Max(leftDepth, rightDepth);

            return ans;
        }

        // balanced check

        internal static bool IsBalanced(TreeNode root) // n*n
        {
            if (root == null) return false;

            if (root.left == null && root.right == null) return true;

            bool leftBalanced = IsBalanced(root.left);
            bool rigthBalanced = IsBalanced(root.right);

            bool selfBalanced = Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) <= 1;

            return leftBalanced && rigthBalanced && selfBalanced;
        }

        internal static int IsBalancedWithHeight(TreeNode root) // n
        {
            if (root == null) return 0;

            int leftDepth = IsBalancedWithHeight(root.left);
            if (leftDepth == -1) return -1;

            int rightDepth = IsBalancedWithHeight(root.right);
            if (rightDepth == -1) return -1;

            if (Math.Abs(leftDepth - rightDepth) > 1) return -1;

            return 1 + Math.Max(leftDepth, rightDepth);
        }

        // diameter of a tree
        internal static int Diameter(TreeNode root, ref int maximum)
        {
            if (root == null) return 0;

            int leftDepth = Diameter(root.left, ref maximum);
            int rightDepth = Diameter(root.right, ref maximum);

            maximum = Math.Max(maximum, leftDepth + rightDepth);

            return 1 + Math.Max(leftDepth, rightDepth);
        }

        // Max path sum

        internal static int MaxPathSum(TreeNode root, ref int max)
        {
            if (root == null) return 0;

            int left = Math.Max(0, MaxPathSum(root.left, ref max));
            int right = Math.Max(0, MaxPathSum(root.right, ref max));

            max = Math.Max(max, root.data + left + right);

            return root.data + Math.Max(left, right);
        }

        // dentical check

        internal static bool AreIdentical(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null) return true;

            if ((tree1 == null && tree2 != null) || (tree1 != null && tree2 == null)) return false;

            return (tree1.data == tree2.data) && AreIdentical(tree1.left, tree2.left) && AreIdentical(tree1.right, tree2.right);
        }
    }
}
