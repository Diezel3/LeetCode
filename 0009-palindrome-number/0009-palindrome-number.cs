public class Solution {
    public bool IsPalindrome(int x) {
         if (x == null || x < 0)
            return false;

        string number = x.ToString();
        string numReverse = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            numReverse += number[i];
        }
        if (number == numReverse)
            return true;
        else
            return false;
    }
}