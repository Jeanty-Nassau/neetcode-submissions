public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        int count = 0;
        var s = new Stack<TreeNode>();
        var current = root;

        while (current is not null || s.Count > 0) {
            // Visit all nodes in left subtree first
            while (current is not null) {
                s.Push(current);
                current = current.left;
            }

            // Process the next smallest node
            current = s.Pop();
            count++;

            if (count == k) {
                return current.val;
            }

            // Then process the right subtree
            current = current.right;
        }

        // The constraints guarantee that k is valid
        return -1;
    }
}