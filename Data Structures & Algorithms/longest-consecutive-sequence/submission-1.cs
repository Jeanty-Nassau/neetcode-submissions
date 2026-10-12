public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxLen = 0;

        foreach(int num in nums)
        {
            int len = 0;

            if(!set.Contains(num - 1))
            {
                while(set.Contains(num + len))
                    len++;
            }

            maxLen = Math.Max(maxLen, len);
        }

        return maxLen;
    }
}
