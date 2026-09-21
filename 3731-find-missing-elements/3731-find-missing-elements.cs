public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        List<int> res=new List<int>();
        int min=int.MaxValue;
        int max=int.MinValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]<min){
                min=nums[i];
            }
            if(nums[i]>max){
                max=nums[i];
            }
        }
        for(int i=min;i<max;i++){
            if(!nums.Contains(i)){
                res.Add(i);
            }
        }
        return res;
    }
}