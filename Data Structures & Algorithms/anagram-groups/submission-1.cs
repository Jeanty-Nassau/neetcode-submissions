public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var an = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var sArray = str.ToCharArray();
            Array.Sort(sArray);
            var newS = new string(sArray);

            if(an.TryGetValue(newS, out var anagramList))
            {
                an[newS].Add(str);
            }
            else{
                an[newS] = [str];
            }
        }

        return an.Values.ToList();
    }
}
