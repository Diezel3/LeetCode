using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        if (s == " ")
        {
            return true;
        }
        string result = Regex.Replace(s, "[^a-zA-Z0-9]", "");
         if (result == "")
        {
            return true;
        }
        result = result.ToLower();
        int k = result.Length - 1;
        for (int i = 0; i <= (result.Length/2); i++)
        {
            if (result[i] != result[k])
            {
                return false;
            }
            k--;
        }
        return true;
    }
}