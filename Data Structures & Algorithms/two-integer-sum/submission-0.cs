public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var visited = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++){
            var needed = target - nums[i];

            if(visited.TryGetValue(needed, out int neededIndex)){
                return [neededIndex, i];
            }

            visited[nums[i]] = i;
        }

        return [];
    }
}
