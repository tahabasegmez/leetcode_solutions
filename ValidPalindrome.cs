public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1 || s.IsWhiteSpace()) return true;

        List<int> StrList = new();
        foreach(int c in s){
            if(64<c && c<91) StrList.Add(c+32);
            if((96<c && c<123) || (47<c && c<58)) StrList.Add(c);
        }
        
        for(int i=0; i<StrList.Count; i++){
            if(StrList[i] != StrList[StrList.Count-i-1]) return false;
        }

        return true;
    }
}