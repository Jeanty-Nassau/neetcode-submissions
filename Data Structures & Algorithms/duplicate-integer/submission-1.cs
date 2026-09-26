public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seenVals = new HashSet<int>();

        foreach(var num in nums){
            if(seenVals.Contains(num)){
                return true;
            }

            seenVals.Add(num);
        }

        return false;
    }
}