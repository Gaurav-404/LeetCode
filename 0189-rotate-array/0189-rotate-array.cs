public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        int n=nums.Length;
        Reverse(nums,0,n-k-1);
        Reverse(nums,n-k,n-1);
        Reverse(nums,0,n-1);
    }
    public void Reverse(int[] nums,int start,int end){
        while(start<end){
            (nums[start],nums[end])=(nums[end],nums[start]);
            start++;
            end--;
        }
    }
}