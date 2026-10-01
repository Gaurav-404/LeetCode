public class Solution {
    public long[] FindPrefixScore(int[] nums) {
        long[] arr=new long[nums.Length];
        long sum=0;
        int max=nums[0];
        for(int i=0;i<nums.Length;i++){
            if(max<nums[i]) max=nums[i];
            sum+=nums[i]+max;
            arr[i]=sum;
        }
        return arr;
    }
}