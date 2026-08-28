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
        if (head == null) return null;
        if (head.next == null) return head;
        
        var prev = head; 
        var cur = head.next;

        head.next = null;

        while (cur.next != null)
        {
            var temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }

        cur.next = prev;
        return cur;
    }
}

