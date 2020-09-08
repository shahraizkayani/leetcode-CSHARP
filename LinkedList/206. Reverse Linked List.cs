/*
Reverse a singly linked list.

Example:

Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL


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
    public ListNode ReverseList(ListNode head) {
        
        if(head ==null){
            return null;
        }
        
        if(head.next ==null){
            
            return head;
        }
        
       ListNode previousnode =null;
        ListNode currentnode = head,nextnode =head;
        
        while(nextnode !=null)
            
        {
            nextnode = nextnode.next;
            currentnode.next = previousnode;
            previousnode = currentnode;
            currentnode = nextnode;
            
            
            
        }
        
        head = previousnode;
        
        return previousnode;
        
    }
}
