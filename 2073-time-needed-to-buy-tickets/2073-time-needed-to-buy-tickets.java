class Solution {
    public int timeRequiredToBuy(int[] tickets, int k) {
        int n=tickets.length;
        int time=0;
        while(tickets[k]>0){
            for(int i=0;i<n;i++){
                if(tickets[i]>0){
                    time+=1;
                    tickets[i]-=1;
                }
                if(tickets[k]==0 && i==k){
                    return time;
                }
            }
        }
        return time;
    }
}