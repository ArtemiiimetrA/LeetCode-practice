// See https://aka.ms/new-console-template for more information

using LeetCode.Core.Problems;

var task = new P49_GroupAnagrams();

var result = task.GroupAnagrams([""]);

foreach (var lst in result)
{
    Console.WriteLine($"[{string.Join(", ", lst)}]");
}