public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int shortestLen = strs[0].Length;
        string res = "";
        for (int i = 1; i < strs.Length; i++) if (shortestLen > strs[i].Length) shortestLen = strs[i].Length;
        for (int i = 0; i < shortestLen; i++) {
            char currChar = strs[0][i];
            for (int j = 0; j < strs.Length; j++) {
                if (strs[j][i] != currChar) {
                    return res; 
                } 
            }
            res += currChar;
        }
        return res;
    }
}