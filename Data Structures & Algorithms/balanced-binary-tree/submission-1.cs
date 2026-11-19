/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;
        if (root.left == null && root.right == null)
            return true;
        return traverse(root, 1).Value;
    }
    KeyValuePair<int, bool> traverse(TreeNode tN, int currDepth) {
        currDepth++;
        if (tN.right == null && tN.left == null)
            return new(currDepth, true);
        KeyValuePair<int, bool> DpthL = new(currDepth, true), DpthR = new(currDepth, true);
        if (tN.left != null) {
            DpthL = traverse(tN.left, currDepth);
        }
        if (tN.right != null) {
            DpthR = traverse(tN.right, currDepth);
        }
        if (!DpthL.Value || !DpthR.Value) {
            return new(currDepth, false);
        } else if (DpthR.Key == DpthL.Key){
            return new(DpthR.Key, true);
        }else if (Math.Abs(DpthR.Key - DpthL.Key) > 1) {
            return new(currDepth, false);
        }

        if (DpthR.Key > DpthL.Key) {
            return DpthR;
        }
        return DpthL;
    }
}
