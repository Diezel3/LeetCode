public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string common = "";
        string temp = "";
        int count = 0;
        int i = 0;
        for (int j = 0; j < strs[i].Length; j++)
        {
            temp += strs[i][j];
            while(i < strs.Length - 1)
            {
                if(j < strs[i+1].Length && temp[0] == strs[i+1][j])
                {
                    count++;
                    i++;
                    continue;
                }
                else
                {
                    return common;
                } 
            }
            i = 0;
            common += temp;
            temp = "";
        }
        return common;
    }
}