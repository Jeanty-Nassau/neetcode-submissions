public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArray = s.ToCharArray();
        Array.Sort(sArray);
        var sNew = new string(sArray);

        var tArray = t.ToCharArray();
        Array.Sort(tArray);
        var tNew = new string(tArray);

        if(sNew == tNew)
            return true;
        
        return false;
    }
}
