public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var freq = new Dictionary<string, List<string>>();

        foreach(var str in strs){
            var word = str.ToCharArray();
            Array.Sort(word);

            var sortedWord = new string(word);

            if(freq.TryGetValue(sortedWord, out var val)){
                freq[sortedWord].Add(str);
            }
            else{
                freq[sortedWord] = [str];
            }
        }

        var list = new List<List<string>>();

        foreach(var str in freq){
            list.Add(str.Value);
        }

        return list;
    }
}
