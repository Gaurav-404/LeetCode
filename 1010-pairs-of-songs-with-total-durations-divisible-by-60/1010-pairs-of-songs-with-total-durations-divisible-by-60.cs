public class Solution {
        public int NumPairsDivisibleBy60(int[] time)
        {
            var counts = new int[60];
            var result = 0;
            foreach (var num in time)
            {
                result += counts[(600 - num) % 60];
                counts[num % 60]++;
            }

            return result;
        }
}