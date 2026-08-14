public class Solution {
    public int MaxDistance(int[] colors) {
        int maxDiff=0;
        for(int i=0;i<colors.Length;i++){
            for(int j=i+1;j<colors.Length;j++){
                if(colors[i]!=colors[j]){
                    int diff=Math.Abs(j-i);
                    maxDiff=Math.Max(maxDiff,diff);
                }
            }
        }
        return maxDiff;
    }
}