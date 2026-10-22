public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        SortedDictionary<char,int> sD = new SortedDictionary<char,int>();
        SortedDictionary<char,int> tD = new SortedDictionary<char,int>();
        for(int i=0; i<s.Length; i++){
            if (sD.ContainsKey(s[i])) sD[s[i]] ++;
            else sD.Add(s[i],1);
            if (tD.ContainsKey(t[i])) tD[t[i]] ++;
            else tD.Add(t[i],1);
        }

        foreach (KeyValuePair<char, int> kvp in sD){
            if(!tD.ContainsKey(kvp.Key) || tD[kvp.Key]!= kvp.Value) return false;
            else continue;
        }
        return true;
    }
}
