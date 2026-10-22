public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> [] charCount = new Dictionary<char, int>[2];
        charCount[0] = new Dictionary<char, int>();
        charCount[1] = new Dictionary<char, int>();
        if(s.Length != t.Length)
        {
            return false;
        }
        foreach (char c in s) { 
            charCount[0][c] = charCount[0].GetValueOrDefault(c) + 1;
        }
        foreach (char c in t) { 
            charCount[1][c] = charCount[1].GetValueOrDefault(c) + 1;
        }
        foreach (var kvp in charCount[0])
        {
            if (!charCount[1].ContainsKey(kvp.Key) || charCount[1][kvp.Key] != kvp.Value)
            {
                return false;
            }
        }
        return true;
    }
}
