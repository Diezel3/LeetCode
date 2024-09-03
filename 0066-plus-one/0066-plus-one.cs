public class Solution {
    public int[] PlusOne(int[] digits) {
        int temp = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                if (i == 0)
                {
                    digits[0] = 0;
                    int[] newDigits = new int[digits.Length + 1];
                    newDigits[0] = 1;
                    for (int k = 1; k < newDigits.Length; k++)
                    {
                        newDigits[k] = digits[k-1];
                        return newDigits;
                    }
                }
                else
                {
                    digits[i] = 0;
                    continue;
                }

            }
            else
            {
                temp = digits[i];
                temp++;
                digits[i] = temp;
                break;
            }
        }
        return digits;
    }
}