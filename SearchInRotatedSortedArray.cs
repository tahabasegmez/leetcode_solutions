public class Solution {
    public int Search(int[] nums, int target) 
    {
        return ModifiedBinarySearch(nums, 0, nums.Length - 1, target);
    }

    public int ModifiedBinarySearch(int[] n, int s, int e, int t)
    {
        if (s > e) {
            return -1;
        }

        int m = s + (e - s) / 2;
        
        if (n[m] == t) return m;

        if (n[s] <= n[m])
        {

            if (t >= n[s] && t < n[m])
            {
                return ModifiedBinarySearch(n, s, m - 1, t); 
            }
            else
            {
                return ModifiedBinarySearch(n, m + 1, e, t); 
            }
        }

        else
        {

            if (t > n[m] && t <= n[e])
            {
                return ModifiedBinarySearch(n, m + 1, e, t); 
            }
            else
            {
                return ModifiedBinarySearch(n, s, m - 1, t); 
            }
        }
    }
}