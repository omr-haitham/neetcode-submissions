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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if(root == null) return res;
        res.Add(root.val);
        if (root.right == null && root.left == null)
            return res;
        int currLevel = 0;
        TreeNode curr = root;
        getVals(curr, res, currLevel);
        return res;
    }
    void getVals(TreeNode entry, List<int> res, int currLevel) {
        TreeNode curr = entry;
        int nodeLevel = currLevel;

        if (nodeLevel < res.Count) {
            if (entry.right != null) {
                getVals(entry.right, res, nodeLevel + 1);
            }
            if (entry.left != null)
                getVals(entry.left, res, nodeLevel + 1);

        } else {
            nodeLevel++;
            res.Add(entry.val);
            Console.WriteLine("val:" + entry.val + "lvl:" + nodeLevel + "lvlOnR:" + res.Count +
                              ", resAppended: " + res.Count);

            if (entry.right != null) {
                getVals(entry.right, res, nodeLevel);
            }
            if (entry.left != null)
                getVals(entry.left, res, nodeLevel);
        }
    }
}
