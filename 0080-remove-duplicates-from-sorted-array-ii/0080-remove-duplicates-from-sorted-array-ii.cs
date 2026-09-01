public class Solution {
    public int RemoveDuplicates(int[] nums) {
      int k=1;
      int count=0;
      for(int i=1;i<nums.Length;i++){
        if(nums[i]!=nums[i-1]){
            count=0;
            nums[k++]=nums[i];
        }
        else{
            count++;
            if(count<=1){
                nums[k++]=nums[i];
            }
        }
      }
      return k;  
    }
}
