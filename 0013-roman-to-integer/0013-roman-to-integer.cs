public class Solution {
    public int RomanToInt(string s) {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I' || s[i] == 'V' || s[i] == 'X' || s[i] == 'L' || s[i] == 'C' || s[i] == 'D' || s[i] == 'M')
            {
                continue;
            }
            else
            {
                return 0;
            }
        }
        Dictionary <char, int> romanNormal = new Dictionary<char, int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        Dictionary <string, int> romanUnique = new Dictionary<string, int>
        {
            {"IV",4},
            {"IX",9},
            {"XL",40},
            {"XC",90},
            {"CD",400},
            {"CM",900}
        };

        string temp = "";
        int num = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1)
            {
                temp += s[i];
                temp += s[i+1];

                if (romanUnique.ContainsKey(temp))
                {
                    num += romanUnique[temp];
                    temp = "";
                    i++;
                }
                else
                {
                    num += romanNormal[s[i]];
                    temp = "";
                }
            }
            else
            {
                num += romanNormal[s[i]];
            }
        }
        return num;
    }
}