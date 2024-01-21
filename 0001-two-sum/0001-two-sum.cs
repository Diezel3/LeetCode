public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = new int [2];
        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            temp = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (temp == nums[j])
                {
                    indices[0] = i;
                    indices[1] = j;
                    
                }
            }
            
        }
        return indices;
    }
}