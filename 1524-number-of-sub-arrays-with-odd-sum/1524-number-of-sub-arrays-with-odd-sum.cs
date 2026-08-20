public class Solution {
    public int NumOfSubarrays(int[] arr) {
        long ans = 0;
        long odd = 0;
        long even = 1;
        long prefix = 0;

        foreach (int num in arr) {
            prefix += num;

            if (prefix % 2 == 0) {
                ans += odd;
                even++;
            }
            else {
                ans += even;
                odd++;
            }
        }

        return (int)(ans % 1000000007);
    }
}