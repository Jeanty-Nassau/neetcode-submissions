public class Solution {
    public string MinWindow(string s, string t) {
        if(t == "") return "";

        var l = 0;
        var window = new Dictionary<char, int>();
        var freqT = new Dictionary<char, int>();

        foreach(char c in t)
            freqT[c] = freqT.GetValueOrDefault(c, 0) + 1;
        
        var have = 0;
        var need = freqT.Count();

        var subStart = 0;
        var subLen = int.MaxValue;

        for(int r = 0; r < s.Length; r++)
        {
            var c = s[r];
            window[c] = window.GetValueOrDefault(c, 0) + 1;

            if(freqT.ContainsKey(c) && window[c] == freqT[c])
                have++;
            
            while(have == need)
            {
                if((r - l + 1 ) < subLen)
                {
                    subStart = l;
                    subLen = r - l + 1;
                }

                window[s[l]]--;
                
                if(freqT.ContainsKey(s[l]) && window[s[l]] < freqT[s[l]])
                    have--;

                l++;
            }
        }

        if(subLen == int.MaxValue) return "";

        return s.Substring(subStart, subLen);
    }
}
