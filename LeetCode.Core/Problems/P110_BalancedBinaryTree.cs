using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P110_BalancedBinaryTree
{
    public bool IsBalanced(TreeNode root) {
        return HeightOrUnbalanced(root) != -1;
    }
    
    private int HeightOrUnbalanced(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = HeightOrUnbalanced(node.left);
        if (left == -1)
            return -1;

        int right = HeightOrUnbalanced(node.right);
        if (right == -1)
            return -1;

        if (Math.Abs(left - right) > 1)
            return -1;

        return Math.Max(left, right) + 1;
    }
}