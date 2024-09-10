public class Solution {
    public int Reverse(int x) {
        string xString = Convert.ToString(x);
        char[] xChars;
        if (x < 0)
        {
            string newxString = xString.Remove(0, 1);
            xChars = newxString.ToCharArray();
        }
        else
        {
            xChars = xString.ToCharArray();
        }
        Array.Reverse(xChars);
        xString = new string(xChars);
        if (x < 0)
        {
            xString = '-'.ToString() + xString;
        }
        Int64 xTemp = Convert.ToInt64(xString);
        if ((xTemp > 0 && xTemp > 2147483647) || (xTemp < 0 && xTemp < -2147483648))
        {
            return 0;
        }
        else
        {
            x = (Int32)xTemp;
            return x;
        }
    }
}