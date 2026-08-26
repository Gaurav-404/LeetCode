public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int first=FirstOcc(nums,target);
        int last=LastOcc(nums,target);
        return new int[]{first,last};
    }
   private int FirstOcc(int[] nums,int target){
        int left=0;
        int ans=-1;
        int right=nums.Length-1;
        while(left<=right){
           int mid=left+(right-left)/2;
            if(nums[mid]==target){
                ans=mid;
                right=mid-1;
            }
            else if(nums[mid]<target){
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }
        return ans;
    }
    private int LastOcc(int[] nums,int target){
        int left=0;
        int ans=-1;
        int right=nums.Length-1;
        while(left<=right){
           int mid=left+(right-left)/2;
            if(nums[mid]==target){
                ans=mid;
                left=mid+1;
            }
            else if(nums[mid]<target){
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }
        return ans;
    }
}