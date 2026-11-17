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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0)
            return null;

        if (lists.Length == 1)
            return lists[0];
        PriorityQueue<ListNode, int> pQ = new();
        ListNode? head = null;

        for (int i = 0; i < lists.Length; i++) {
            if (lists[i] != null)
                pQ.Enqueue(lists[i], lists[i].val);
        }
        if (pQ.Count == 0) {
            return head;
        }
        head = pQ.Dequeue();
        if (head.next != null) {
            pQ.Enqueue(head.next, head.next.val);
        }
        ListNode curr = head;

        while (pQ.Count > 0) {
            curr.next = pQ.Dequeue();
            if (curr.next.next != null) {
                pQ.Enqueue(curr.next.next, curr.next.next.val);
            }
            curr = curr.next;
        }

        return head;
    }
}
