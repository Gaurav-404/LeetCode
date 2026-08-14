public class Solution {
    public int MaxDistance(int[] colors) {
        int maxDiff=0;
        int l=0;
        int r=colors.Length-1;
        while(r>l){
            if(colors[l]==colors[r]){
                r--;
            }
            else{
                maxDiff=Math.Max(maxDiff,r-l);
                l++;
                r=colors.Length-1;
            }
        }
        return maxDiff;
    }
}