public class Solution {
    public bool IsAnagram(string s, string t) {
        var orderedS = s.ToCharArray();
        Array.Sort(orderedS);

        var orderedT = t.ToCharArray();
        Array.Sort(orderedT);

        if(new string(orderedS) == new string(orderedT))
            return true;
        
        return false;
    }
}
