using DSAPractice.Tree;

// BST
{
    var root = BSTNode.CreateTree();

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

    var diameter = BSTOperations.Diameter(root);

    Console.Write($"Diamter of the tree is : {diameter}");
    Console.WriteLine();
}


Console.ReadLine();