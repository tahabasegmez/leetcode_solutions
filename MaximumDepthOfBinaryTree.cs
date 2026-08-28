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
    public int MaxDepth(TreeNode root) {
        int mode = 2;

        switch (mode)
        {
            case 1: 
            return MaxDepthIterative(root);

            case 2:
            return MaxDepthRecursive(root);
        }

        return 0;
    }

    public int MaxDepthIterative(TreeNode root)
    {
        if (root == null) return 0;
        int level = 0;
        
        int size = 0;
        TreeNode cur = new();

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                cur = queue.Dequeue();
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            level++;
        }
        
        return level;
    }

    public int MaxDepthRecursive(TreeNode root)
    {
        if (root == null) return 0;

        int left = 1 + MaxDepthRecursive(root.left);
        int right = 1 + MaxDepthRecursive(root.right);

        return Math.Max(left, right);
    }
}