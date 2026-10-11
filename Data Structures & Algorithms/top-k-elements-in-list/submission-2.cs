public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!freq.TryGetValue(num, out var frequency))
                frequency = 0;
            
            frequency++;
            freq[num] = frequency;
        }

        var p = new PriorityQueue<int, int>();

        foreach((int num, int f) in freq)
        {
            p.Enqueue(num, f);

            if(p.Count > k)
                p.Dequeue();
        }

        return p.UnorderedItems.Select(x => x.Element).ToArray();
    }
}
