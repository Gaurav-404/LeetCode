public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int lastIdx=nums1.Length-1;
        while(m>0 && n>0){
            if(nums2[n-1]>=nums1[m-1]){
                nums1[lastIdx]=nums2[n-1];
                n--;
            }
            else{
                nums1[lastIdx]=nums1[m-1];
                m--;
            }
            lastIdx--;
        }
        while(n>0){
            nums1[lastIdx]=nums2[n-1];
            n--;
            lastIdx--;
        }
    }
}