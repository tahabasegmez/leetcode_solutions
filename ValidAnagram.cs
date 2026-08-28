public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<Rune, int> dict1 = new Dictionary<Rune, int>();
        Dictionary<Rune, int> dict2 = new Dictionary<Rune, int>();
        dict1 = AddDict(s, ref dict1);
        dict2 = AddDict(t, ref dict2);

        if(dict1.Count != dict2.Count) return false;
        foreach(var k in dict1.Keys){
            if(!dict2.ContainsKey(k)) return false;
            if(dict2[k] != dict1[k]) return false;
        }
        return true;
    }
    public Dictionary<Rune, int> AddDict(string s, ref Dictionary<Rune, int> dict){

        foreach(Rune l in s){
            if(dict.ContainsKey(l)){
                dict[l] += 1;
            } else dict.Add(l, 1);
        }
        return dict;

    }
}