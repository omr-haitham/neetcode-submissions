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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new();
        if (root == null) {
            return [];
        } else if (root.left == null && root.right == null) {
            return [[root.val]];
        } else {
            TreeNode currNode = new();
            int size = 0;
            List<int> lvl = new();
            Queue<TreeNode> ordrQ = new();
            ordrQ.Enqueue(root);
            while (ordrQ.Count > 0) {
                size = ordrQ.Count();
                for (int i = 0; i < size; i++) {
                    currNode = ordrQ.Dequeue();
                    if (currNode.left != null)
                        ordrQ.Enqueue(currNode.left);
                    if (currNode.right != null)
                        ordrQ.Enqueue(currNode.right);
                    lvl.Add(currNode.val);
                }
                res.Add(lvl);
                lvl = new();
            }
        }
        return res;
    }
}
