public class Solution {
    public int LargestInteger(int[] nums, int k) {
        int ans=-1;
        Dictionary<int,int> frq=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(frq.ContainsKey(nums[i])){
                frq[nums[i]]++;
            }
            else
            frq[nums[i]]=1;
        }
        if(k==1){
            foreach (var item in frq){
                if (item.Value == 1){
                    ans = Math.Max(ans, item.Key);
                }
            }
            return ans;
        }
        if(k==nums.Length){
            int max=int.MinValue;
            for(int i=0;i<nums.Length;i++){
                if(nums[i]>max){
                    max=nums[i];
                }
            }
            return max;
        }
        if(k>1 && k<nums.Length){
            if(frq[nums[0]]==1){
                ans=Math.Max(ans,nums[0]);
            }
            if(frq[nums[nums.Length-1]]==1){
                ans=Math.Max(ans,nums[nums.Length-1]);
            }
            return ans;
        }
        return -1;
    }
}