public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int x in nums)
        {
            if (dict.ContainsKey(x))
            {
                return true;
            }
            dict[x] = 1;
        }
        return false;
    }
}
