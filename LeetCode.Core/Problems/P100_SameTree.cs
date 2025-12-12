using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P100_SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    { 
        if (p == null && q == null)
            return true;

        if (p == null || q == null)
            return false;
        
        if(p.val == q.val)
            return true;
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}