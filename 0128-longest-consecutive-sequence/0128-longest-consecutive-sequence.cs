public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;
        
        Array.Sort(nums);
        int maxSequence = 1;
        int currentSequence = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i-1]) continue;
            
            if (nums[i] == nums[i-1] + 1) {
                currentSequence++;
                maxSequence = Math.Max(maxSequence, currentSequence);
            } else {
                currentSequence = 1;
            }
        }
        
        return maxSequence;
    }
}