public class Solution {
    public int ClimbStairs(int n) {
        int f1 = 1;
        int f2 = 2;
        int counter = 2;
        int result = 0;
        if ( n == 0 || n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            while (counter < n)
            {
                result = f2 + f1;
                f1 = f2;
                f2 = result;
                counter++;
            }
            return result;
        }
    }
}