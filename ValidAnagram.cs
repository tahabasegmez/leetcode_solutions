/* 
* Array - Hashing
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<Rune, int> dict1 = new Dictionary<Rune, int>(); // rune holds unicode; key is letter, value is counter
        Dictionary<Rune, int> dict2 = new Dictionary<Rune, int>();
        dict1 = AddDict(s, ref dict1);
        dict2 = AddDict(t, ref dict2);

        if(dict1.Count != dict2.Count) return false; // same different letter count?
        foreach(var k in dict1.Keys){
            if(!dict2.ContainsKey(k)) return false; // do they contain the same letter?
            if(dict2[k] != dict1[k]) return false; // do the same letter appeared the same number of times?
        }
        return true; // then true
    }
    public Dictionary<Rune, int> AddDict(string s, ref Dictionary<Rune, int> dict){

        foreach(Rune l in s){ // anagram -> angrm a3 n1 g1 r1 m1
            if(dict.ContainsKey(l)){ // seen before -> increment
                dict[l] += 1;
            } else dict.Add(l, 1); // add
        }
        return dict;

    }
}

/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/