public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int arrayLength = nums1.Length + nums2.Length;
            int[] mergedArray = new int[arrayLength];
            int i = 0;
            int temp = 0;
            for (i = 0; i < nums1.Length; i++)
            {
                mergedArray[i] = nums1[i];
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                mergedArray[i] = nums2[j];
                i++;
            }

            Array.Sort(mergedArray); 

            //This is for finding the median
            int index;
            double result;
            double num1;
            double num2;
            if (arrayLength % 2 != 0)
            {
                index = (arrayLength - 1) / 2;
                result = mergedArray[index];
                return result;
            }
            else
            {
                index = arrayLength / 2;
                num1 = mergedArray[index];
                num2 = mergedArray[index - 1];
                result = (num1 + num2) / 2;
                return result;
            }
    }
}