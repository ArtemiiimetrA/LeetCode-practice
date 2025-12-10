namespace LeetCode.Core.Entities;

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
     
     public static ListNode BuildFromArray(int[] arr) {
         if (arr == null || arr.Length == 0) {
             return null;
         }
         
         ListNode head = new ListNode(arr[0]);
         ListNode current = head;
         
         for (int i = 1; i < arr.Length; i++) {
             current.next = new ListNode(arr[i]);
             current = current.next;
         }
         
         return head;
     }
     
     public override string ToString() {
         var result = new System.Text.StringBuilder();
         result.Append("[");
         ListNode? current = this;
         
         while (current != null) {
             result.Append(current.val);
             if (current.next != null) {
                 result.Append(",");
             }
             current = current.next;
         }
         
         result.Append("]");
         return result.ToString();
     }
 }
 