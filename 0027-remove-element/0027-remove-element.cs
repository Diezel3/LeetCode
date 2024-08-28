public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] newNums = new int[nums.Length];
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            else
            {
                newNums[k] = nums[i];
                k++;
                
            }
        }
        for (int i = 0; i < k; i++)
        {
            nums[i] = newNums[i];
        }
        return k;
    }
}