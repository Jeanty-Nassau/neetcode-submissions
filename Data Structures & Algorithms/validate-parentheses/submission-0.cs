public class Solution {
    public bool IsValid(string s) {
        var map = new Dictionary<char, char>{
            {')','('},
            {'}','{'},
            {']','['}
        };
        
        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if(map.TryGetValue(c, out var openBracket))
            {
                if(stack.Count > 0 && stack.Peek() == openBracket)
                {
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
            else{
                stack.Push(c);
            }
        }

        return stack.Count > 0? false: true;
    }
}
