public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new();

        foreach(var num in nums)
        {
            if(set.Contains(num))
                return true;

            set.Add(num);
        }

        return false;
    }
}