public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans=new int[nums.Length];
        int prefix=1;
        int suffix=1;
        ans[0]=1;
        for(int i=1;i<nums.Length;i++){
            ans[i]=nums[i-1]*prefix;
            prefix=ans[i];
        }
        for(int i=nums.Length-2;i>=0;i--){
            ans[i]*=suffix*nums[i+1];
            suffix=nums[i+1]*suffix;
        }
        return ans;
    }
}