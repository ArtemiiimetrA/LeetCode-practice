using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P94_BinaryTreeInorderTraversal
{
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Travers(root, result);
        return result;
    }

    private void Travers(TreeNode node, IList<int> list)
    {
        if(node == null)
            return;
        
        Travers(node.left, list);
        list.Add(node.val);
        Travers(node.right, list);
    }
}