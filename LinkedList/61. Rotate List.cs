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
    public ListNode RotateRight(ListNode head, int k) {
        if(k<=0 ||head ==null ||head.next ==null){
            return head;
        }
        var length = head;
        int count =0;
        while(length.next!=null){
            
            count++;
            length = length.next;
        }
        count = count+1;
        if(k >count){
            k = k %count ==0 ? count : k %count;
        }
        Console.WriteLine(count);
        for (int i = 1; i <= k; i++)
            {
                var temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                var node = new ListNode(temp.next.val);
                temp.next = temp.next.next;
                node.next = head;
                head = node;
           }
            return head;
    }
}
