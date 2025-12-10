using System.Text;

namespace LeetCode.Core.Problems;

/*
 *
 * Example 1:

    Input: strs = ["eat","tea","tan","ate","nat","bat"]
    Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    Explanation:

    There is no string in strs that can be rearranged to form "bat".
    The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
    The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
    
    Example 2:

    Input: strs = [""]
    Output: [[""]]

    Example 3:
    
    Input: strs = ["a"]
    Output: [["a"]]
 */
public class P49_GroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0)
            return new List<IList<string>>();

        var map = new Dictionary<string, List<string>>(strs.Length);

        foreach (var s in strs) {
            // build frequency signature for s
            var counts = new int[26];
            foreach (var t in s)
                counts[t - 'a']++;

            // encode counts into a string key (e.g. "1#0#0#2#...")
          var key =  string.Join("#", counts);

            if (!map.TryGetValue(key, out var list)) {
                list = [];
                map[key] = list;
            }
            list.Add(s);
        }

        // convert values to IList<IList<string>>
        return map.Values.Select(IList<string> (l) => l).ToList();
    }
}