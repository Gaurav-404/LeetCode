public class Solution {
    public int MaxProfit(int[] prices) {
        int bestBuy=prices[0];
        int maxProfit=0;
        for(int i=1;i<prices.Length;i++){
            if(prices[i]>bestBuy){
                maxProfit=Math.Max(maxProfit,prices[i]-bestBuy);
            }
            bestBuy=Math.Min(prices[i],bestBuy);
        }
        return maxProfit;
    }
}