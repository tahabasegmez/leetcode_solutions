public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0)
        {
            return false;
        }


        Stack<char> stack = new();
        Dictionary<char, char> dict = new();
        
        dict.Add(')', '('); // O(1)
        dict.Add(']', '['); // O(1)
        dict.Add('}', '{'); // O(1)

        stack.Push('x'); // to avoid Peek() exception

        for (int i=0; i<s.Length; i++) // O(n)
        { 
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]); // O(1)
            }

            else
            {
                if (stack.Peek() == dict[s[i]]) // O(1)
                {
                    stack.Pop(); // O(1)
                    
                }

                else
                {   
                    return false;
                }  
            }
        }

        if (stack.Count == 1) // O(1)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}