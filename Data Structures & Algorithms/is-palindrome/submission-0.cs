public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length -1;

        //go through the entire string while pointers are correct
        while(left < right)
        {
            //make sure left is alphanumeric
            while(left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            //make sure right is alphanumeric
            while(left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            //Compare the left val and right val ignoring case
            if(char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}
