/* 
* Stacks
*/
public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0)
        {
            return false;
        }


        Stack<char> stack = new();
        Dictionary<char, char> dict = new();
        
        dict.Add(')', '('); 
        dict.Add(']', '['); 
        dict.Add('}', '{'); 

        stack.Push('x'); // to avoid Peek() exception

        for (int i=0; i<s.Length; i++) 
        { 
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]); // O(1)
            }

            else
            {
                if (stack.Peek() == dict[s[i]]) // O(1)
                {
                    stack.Pop(); 
                    
                }

                else
                {   
                    return false;
                }  
            }
        }

        if (stack.Count == 1) 
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}

/* 
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

Example 5:

Input: s = "([)]"

Output: false

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/