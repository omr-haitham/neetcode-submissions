public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return nums[0];
        int maxSum = int.MinValue;
        int forwardSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > forwardSum + nums[i]) {
                forwardSum = nums[i];
            } else {
                forwardSum += nums[i];
            }
            if (maxSum < forwardSum)
                maxSum = forwardSum;
           // Console.WriteLine(forwardSum + ", ");
        }
        return maxSum;
    }
}
