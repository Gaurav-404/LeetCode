class Solution {
    public int minRefuelStops(int target, int startFuel, int[][] stations) {
        int minStops=0;
        int currentPosition=startFuel;
        PriorityQueue<Integer> maxHeap=new PriorityQueue<>((a,b)-> b - a);
        for(int[] station :stations){
            int position=station[0];
            int fuel=station[1];
            while(currentPosition<position){
                if(maxHeap.isEmpty()){
                    return -1;
                }
                currentPosition+=maxHeap.poll();
                minStops+=1;
            }
            maxHeap.add(fuel);
        }
        while(currentPosition<target){
            if(maxHeap.isEmpty()){
                return -1;
            }
            currentPosition+=maxHeap.poll();
            minStops+=1;
        }
        return minStops;
    }
}