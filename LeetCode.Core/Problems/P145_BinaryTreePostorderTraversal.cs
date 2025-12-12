using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P145_BinaryTreePostorderTraversal
{
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        var result = new List<int>();
        OrderingPostTraversal(root, result);
        //result.Reverse();
        return result;
        
    }

    private void OrderingPostTraversal(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;
        
        OrderingPostTraversal(root.left, result);
        OrderingPostTraversal(root.right, result);
        result.Add(root.val);
    }
}