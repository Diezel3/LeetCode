public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] temp = new int[nums.Length];
        int[] nums2 = new int[nums.Length];
        int j = 1;
        int k = 1;
        
        for(int i = 0; i < nums.Length; i++)
        {
            temp[i] = nums[i];
        }
        nums2[0] = nums[0];
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if (temp[i] == nums[i+1])
            {
                continue;
            }
            else
            {
                k++;
                nums2[j] = nums[i+1];
                j++;
            }
        }
        while(j < nums2.Length)
        {
            nums2[j] = 0;
            j++;
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            nums[i] = nums2[i];
        }
        return k;
    }
}