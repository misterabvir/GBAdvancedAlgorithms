using BalancedBinaryTreeLib;

ColorBinaryTree<int> tree = new ColorBinaryTree<int>();

tree.Add(10);
tree.Add(20);
tree.Add(5);
tree.Add(4);
tree.Add(4);
tree.Add(3);
tree.Add(18);
tree.Add(24);
tree.Add(35);

Console.WriteLine("Red-Black Tree:");
tree.PrintTree();

Console.WriteLine("Contains 18: " + tree.Contains(18));
Console.WriteLine("Contains 30: " + tree.Contains(30));

tree.Remove(24);

Console.WriteLine("After removing 20:");
tree.PrintTree();

/* OUTPUT:
 * Red-Black Tree:
 * Root: 5(Black)
 * |       L-- 4(Red)
 * |       |       L-- 3(Red)
 * |       R-- 20(Red)
 * |               L-- 10(Red)
 * |               |       R-- 18(Red)
 * |               R-- 24(Red)
 * |                       R-- 35(Red)
 * Contains 18: True
 * Contains 30: False
 * After removing 20:
 * Root: 5(Black)
 * |       L-- 4(Black)
 * |       |       L-- 3(Red)
 * |       R-- 35(Black)
 * |               L-- 20(Red)
 * |               |       L-- 10(Red)
 * |               |       |       R-- 18(Red)
 */