/*
Given a non-empty, singly linked list with head node head, return a middle node of linked list.

If there are two middle nodes, return the second middle node.




*/
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
    public ListNode MiddleNode(ListNode head) {
      
        var temp = head;
        int count =0;
        while(temp !=null){
            count++;
            temp = temp.next;
        }
        
        var newtemp = head;
        int number =(int) Math.Floor(count/2.0);
        while(number !=0){
            newtemp = newtemp.next;
            number--;
        }
        
        return newtemp;
    }
}
