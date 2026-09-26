public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;
        var res = nums[0];
        var m = 0;

        while(l <= r)
        {
            //cater for edge case
            if(nums[l] < nums[r])
            {
                res = Math.Min(res, nums[l]);
                break;
            }

            m = (r + l) / 2;
            res = Math.Min(res, nums[m]);

            if(nums[m] >= nums[l])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return res;
    }
}
