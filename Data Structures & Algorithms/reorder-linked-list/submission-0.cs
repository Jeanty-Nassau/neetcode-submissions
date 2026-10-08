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
    public void ReorderList(ListNode head) {
        // find midpoint (use tortoise hare algorithm)
        ListNode slow = head;// midpoint
        ListNode fast = head;

        while(fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reverse second half starting at midpoint
        ListNode c = slow.next;
        ListNode p = null;

        slow.next = null;

        while(c is not null)
        {
            ListNode t = c.next;
            c.next = p;
            p = c;
            c = t;
        }

        // merge the two halves.
        ListNode first = head;
        ListNode second = p;

        while(second is not null)
        {
            ListNode t1 = first.next; // save the link
            ListNode t2 = second.next; // save the link

            first.next = second;
            second.next = t1;

            // move pointers on.
            first = t1;
            second = t2;
        }
    }
}
