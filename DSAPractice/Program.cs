using DSAPractice.BST;

var root = BST.CreateTree();

Console.WriteLine("BFS - Level Order");

BST.LevelOrder(root);

Console.WriteLine("DFS - InOrder");

BST.InOrder(root);

Console.WriteLine();
Console.WriteLine("DFS - PreOrder");

BST.PreOrder(root);

Console.WriteLine();
Console.WriteLine("DFS - PostOrder");

BST.PostOrder(root);


Console.ReadLine();