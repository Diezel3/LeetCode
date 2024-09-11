public class Solution {
    public int MyAtoi(string s) {
        // Step 1: Trim whitespace
        s = s.Trim();

        // Step 2: Handle empty input after trimming
        if (s.Length == 0) return 0;

        // Step 3: Initialize variables
        int index = 0, sign = 1, result = 0;

        // Step 4: Handle signs
        if (s[index] == '+' || s[index] == '-') {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }

        // Step 5: Convert digits to an integer
        while (index < s.Length && s[index] >= '0' && s[index] <= '9') {
            int digit = s[index] - '0';

            // Step 6: Handle overflow and underflow
            if (result > (Int32.MaxValue - digit) / 10) {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        // Step 7: Apply the sign and return the result
        return result * sign;
    }
}
