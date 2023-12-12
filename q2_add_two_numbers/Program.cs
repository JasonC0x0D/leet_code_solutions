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
        ListNode dummyHead = new();
        ListNode currentNode = dummyHead;
        int carry = 0;

        while(l1 != null || l2 != null || carry != 0 ){
            int x = l1 is null ? 0 : l1.val;
            int y = l2 is null ? 0 : l2.val;
            int sum = x + y + carry;

            carry = sum / 10;

            currentNode.next = new(sum % 10);
            currentNode = currentNode.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return dummyHead.next;
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