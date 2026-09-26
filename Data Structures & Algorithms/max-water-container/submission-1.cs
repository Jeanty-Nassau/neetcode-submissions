public class Solution {
    public int MaxArea(int[] heights) {
        var mA = 0;

        var l = 0;
        var r = heights.Length -1;

        while(l<r)
        {
            var cA = (Math.Min(heights[l], heights[r])) * (r-l);
            mA = Math.Max(cA, mA);

            if(heights[l] > heights[r])
                r--;
            else
            {
                l++;
            }
        }

        return mA;
    }
}
