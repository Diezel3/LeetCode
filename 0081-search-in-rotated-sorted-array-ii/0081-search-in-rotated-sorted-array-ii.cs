public class Solution {
    public bool Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = (right + left) / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[mid] || target == nums[left] || target == nums[right])
            {
                return true;
            }
            if (target > nums[left])
            {
                left++;
                mid = (right + left) / 2;
            }
            if (target < nums[right])
            {
                right--;
                mid = (right + left) / 2;
            }
        }
        return false;
    }
}