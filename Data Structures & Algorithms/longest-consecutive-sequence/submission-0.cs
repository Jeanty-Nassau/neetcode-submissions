public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        var longest = 0;

        foreach(var num in nums){
            var length = 0;

            if(!set.Contains(num - 1)){

                while(set.Contains(num + length)){
                    length++;
                }

                longest = Math.Max(length, longest);
            }
        }

        return longest;
    }
}
