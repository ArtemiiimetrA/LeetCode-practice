using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P2_AddTwoNumbers {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        byte carry = 0;
        ListNode head = new();
        ListNode result = head;
        var l1Value = 0;
        var l2Value = 0;
        
        while (l1 != null || l2 != null || carry != 0)
        {
            if (l1 == null)
            {
                l1Value = 0;
            }
            else
            {
                l1Value = l1.val;
                l1 = l1.next;
            }

            if (l2 == null)
            {
                l2Value = 0;
            }
            else
            {
                l2Value = l2.val;
                l2 = l2.next;
            }
            
            var value = l1Value + l2Value + carry;
            carry = 0;
            
            if (value > 9)
            {
                value -= 10;
                carry++;
            }
            result.val = value;
            if (l1 == null && l2 == null && carry == 0) continue;
            result.next = new();
            result = result.next;
        }

        return head;
    }

    public ListNode AddTwoNumbers2Ver(ListNode l1, ListNode l2)
    {
        var dummyHead = new ListNode(0);
        var current = dummyHead;
        int carry = 0;
    
        while (l1 != null || l2 != null || carry != 0)
        {
            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;
            int sum = val1 + val2 + carry;
        
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        
            l1 = l1?.next;
            l2 = l2?.next;
        }
    
        return dummyHead.next;
    }
 
}