class Solution {
    public int[][] merge(int[][] intervals) {
               Arrays.sort(intervals, (a, b) -> Integer.compare(a[0], b[0]));

        int i=0;
        int n=intervals.length;
        for(int j=0;j<n;j++){
            if(intervals[i][1]>=intervals[j][0]){
                intervals[i][1]=Math.max(intervals[i][1],intervals[j][1]);
            }
            else{
                i+=1;
                intervals[i]=intervals[j];
            }
        }
        return Arrays.copyOfRange(intervals, 0, i + 1);
    }
}