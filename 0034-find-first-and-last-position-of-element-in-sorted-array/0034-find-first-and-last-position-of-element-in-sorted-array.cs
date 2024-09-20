public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0)
        {
            int[] output = new int[] {-1, -1};
            return output;
        }
        else if (nums.Length == 1)
        {
            if (target == nums[0])
            {
                int[] output = new int[] {0, 0};
                return output;
            }
            else
            {
                int[] output = new int[] {-1, -1};
                return output;
            }
        }
        else
        {
            int left = 0;
            int right = nums.Length - 1;
            bool leftFound = false;
            bool rightFound = false;
            bool leftMaybe = false;
            bool rightMaybe = false;
            int[] output = new int[2] {-1, -1};
            while (left <= right && (leftFound == false || rightFound == false))
            {
                if (target == nums[left])
                {
                    if (leftFound == false)
                    {
                        output[0] = left;
                        leftFound = true;
                    }
                    else if (rightFound == false)
                    {
                        output[1] = left;
                        rightMaybe = true;
                    }
                }
                if (target == nums[right])
                {
                    if (rightFound == false)
                    {
                        output[1] = right;
                        rightFound = true;
                    }
                    else if (leftFound == false)
                    {
                        output[0] = right;
                        leftMaybe = true;
                    }
                }
                left++;
                right--;
            }
            if ((leftFound == true && rightFound == false) && rightMaybe == false)
            {
                output[1] = output[0];
            }
            else if ((leftFound == false && rightFound == true) && leftMaybe == false)
            {
                output[0] = output[1];
            }
            return output;
        }
    }
}