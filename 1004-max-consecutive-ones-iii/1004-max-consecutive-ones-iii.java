class Solution {
    public int longestOnes(int[] nums, int k) {
        int n=nums.length;
        int len=0;
        for(int i=0;i<n;i++){
            int z=0;
            for(int j=i;j<n;j++){
                if(nums[j]==0){
                    z++;
                }
                if(z>k){
                    break;
                }
                 len=Math.max(len,j-i+1);
            }
           

        }
        return len;
    }
}