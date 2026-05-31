using DSAPractice.Tree;

// BST
{
    var root = TreeNode.CreateTree();

    //Console.WriteLine("BFS - Level Order");

    //BST.LevelOrder(root);

    //Console.WriteLine("DFS - InOrder");

    //BST.InOrder(root);

    //Console.WriteLine();
    //Console.WriteLine("DFS - PreOrder");

    //BST.PreOrder(root);

    //Console.WriteLine();
    //Console.WriteLine("DFS - PostOrder");

    //BST.PostOrder(root);

    //Console.WriteLine();

    //int ans = BSTOperations.MaxDepth(root);

    //Console.Write($"Max Depth of the tree: {ans}");
    //Console.WriteLine();

    //var isBalanced = BSTOperations.IsBalanced(root);

    //Console.Write($"Tree is balanced: {isBalanced}");
    //Console.WriteLine();

    //var isBalanced = TreeOperations.IsBalancedWithHeight(root);

    //Console.Write($"Tree is balanced: {isBalanced != -1}");
    //Console.WriteLine();

    //int diameter = Int32.MinValue;
    //TreeOperations.Diameter(root, ref diameter);
    //Console.Write($"Diamter of the tree is : {diameter}");
    //Console.WriteLine();

    //int max = Int32.MinValue;
    //TreeOperations.MaxPathSum(root, ref max);
    //Console.WriteLine($"Max path sum of the tree is : {max}");
    //Console.WriteLine();

    var tree1 = TreeNode.CreateTree();
    var tree2 = TreeNode.CreateTree2();
    
    Console.WriteLine($"Are the trees identical : {TreeOperations.AreIdentical(tree1, tree2)}");
    Console.WriteLine();
}


Console.ReadLine();