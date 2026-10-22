public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> digits = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (!digits.ContainsKey(target - num))
            {
                digits.Add(num, i);
            }
            else
            {
                int[] result = new int[] { digits[target - num], i };
                Console.WriteLine(result);
                return result;   
            }
        }
        return new int[2] {-1,-1 };
    }
}