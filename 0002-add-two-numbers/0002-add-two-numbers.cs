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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dh=new ListNode(0);
        ListNode t=dh;
        int c=0;
        while(l1!=null || l2!=null || c!=0)
        {
            int d1 = (l1 != null) ? l1.val : 0;
            int d2 = (l2 != null) ? l2.val : 0;

            int sum = d1 + d2 + c;
            int dt = sum % 10;
            c = sum / 10;

            ListNode newNode = new ListNode(dt);
            t.next = newNode;
            t = t.next;

            l1 = (l1 != null) ? l1.next : null;
            l2 = (l2 != null) ? l2.next : null;
        }
        ListNode res=dh.next;
        dh.next=null;
        return res;
    }
}