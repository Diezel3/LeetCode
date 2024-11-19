public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1) 
        return 0;
        
        int minPrice = prices[0];
        int profit = 0;
        
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int currentProfit = prices[i] - minPrice;
                if (currentProfit > profit)
                {
                    profit = currentProfit;
                }
            }
        }
        return profit;
    }
}