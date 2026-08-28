public class Solution {
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int maxProfit = 0;

        for (int right = 1; right < prices.Length; right++)
        {
            if (prices[right] < prices[left])
            {
                left = right;          // daha ucuz fiyat bulundu, left'i güncelle
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
            }
        }

        return maxProfit;
    }
}