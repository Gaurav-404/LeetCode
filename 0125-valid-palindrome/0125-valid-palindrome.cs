public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length==0){
            return true;
        }
        int start=0;
        int end=s.Length-1;
        while(start<=end){
            char currStart=s[start];
            char currEnd=s[end];
            if(!char.IsLetterOrDigit(currStart)){
                start++;
            }
            else if(!char.IsLetterOrDigit(currEnd)){
                end--;
            }
            else if(char.ToLower(currStart) != char.ToLower(currEnd)){
                return false;
            }
            else
            {
                start++;
                end--;
            }
        }
        return true;
    }
}