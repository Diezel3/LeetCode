public class Solution {
    public bool CanJump(int[] nums) {
        int lastIndex = nums.Length - 1;
       
        int j = nums[0];
        int nextIndex = 0;
        
        if (nums.Length == 1)
        {
            return true;
        }
        if (nums[0] >= lastIndex) {
            return true;
        }
        
        for (int i = 0; i <= j; i++) {
            if (i == lastIndex) {
                return true;
            }
            
            j = Math.Max(j, i + nums[i]);
            
            if (i == nextIndex) {
                nextIndex = j;
            }
        }
        
        return false;
    }
}
