namespace LeetCode.Core.Entities;

public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    
    public static TreeNode? BuildFromArray(int?[] arr) {
        if (arr == null || arr.Length == 0 || arr[0] == null) {
            return null;
        }
        
        TreeNode root = new TreeNode(arr[0]!.Value);
        System.Collections.Generic.Queue<TreeNode> queue = new System.Collections.Generic.Queue<TreeNode>();
        queue.Enqueue(root);
        
        int i = 1;
        while (queue.Count > 0 && i < arr.Length) {
            TreeNode current = queue.Dequeue();
            
            if (i < arr.Length && arr[i].HasValue) {
                current.left = new TreeNode(arr[i]!.Value);
                queue.Enqueue(current.left);
            }
            i++;
            
            if (i < arr.Length && arr[i].HasValue) {
                current.right = new TreeNode(arr[i]!.Value);
                queue.Enqueue(current.right);
            }
            i++;
        }
        
        return root;
    }
    
    public override string ToString() {
        var result = new System.Text.StringBuilder();
        result.Append("[");
        
        System.Collections.Generic.Queue<TreeNode?> queue = new System.Collections.Generic.Queue<TreeNode?>();
        queue.Enqueue(this);
        bool first = true;
        
        while (queue.Count > 0) {
            TreeNode? node = queue.Dequeue();
            
            if (!first) {
                result.Append(",");
            }
            first = false;
            
            if (node == null) {
                result.Append("null");
            } else {
                result.Append(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
        
        // Remove trailing nulls
        string str = result.ToString();
        while (str.EndsWith(",null")) {
            str = str.Substring(0, str.Length - 5);
        }
        
        result.Clear();
        result.Append(str);
        result.Append("]");
        return result.ToString();
    }
}

