public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int possibleSmallest = 1;
        if (nums.Length == 0)
        {
            return possibleSmallest;
        }
        else if (nums.Length < 3)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != possibleSmallest)
                {
                    continue;
                }
                else
                {
                    possibleSmallest++;
                    i = -1;
                }
            }
            return possibleSmallest;
        }
        else
        {
          int n = nums.Length;

        // Step 1: Place each number in its correct position if it's within range [1, n].
        for (int i = 0; i < n; i++) {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                // Swap nums[i] with the number at its correct position (nums[i] - 1)
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
        }

        // Step 2: Find the first index where the number is incorrect
        for (int i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        // If all numbers are in their correct positions, return n + 1
        return n + 1;
        }
    }
}