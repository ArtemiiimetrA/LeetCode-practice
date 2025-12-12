using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P144_BinaryTreePreorderTraversal
{
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        var result = new List<int>();
        OrderingTraversal(root, result);
        return result;
        
    }

    private void OrderingTraversal(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;
        
        result.Add(root.val);
        OrderingTraversal(root.left, result);
        OrderingTraversal(root.right, result);
    }
}