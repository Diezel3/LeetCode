public class Solution {
    public string LongestPalindrome(string s) {
        // string test = "";
        // string reverse = "";
        // int count = 0;
        // string palindrome = "";
        // for (int i = 0; i < s.Length - 1; i++)
        // {
        //     test += s[i];
        //     for (int j = i + 1; j < s.Length; j++)
        //     {
        //         test += s[j];
        //         for (int k = test.Length - 1; k >= 0; k--)
        //         {
        //             reverse += test[k];
        //         }
        //         if (test.Equals(reverse))
        //         {
        //             if (test.Length > count)
        //             {
        //                 count = test.Length;
        //                 palindrome = test;
        //             }
        //         }
        //         reverse = "";
        //     }
        //     test = "";
        // }
        // if (palindrome == "")
        // {
        //     palindrome += s[0];
        //     return palindrome;
        // }
        // else
        // {
        //     return palindrome;
        // }
        

        if (s.Length == 0)
    {
        return "";
    }

    int start = 0, end = 0;
    for (int i = 0; i < s.Length; i++)
    {
        int left = i, right = i;
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        int len = right - left - 1;
        if (len > end - start)
        {
            start = left + 1;
            end = right - 1;
        }

        left = i;
        right = i + 1;
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        len = right - left - 1;
        if (len > end - start)
        {
            start = left + 1;
            end = right - 1;
        }
    }

    return s.Substring(start, end - start + 1);
    }
}