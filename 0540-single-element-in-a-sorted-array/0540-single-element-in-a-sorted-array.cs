public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int start=0;
        int n=nums.Length;
        int end=nums.Length-1;
        if(nums.Length==1){
            return nums[0];
        }
        while(end>=start){
            int mid=start+(end-start)/2;
            if(mid==0 && nums[0]!=nums[1]){
                return nums[0];
            }
            if(mid==n-1 && nums[n-1]!=nums[n-2]){
                return nums[n-1];
            }
            if(nums[mid]!=nums[mid+1] && nums[mid]!=nums[mid-1]){
                return nums[mid];
            }
            if(mid%2==0){
                if(nums[mid]==nums[mid-1]){
                    end=mid-1;
                }
                else{
                    start=mid+1;
                }
            }
            else{
                if(nums[mid]==nums[mid-1]){
                    start=mid+1;
                }
                else{
                    end=mid-1;
                }
            }
        }
        return -1;

    }
}