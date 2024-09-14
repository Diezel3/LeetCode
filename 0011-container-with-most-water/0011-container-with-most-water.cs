public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length - 1;
        int shorterHeight;
        int difference;
        int maxArea;
        int output = 0;

        while (i != j)
        {
            if (height[i] < height[j])
            {
                shorterHeight = height[i];
                difference = j - i;
                i++;
            }
            else
            {
                shorterHeight = height[j];
                difference = j - i;
                j--;
            }
            maxArea = shorterHeight * difference;
            if (maxArea > output)
            {
                output = maxArea;
            }
        }
        return output;
    }
}