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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        var a = list1; // sliding pointer on list1
        var b = list2; // sliding pointer on list2

        var dummy = new ListNode(); // true list starts after this (dummy.next)
        var tail = dummy; // snake's head that follows lower value

        while (a != null && b != null)
        {
            if (a.val <= b.val) 
            {
                tail.next = a;
                a = a.next;
            }
            else
            {
                tail.next = b;
                b = b.next;
            }
            tail = tail.next;
        }

        tail.next = a ?? b;

        return dummy.next;
    }
}