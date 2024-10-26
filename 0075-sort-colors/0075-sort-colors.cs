public class Solution {
    public void SortColors(int[] nums) {
        bool inPlace = false;
        while (inPlace == false)
        {
            inPlace = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i+1])
                {
                    int temp;
                    temp = nums[i];
                    nums[i] = nums[i+1];
                    nums[i+1] = temp;
                    inPlace = false;
                }
            }
        }
    }
}