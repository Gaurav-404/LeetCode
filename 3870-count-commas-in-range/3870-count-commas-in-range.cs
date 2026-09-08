public class Solution {
    public int CountCommas(int n) {
        int count=0;
        int num=n;
        while(n!=0){
            n=n/10;
            count++;
        }
        if(count<4){
            return 0;
        }
        else{
            return (num-1000)+1;
        }
    }
}