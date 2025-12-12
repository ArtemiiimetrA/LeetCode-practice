// See https://aka.ms/new-console-template for more information  

using LeetCode.Core.Entities;
using LeetCode.Core.Problems;

var tree = TreeNode.BuildFromArray([1, null, 2, 3]);

var task = new P203_RemoveLinkedListElements();

var result = task.RemoveElements( ListNode.BuildFromArray([]), 7);

Console.WriteLine(result); 