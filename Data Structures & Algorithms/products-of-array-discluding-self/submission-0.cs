public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var output = new int[nums.Length];

        //left pass
        var prefix = 1;
        for(var i = 0; i <= nums.Length-1; i++){
            output[i] = prefix;
            prefix = prefix * nums[i];
        }

        //right pass
        var postfix = 1;
        for(var j = nums.Length -1; j >= 0; j--){
            output[j] = postfix * output[j];
            postfix = postfix * nums[j];
        }
        return output;
    }
}
