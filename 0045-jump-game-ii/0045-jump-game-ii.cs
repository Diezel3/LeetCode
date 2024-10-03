public class Solution {
    public int Jump(int[] nums) {
        int lastIndex = nums.Length - 1;
        int steps = 0;
        // int jumps = 0;
        int j = nums[0];
        int nextIndex = 0;
        // int minimumJumps = 0;
        if (nums.Length == 1)
        {
            return 0;
        }
        if (nums[0] >= lastIndex) {
            return 1;
        }
        
        for (int i = 0; i <= j; i++) {
            if (i == lastIndex) {
                return steps;
            }
            
            j = Math.Max(j, i + nums[i]);
            
            if (i == nextIndex) {
                nextIndex = j;
                steps++;
            }
        }
        
        return steps;
    }
}
