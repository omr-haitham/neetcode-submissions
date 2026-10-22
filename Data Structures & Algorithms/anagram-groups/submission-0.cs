public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<string> tempList = new List<string>();
        List <List<string>> resListList = new List<List<string>>();
        Dictionary<string , List<string>> stringsAnagrams = new Dictionary<string , List<string>>();
        foreach (string str in strs) {
            Dictionary<char , int> charFreqHash = new Dictionary<char , int>();
            Dictionary<string , Dictionary<char , int>> sortedAnagramDict = new Dictionary<string, Dictionary<char, int>>();

            char[] sortedStr = str.ToCharArray();
            Array.Sort(sortedStr);
            string tempStrSorted = new string(sortedStr);

            if (stringsAnagrams.ContainsKey(tempStrSorted))
            {
                stringsAnagrams[tempStrSorted].Add(str);
            }
            else
            {
                tempList.Add(tempStrSorted);
                stringsAnagrams[tempStrSorted] = new List<string>();
                stringsAnagrams[tempStrSorted].Add(str);
            }
        }

        foreach (string str in tempList) { 
            resListList.Add(stringsAnagrams[str]);
        }
        return resListList;
    }
}
