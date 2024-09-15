public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        // OPTIMISE LATER USING THE TWO POINTER TECHNIQUE
        // SORT THE ARRAY FIRST IN ASCENDING ORDER
        // USE FOR LOOP AND INITIALISE firstNum = [i]
        // INITIALISE leftPointer = [I + 1]
        // INITIALISE rightPointer = [nums.Length - 1]
        // WHILE ITERATING, IF GREATER THAN TARGET, REDUCE rightPointer
        // IF LESS THAN TARGET, INCREASE leftPointer
        // THEN STORE SUM AND COMPARE WITH PREVIOUS SUM FOR CLOSEST TO TARGET
       int total = 0;
       int newDifference;
       int oldDifference = 0;
       bool check = true;
       int result = 0;
        if (nums.Length == 3)
        {
            total = nums[0] + nums[1] + nums[2];
            return total;
        }
        else if (nums.Length > 3)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        total = nums[i] + nums[j] + nums[k];
                    if (target > total)
                    {
                        newDifference = target - total;
                    }
                    else
                    {
                        newDifference = total - target;
                    }
                    if (check == true)
                    {
                        oldDifference = newDifference;
                        result = total;
                        check = false;
                    }
                    if (newDifference < oldDifference)
                    {
                        oldDifference = newDifference;
                        result = total;
                    }
                    }
                }
            }
        }
        return result;
    }
}
