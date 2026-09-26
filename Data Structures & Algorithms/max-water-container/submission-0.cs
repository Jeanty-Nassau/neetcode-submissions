public class Solution {
    public int MaxArea(int[] heights) {
        var mA = 0;

        var l = 0;
        var r = heights.Length -1;

        while(l<r)
        {
            var minHeight = Math.Min(heights[l], heights[r]);
            var width = r - l;
            var cA = minHeight * width; //l*w
            mA = Math.Max(cA, mA);

            if(minHeight == heights[r])
                r--;
            else
            {
                l++;
            }
        }

        return mA;
    }
}
