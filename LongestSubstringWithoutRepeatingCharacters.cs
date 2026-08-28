public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        Span<int> seenIndex = stackalloc int[128];
        seenIndex.Fill(-1);
        
        int max = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (seenIndex[s[right]] >= left)
            {
                left = seenIndex[s[right]] + 1;
            }

            seenIndex[s[right]] = right; 
            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}