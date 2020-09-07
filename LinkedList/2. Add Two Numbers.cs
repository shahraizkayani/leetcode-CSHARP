/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.


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
public class Solution
        {
            public static string Reverse(string num)

            {
                var reverse = new StringBuilder();

                for (int i = num.Length - 1; i >= 0; i--)
                {

                    reverse.Append(num[i].ToString());
                }

                return reverse.ToString();
            }



            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                var temp = l1;

                var temp1 = l2;

                var s1 = new StringBuilder();
                var s2 = new StringBuilder();


                while (temp != null)
                {

                    s1.Append(temp.val);
                    temp = temp.next;

                }

                while (temp1 != null)
                {

                    s2.Append(temp1.val);
                    temp1 = temp1.next;

                }
                BigInteger sum = BigInteger.Parse(Reverse(s1.ToString())) + BigInteger.Parse(Reverse(s2.ToString()));

                string sumnumber = sum.ToString();
                ListNode head = null, temp3 = null;

                for (int i = sumnumber.Length - 1; i >= 0; i--)
                {
                    var newnode = new ListNode(int.Parse(sumnumber[i].ToString()));

                    if (head == null)
                    {
                        head = newnode;
                        temp3 = newnode;
                    }
                    else
                    {

                        temp3.next = newnode;
                        temp3 = newnode;
                    }
                    // i++;

                }
                return head;
            }
        }
