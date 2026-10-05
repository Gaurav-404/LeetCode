class Solution {
    public int lengthOfLIS(int[] nums) {
    int n=nums.length;
    int[] arr=new int[n];
    for(int i=0;i<n;i++){
        for(int j=i-1;j>=0;j--){
            if(nums[j]<nums[i]){
            arr[i]=Math.max(arr[i],arr[j]);
        }
    }
    arr[i]+=1;
    }
    int h=1;
    for(int l : arr){
        if(l>h){
            h=l;
        }
    }
    return h;
}
}