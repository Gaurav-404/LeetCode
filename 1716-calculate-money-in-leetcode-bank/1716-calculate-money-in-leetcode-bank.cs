public class Solution {
    public int TotalMoney(int n) {
        int total=0;
        for(int day=1;day<=n;day++){
            int week=(day-1)/7;
            int dayOfWeek=(day-1)%7;
            int res=week+1+dayOfWeek;
            total+=res;
        }
        return total;
    }
}