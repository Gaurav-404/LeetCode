public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        List<int> res=new List<int>();
        for(int i=nums.Length-k;i<nums.Length;i++){
            res.Add(nums[i]);
        }
        for(int i=0;i<nums.Length-k;i++){
            res.Add(nums[i]);
        }
        for(int i=0;i<nums.Length;i++){
            nums[i]=res[i];
        }
    }
}