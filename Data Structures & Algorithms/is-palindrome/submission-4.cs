public class Solution {
    public bool IsPalindrome(string s) {
    int o = s.Length-1;
    int i = 0;
    if (string.IsNullOrEmpty(s)) return false;
    Console.WriteLine(s.Length);
    if(s.Length == 1) {
        Console.WriteLine(s.Length);
        return true;
    }
    s = s.ToLower();
    while (i <= s.Length && o > i)
    {
        Console.WriteLine(i+"+"+o);
        if (!char.IsLetterOrDigit(s[i]) || char.IsWhiteSpace(s[i])) { i++;  continue; }
        if (!char.IsLetterOrDigit(s[o]) || char.IsWhiteSpace(s[o])) { o--;  continue; }
        if (s[i] != s[o]) {
            Console.WriteLine(s[i]+"+"+s[o]);
            return false;
        }

        o--;
        i++;
    }
    return true;
    }
}
