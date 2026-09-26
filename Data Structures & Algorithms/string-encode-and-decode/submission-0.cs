public class Solution {

    public string Encode(IList<string> strs) {
        //length + # before each word
        var encodedString = "";
        foreach(var str in strs){
            encodedString += $"{str.Length}#{str}";
        }

        return encodedString;
    }

    public List<string> Decode(string s) {
        var left = 0;
        var decode = new List<string>();

        while(left < s.Length){
            var right = left;
            
            while(s[right] != '#'){
                right++;
            }

            var length = int.Parse(s[left..right]);
            decode.Add(s[(right + 1)..(right + 1 + length)]);

            left = right + 1 + length;
        }

        return decode;
   }
}
