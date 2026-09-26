public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int> ();

        foreach(var num in nums){
            if(!freq.TryGetValue(num, out var frequency)){
                frequency = 0;
                freq[num] = frequency;
            }

            freq[num]++;
        }

        var priorityQueue = new PriorityQueue<int, int>();
        var topKElements = new int[k];
        
        foreach(var (num, frequency) in freq){
            priorityQueue.Enqueue(num, frequency);
            if(priorityQueue.Count > k)
                priorityQueue.Dequeue();
        }

        for(var i = k-1; i >= 0 ; i--){
            topKElements[i] = priorityQueue.Dequeue();
        }
            
        return topKElements;
    }
}
