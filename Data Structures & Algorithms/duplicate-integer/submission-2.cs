public class Solution {
    public bool hasDuplicate(int[] nums) {
        SortedSet<int> x = new SortedSet<int>();
        foreach (int temp in nums)
        {
            if(x.Contains(temp)) return true;
            x.Add(temp);
        }        
        return false;
    }
}