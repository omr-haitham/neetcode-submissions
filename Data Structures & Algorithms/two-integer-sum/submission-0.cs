public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        SortedDictionary<int, int> tempSD = new SortedDictionary<int, int>();
        int diff = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];
            if (tempSD.ContainsKey(diff))
            {
                
                res[0] = tempSD[diff];
                res[1] = i;
                break;
            }
            tempSD.Add(nums[i], i);
        }
        return res;
    }
}
