/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if(root==null)
        {
            return false;
        }
        else
        {
            if(root.val==sum && root.left==null &&root.right==null)
                return true;
        }
        if(root.left!=null)
        {
            if(HasPathSum(root.left, sum-root.val))
                return true;
        }
        if(root.right!=null)
        {
            if(HasPathSum(root.right, sum-root.val))
                return true;
        }
        return false;
    }
}
