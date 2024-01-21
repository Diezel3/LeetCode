public class Solution {
    public int LengthOfLongestSubstring(string s) {
          int oldLength = 0;
                int newLength = 0;
                string longSub = "";
                int reset = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < longSub.Length; j++)
                    {
                        if (longSub[j] != s[i])
                        {
                            continue;
                        }
                        else
                        {
                            longSub = "";
                            reset++;
                            i = reset;
                            break;
                        }
                    }
                    longSub += s[i];
                    oldLength = longSub.Length;
                    if (oldLength > newLength)
                    {
                        newLength = oldLength;
                    }
                }
                return newLength;
    }
}