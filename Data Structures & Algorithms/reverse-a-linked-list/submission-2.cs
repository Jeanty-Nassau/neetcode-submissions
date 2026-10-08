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
    public ListNode ReverseList(ListNode head) {
        ListNode c = head;
        ListNode p = null;

        while(c is not null)
        {
            ListNode t = c.next; //save the link
            c.next = p; //reverse;
            p = c;
            c = t;
        }

        return p;
    }
}
