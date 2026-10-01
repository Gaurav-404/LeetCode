public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        long[] arr=new long[(n*(n+1))/2];
        int k=0;
        for(int i=0;i<n;i++){
            long sum=0;
            for(int j=i;j<n;j++){
                sum+=nums[j];
                arr[k++]=sum;
            }
        }
        arr.Sort();
        const int MOD = 1000000007;
        long res = 0;

        for (int i = left - 1; i < right; i++) {
            res = (res + arr[i]) % MOD;
        }

        return (int)res;
    }
}