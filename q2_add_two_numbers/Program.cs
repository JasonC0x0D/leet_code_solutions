// https://leetcode.com/problems/add-two-numbers/



using System.Security.Cryptography.X509Certificates;

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
var mySolution = new Solution();
// 321 + 654 = 975
ListNode list1 = new(1,new(2,new(3)));
ListNode list2 = new(4,new(5,new(6)));
ListNode answer = new(5,new(7,new(9)));

var sum = mySolution.AddTwoNumbers(list1, list2);

Console.WriteLine("Done");

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        return AddTwoNumbers(l1, l2, 0);

        ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry){
            
            int sum = l1.val + l2.val + carry;
            int ones = sum % 10;
            int tens = sum / 10;

            Console.WriteLine($"Sum: {sum}, Ones: {ones}, Tens: {tens} L1 {l1.next is not null} L2 {l2.next is not null}");

            if (tens == 0){
                if(l1.next is null && l2.next is null)
                    return new(ones);
                if(l1.next is null)
                    return new(ones, l2.next);
                if(l2.next is null)
                    return new(ones, l1.next);
                else
                    return new(ones, AddTwoNumbers(l1.next, l2.next, 0));
            }
            else{
                if(l1.next is null && l2.next is null)
                    return new(ones, new(tens));
                if(l1.next is null)
                    return new(ones, AddTwoNumbers(l2.next, new(tens), 0));
                if(l2.next is null)
                    return new(ones, AddTwoNumbers(l1.next, new(tens), 0));
                else
                    return new(ones, AddTwoNumbers(l1.next, l2.next, 1));
            }
        }
    }
}

 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }