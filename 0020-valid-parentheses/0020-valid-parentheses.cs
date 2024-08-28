public class Solution
{
    public bool IsValid(string s)
    {
        char open1 = '(';
        char close1 = ')';
        char open2 = '[';
        char close2 = ']';
        char open3 = '{';
        char close3 = '}';
        string opens = "";
        
        if (s.Length % 2 != 0)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == open1 || s[i] == open2 || s[i] == open3)
                {
                    // Append open bracket to string
                    opens += s[i];
                }
                else if (s[i] == close1 || s[i] == close2 || s[i] == close3)
                {
                    // Check if the latest open bracket matches the current closing bracket
                    if (opens.Length == 0)
                        return false;
                    
                    char lastOpen = opens[opens.Length - 1];

                    if ((lastOpen == open1 && s[i] == close1) ||
                        (lastOpen == open2 && s[i] == close2) ||
                        (lastOpen == open3 && s[i] == close3))
                    {
                        // Remove the last open bracket from the string
                        opens = opens.Remove(opens.Length - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // If all opening brackets were matched, 'opens' should be empty
            return opens.Length == 0;
        }
    }
}