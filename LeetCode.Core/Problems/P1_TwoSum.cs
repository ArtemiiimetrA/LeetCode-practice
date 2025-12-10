namespace LeetCode.Core.Problems;

public class P1_TwoSum {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            var check = target - nums[i];
            if (dict.TryGetValue(check, out var value))
                return [value, i];
            
            dict[nums[i]] = i;
        }

        return [];
    }
}