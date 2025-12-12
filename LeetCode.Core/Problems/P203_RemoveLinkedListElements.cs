using LeetCode.Core.Entities;

namespace LeetCode.Core.Problems;

public class P203_RemoveLinkedListElements
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummyHead = new ListNode(-1, head);
        var current = dummyHead;
        while (current?.next is not null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        
        return dummyHead.next;
    }
}