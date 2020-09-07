/*

Remove all elements from a linked list of integers that have value val.

Example:

Input:  1->2->6->3->4->5->6, val = 6
Output: 1->2->3->4->5





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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null){
            return head;
        }
       int count =0;
        var test = head;
        while(test !=null){
            count++;
            test =test.next;
        }
        int max =0;
        while(head.val ==val ){
             if(head.next ==null){
            ListNode Node =null;
            return head.val == val ?Node :head;
        }
            head =head.next;
          
        }
        
      
        
        var temp = head;
     
       
        while(temp.next != null){
            
            var node = temp.next;
         
            if(node.val == val){
              
             
                temp.next= node.next; //6
                
               
            }
            else{
            temp = temp.next;
            }
        }
         
        return head;
    }
}
