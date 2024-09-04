public class Solution {
    public string AddBinary(string a, string b) {
        string c = "";
        char temp = '0';
        int count = 0;
        if (a.Length < b.Length)
        {
            while (a.Length < b.Length)
            {
                a = temp + a;
            }
        }
        else
        {
            while (b.Length < a.Length)
            {
                b = temp + b;
            }
        }
        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == '1')
            {
                count++;
            }
            if (b[i] == '1')
            {
                count++;
            }
            if (temp == '1')
            {
                count++;
                temp = '0';
            }
            if (count == 3)
            {
                c = '1'.ToString() + c;
                temp = '1';
                count = 0;
                if (i == 0)
                {
                    c = temp.ToString() + c;
                    return c;
                }
            }
            else if (count == 2)
            {
                c = temp.ToString() + c;
                temp = '1';
                count = 0;
                if (i == 0)
                {
                    c = temp.ToString() + c;
                    return c;
                }
            }
            else if (count == 1)
            {
                c = '1'.ToString() + c;
                count = 0;
            }
            else
            {
                c = '0'.ToString() + c;
                count = 0;
            }
        }
        return c;
    }
}