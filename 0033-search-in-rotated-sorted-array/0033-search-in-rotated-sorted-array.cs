public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length == 1)
        {
            if(nums[0] == target)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        else if(nums.Length == 0)
        {
            return -1;
        }
        else
        {
            int left = 0;
            int right = nums.Length - 1;
            while ((right - left) != 1)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[left] <= nums[mid])  // Left side is sorted??
                {
                    if (target >= nums[left] && target < nums[mid])
                    {
                        right = mid--;
                    }
                    else
                    {
                        left = mid++;
                    }
                }
                else if (nums[mid] <= nums[left])  // Right side is sorted??
                {
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid++;
                    }
                    else
                    {
                        right = mid--;
                    }
                }
            }
            if (nums[left] == target)
            {
                return left;
            }
            else if (nums[right] == target)
            {
                return right;
            }
            else
            {
                return -1;
            }
        }
    }
}