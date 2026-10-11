public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var v = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var n = target - nums[i];

            if(v.TryGetValue(n, out var index))
            {
                return [index, i];
            }

            v[nums[i]] = i;
        }

        return [];
    }
}
