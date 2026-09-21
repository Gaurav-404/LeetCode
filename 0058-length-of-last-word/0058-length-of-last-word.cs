public class Solution {
    public int LengthOfLastWord(string s) {
        string lastWord = s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Last();
        return lastWord.Length;
    }
}