public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        SortedDictionary<char,int> sD = new SortedDictionary<char,int>();
        SortedDictionary<char,int> tD = new SortedDictionary<char,int>();
        foreach(char c in s ){
            if (sD.ContainsKey(c)) sD[c] ++;
            else sD.Add(c,1);
        }
        foreach(char c in t ){
            if (tD.ContainsKey(c)) tD[c] ++;
            else tD.Add(c,1);
        }
        foreach (KeyValuePair<char, int> kvp in sD){
            if(!tD.ContainsKey(kvp.Key) || tD[kvp.Key]!= kvp.Value) return false;
            else continue;
        }
        return true;
    }
}
