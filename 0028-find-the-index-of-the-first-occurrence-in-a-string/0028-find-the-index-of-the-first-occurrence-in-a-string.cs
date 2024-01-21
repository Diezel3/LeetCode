public class Solution {
    public int StrStr(string haystack, string needle) {
              // Ensure needle is not empty and is shorter than haystack
    if (needle.Length == 0 || needle.Length > haystack.Length)
    {
        return -1;
    }

    int needleLength = needle.Length;

    // Iterate through each character of the haystack
    for (int i = 0; i <= haystack.Length - needleLength; i++)
    {
        // Check if the current substring matches the needle
        bool matchFound = true;
        for (int j = 0; j < needleLength; j++)
        {
            if (haystack[i + j] != needle[j])
            {
                matchFound = false;
                break;
            }
        }

        // If a match is found, return the starting index
        if (matchFound)
        {
            return i;
        }
    }

    // If no match is found, return -1
    return -1;
    }
}