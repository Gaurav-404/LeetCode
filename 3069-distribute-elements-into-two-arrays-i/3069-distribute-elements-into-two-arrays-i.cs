public class Solution {
    public int[] ResultArray(int[] nums) {
        List<int> arr1=new List<int>();
        List<int> arr2=new List<int>();
        arr1.Add(nums[0]);
        arr2.Add(nums[1]);
        int arr1last=nums[0];
        int arr2last=nums[1];
        for(int i=2;i<nums.Length;i++){
            if(arr1last>arr2last){
                arr1.Add(nums[i]);
                arr1last=nums[i];
            }
            else{
                arr2.Add(nums[i]);
                arr2last=nums[i];
            }
        }
        arr1.AddRange(arr2);
        return arr1.ToArray(); 
    }
}