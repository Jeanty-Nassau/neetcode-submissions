public class Solution {
    public int CharacterReplacement(string s, int k) {
        var res = 0;
        var l = 0;
        var freq = new Dictionary<char, int>();
        var maxf = 0;

        for(int r = 0; r < s.Length; r++)
        {
            if(!freq.TryGetValue(s[r], out var count))
            {
                count = 0;
            }

            count++;
            freq[s[r]] = count;

            maxf = Math.Max(maxf, freq[s[r]]);

            while((r - l + 1) - maxf > k)
            {
                freq[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
