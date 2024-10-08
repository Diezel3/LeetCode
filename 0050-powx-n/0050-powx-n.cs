public class Solution {
    public double MyPow(double x, int n) {
        double result = Math.Pow(x,n);
        return result;

        // int nNew = Math.Abs(n);
        // double result = x;
        // if (n == 0)
        // {
        //     return 1;
        // }
        // for (int i = 0; i < nNew - 1; i++)
        // {
        //     result = result * x;
        // }
        // if (n < 0)
        // {
        //     result = 1 / result;
        // }
        // return result;
    }
}