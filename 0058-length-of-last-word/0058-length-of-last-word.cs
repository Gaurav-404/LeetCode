public class Solution {
    public int LengthOfLastWord(string s) {
        s=s.Trim();
        int n=s.Length;
        int m=s.LastIndexOf(" ");
        String r=s.Substring(m+1);
        return r.Length;
    }
}