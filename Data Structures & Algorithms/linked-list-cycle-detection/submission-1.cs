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
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null) return false;
        ListNode i = head.next;
        ListNode p = head;
        bool nextP = false;
        while(i.next != null || p.next != null)
        {
            if(i == p)
            {
                return true;
            }
            if(i.next == null)
            {
                break;
            }
            i = i.next;
            if (nextP)
            {
                p = p.next;
                nextP = false;
            }
            else
            {
                nextP = true;
            }
        }
        return false;
        }
}
