public class Solution {
    public string Multiply(string num1, string num2) {
        string product = "";
        if (num1 == "0" || num2 == "0")
        {
            product = "0";
            return product;
        }
        else
        {
            int[] productArray = new int[num1.Length + num2.Length];
            string numerator;
            string denominator;
            int numeratorValue;
            int denominatorValue;
            int carry = 0;
            int productArrayIndexCount = productArray.Length - 1;
            int productArrayIndex;
            if (num1.Length > num2.Length)
            {
                numerator = num1;
                denominator = num2;
            }
            else
            {
                numerator = num2;
                denominator = num1;
            }
            for (int i = denominator.Length - 1; i >= 0; i--)
            {
                denominatorValue = denominator[i] - '0';
                productArrayIndex = productArrayIndexCount;
                carry = 0;
                for (int k = numerator.Length - 1; k >= 0; k--)
                {
                    numeratorValue = numerator[k] - '0';
                    int tempProduct = (denominatorValue * numeratorValue) + carry + productArray[productArrayIndex];
                    productArray[productArrayIndex] = tempProduct % 10;
                    carry = tempProduct / 10;
                    productArrayIndex--;
                }
                // Add any remaining carry to the next position
                if (carry > 0)
                {
                    productArray[productArrayIndex] += carry;
                }
                productArrayIndexCount--;
            }
            int j = 0;
            if (productArray[j] == 0)
            {
                j = 1;
            }
            for (int i = j; i < productArray.Length; i++)
            {
                product += Convert.ToString(productArray[i]);
            }
            return product;
        }
    }
}