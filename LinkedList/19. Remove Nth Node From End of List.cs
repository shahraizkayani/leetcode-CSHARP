/*
Given a linked list, remove the n-th node from the end of list and return its head.

Example:

Given linked list: 1->2->3->4->5, and n = 2.

After removing the second node from the end, the linked list becomes 1->2->3->5.





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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next ==null && n ==1){
            ListNode template = null;
            return template;
            
        }
        ListNode temp = head,temp1 =head;
        int count =0;
        while(temp != null){
            temp = temp.next;
            count++;
        }
       
        if(count ==n){
           
            head = head.next;
            return head;
        }
        int i =0;
        while( i <count-n){
            if(i == count-n-1){
                var node = temp1.next;
                temp1.next = node.next;
                break;
                
            }
            temp1 = temp1.next;
            
            i++;
        }
        
        return head;
    }
}
