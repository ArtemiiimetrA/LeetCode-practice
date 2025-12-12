using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P111_MinimumDepthofBinaryTree
{
    public int MinDepth(TreeNode root) {
        if (root == null)
            return 0;

        if (root.left == null && root.right == null)
            return 1;

        if (root.left == null)
            return 1 + MinDepth(root.right);

        if (root.right == null)
            return 1 + MinDepth(root.left);

        // если оба есть — берём минимум
        return 1 + Math.Min(
            MinDepth(root.left),
            MinDepth(root.right)
        );
    }
    
    public int MinDepthQueue(TreeNode root)
    {
        if (root == null)
            return 0;

        var queue = new Queue<(TreeNode node, int depth)>();
        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();

            if (node.left == null && node.right == null)
                return depth;

            if (node.left != null)
                queue.Enqueue((node.left, depth + 1));

            if (node.right != null)
                queue.Enqueue((node.right, depth + 1));
        }

        return 0;
    }

}