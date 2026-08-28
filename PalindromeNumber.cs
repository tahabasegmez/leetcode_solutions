public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        List<int> list = ToList(x);
        if (list.Count == 1) return true;
        for (int i = 0; i < list.Count / 2; i++) {
            if (list[i] != list[list.Count-1-i]){
                return false;
            }
        }
        return true;
    }

    public List<int> ToList(int x) {
        List<int> list = new();
        while(x>0) {
            list.Add(x%10);
            x = (int)(x/10);
        }
        return list;
    }
}