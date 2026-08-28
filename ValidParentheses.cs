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
                stack.Push(s[i]);
            }

            else
            {
                if (stack.Peek() == dict[s[i]])
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