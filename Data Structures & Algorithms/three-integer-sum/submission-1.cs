public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var t = new List<List<int>>();

        Array.Sort(nums);

        for(int curr = 0; curr < nums.Length -1; curr++)
        {
            if(curr > 0 && nums[curr] == nums[curr -1])
                continue;

            var l = curr +1;
            var r = nums.Length -1;

            while(l < r)
            {
                var currSum = nums[curr] + nums[l] + nums[r];

                if(currSum > 0)
                {
                    r--;
                }
                else if(currSum < 0)
                {
                    l++;
                }
                else{
                    t.Add([nums[curr] , nums[l] , nums[r]]);
                    l++;

                    while(nums[l] == nums[l-1] && l<r)
                        l++;
                }
            }
        }

        return t;
    }
}
