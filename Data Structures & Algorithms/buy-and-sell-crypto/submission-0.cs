public class Solution {
    public int MaxProfit(int[] prices) {
        //buy low, sell high
        if(prices.Length == 1)
            return 0;

        var l = 0;
        var r = 1;
        var mp = 0;

        while (l<r && r <= prices.Length -1){
            if(prices[r] > prices[l])
            {
                mp = Math.Max(mp, (prices[r] - prices[l]));
                r++;
            }
            else{
                l = r;
                r++;
            }
        }

        return mp;

    }
}
