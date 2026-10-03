/* 
* Two Pointers
*/
public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1 || s.IsWhiteSpace()) return true;

        List<int> StrList = new();
        foreach(int c in s){ // following steps ignores whitespace and punctuation
            if(64<c && c<91) StrList.Add(c+32); // if upper case convert to lower and add
            if((96<c && c<123) || (47<c && c<58)) StrList.Add(c); // add lower case and numbers directly
        }
        
        for(int i=0; i<StrList.Count; i++){ // didn't end early, both pointers trace whole string, can be optimized
            if(StrList[i] != StrList[StrList.Count-i-1]) return false; // tracing the string starting both ends
        }

        return true;
    }
}

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
*/