public class Solution
{
    public int[]? TwoSum(int[] nums, int target)
    {

        for (int k = 0; k < nums.Length; k++)
        {
            int lt = 0; // первый, то есть левый
            int rt = nums.Length - 1; // второй, то есть правый
            int sum = nums[lt] + nums[rt];
            if (target == sum)
            {
                return new int[] { nums[lt], nums[rt] };
            }
        }
        return null;
    }
}