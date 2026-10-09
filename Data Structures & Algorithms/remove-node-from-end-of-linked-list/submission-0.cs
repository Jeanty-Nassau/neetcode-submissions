/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new(0,head);
        ListNode left = dummy;
        ListNode right = head;

        // init pointer on n = 2
        while(n > 0 && right is not null)
        {
            right = right.next;
            n--;
        }

        // move left pointer to nth position
        while(right is not null)
        {
            left = left.next;
            right = right.next;
        }

        // delete node
        left.next = left.next.next;

        return dummy.next;
    }
}
