public class Solution {

    public string Encode(IList<string> strs) {
        string code = "";
        foreach(string str in strs)
            code = code + $"{str.Length}#{str}";

        return code;
    }

    public List<string> Decode(string s) {
        List<string> strs = new();
        int l = 0;
        int r = 0;
        while(r < s.Length)
        {
            int len = 0;
            if(s[r] == '#')
            {
                // 5#Hello5#World
                len = int.Parse(s.Substring(l, r - l));
                var sub = s.Substring(r + 1, len);
                strs.Add(sub);
                r = r + len + 1;
                l = r;
            }

            r++;
        }

        return strs;
   }
}
