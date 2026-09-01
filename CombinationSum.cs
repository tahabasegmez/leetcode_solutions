public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> cur = new();
        int sum = 0;

        void Backtrack(int head, List<int> cur)
        {
            for (int i = head; i < candidates.Length; i++)
            {
            
                if (sum > target) break;
                if (sum == target) 
                {
                    result.Add(new List<int>(cur)); 
                    break;
                }
                
                cur.Add(candidates[i]);
                sum += candidates[i];

                Backtrack(i, cur);

                cur.RemoveAt(cur.Count - 1);
                sum -= candidates[i];
            }
        }
        
        Backtrack(0, cur);
        return result;
    }
}
