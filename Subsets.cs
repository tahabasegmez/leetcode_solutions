public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> cur = new();

        void Backtrack(List<int> cur, int head)
        {
            result.Add(new List<int>(cur));
            for (int i = head; i < nums.Length; i++)
            {
                cur.Add(nums[i]);
                Backtrack(cur, i + 1);
                cur.RemoveAt(cur.Count - 1);
            }
        }

        Backtrack(cur, 0);
        return result;
    }
}