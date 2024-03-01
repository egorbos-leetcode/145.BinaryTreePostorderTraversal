using TreeNode = BinaryTree.TreeNode<int>;

namespace Solution;

public static class Solution
{
    public static IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        if (root is null) return list;

        var visited = new HashSet<TreeNode>();
        var stack = new Stack<TreeNode>();
        
        var current = root;
        while (current is not null)
        {
            stack.Push(current);
            current = current.left;
        }

        while (stack.Count > 0) {
            var node = stack.Pop();

            if (node.right is null || visited.Contains(node)) {
                list.Add(node.val);
                visited.Remove(node);
            }
            else
            {
                visited.Add(node);
                stack.Push(node);
                current = node.right;

                while (current is not null) {
                    stack.Push(current);
                    current = current.left;
                }
            }
        }

        return list;
    }
}
