class Solution:
    def validateStackSequences(self, pushed: List[int], popped: List[int]) -> bool:
        j=0
        i=0
        k=0
        for k in range(len(pushed)):
            pushed[i]=pushed[k]
            i+=1
            while i>0 and pushed[i-1]==popped[j]:
                
                i-=1
                j+=1
        return i==0
            