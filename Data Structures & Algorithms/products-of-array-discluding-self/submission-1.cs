public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        int pf = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            res[i] = pf;
            pf = pf * nums[i];
        }

        pf = 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] = pf * res[i];
            pf = pf * nums[i];
        }
        
        return res;
    }
}
