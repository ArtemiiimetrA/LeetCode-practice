// See https://aka.ms/new-console-template for more information

using LeetCode.Core.Entities;
using LeetCode.Core.Problems;

var task = new P2_AddTwoNumbers();

var result = task.AddTwoNumbers(ListNode.BuildFromArray([9,9,9,9,9,9,9]), ListNode.BuildFromArray([9,9,9,9]));

Console.WriteLine(result.ToString());