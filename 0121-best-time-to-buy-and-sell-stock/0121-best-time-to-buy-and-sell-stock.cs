public class Solution {
    public int MaxProfit(int[] prices) {
    int minPrice = int.MaxValue;
    int maxProfit = 0;

    foreach (int price in prices) {
        if (price < minPrice) {
            minPrice = price;
        }
        int profit = price - minPrice;
        if (profit > maxProfit) {
            maxProfit = profit;
        }
    }
    
    return maxProfit;
}

}