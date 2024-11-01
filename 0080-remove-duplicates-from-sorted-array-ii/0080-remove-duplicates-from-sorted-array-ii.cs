public class Solution {
   public int RemoveDuplicates(int[] nums) {
       if (nums.Length <= 2) return nums.Length;
       
       int presentValue = nums[0];
       int count = 1;
       int k = 0;
       
       for (int i = 1; i < nums.Length; i++) {
           if (nums[i] == presentValue) {
               count++;
               if (count > 2) {
                   continue;
               }
               k++;
           } else {
               presentValue = nums[i];
               count = 1;
               k++;
           }
           nums[k] = nums[i];
       }
       
       return k + 1;
   }
}