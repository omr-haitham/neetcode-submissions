public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1 || s.Length == 0) return false;
        Stack<char> openBrackets = new Stack<char>();
        foreach (char c in s)
        {
            switch (c) 
            {
                case '{':
                case '(':
                case '[':
                    openBrackets.Push(c); break;
                case ']':
                    if (openBrackets.Count == 0 || openBrackets.Pop() != '[') return false; break;
                case ')':
                    if (openBrackets.Count == 0 || openBrackets.Pop() != '(' ) return false; break;
                case '}':
                    if (openBrackets.Count == 0 || openBrackets.Pop() != '{' ) return false; break;
            }
        }
        if(openBrackets.Count == 0)
        return true;
        return false;
    }
}
