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
    public int MaxPathSum(TreeNode root) {
        TreeNode node = root;
        int max = node.val;
        Traverse(node, ref max);
        return max;
    }
    int Traverse(TreeNode node , ref int currentMax)
    {
        int lTraversal = node.left?.val ?? 0;
        int rTraversal = node.right?.val ?? 0;

        if (currentMax < node.val + (lTraversal) + (rTraversal))
            currentMax = node.val + (lTraversal) + (rTraversal);
        if (currentMax < node.val + (lTraversal > rTraversal ? lTraversal : rTraversal) )
        {
            currentMax = node.val + (lTraversal > rTraversal ? lTraversal : rTraversal);
            Console.WriteLine("ternary max: " + currentMax);
        }
        if (node.val > currentMax)
            currentMax = node.val;
        
        if (node.left != null)
            lTraversal =Traverse(node.left, ref currentMax);
        if (node.right != null)
            rTraversal = Traverse(node.right, ref currentMax);
        if (currentMax < node.val + lTraversal + rTraversal)
            currentMax = node.val + lTraversal + rTraversal;
        return node.val + Math.Max(lTraversal, rTraversal);
    }
}
