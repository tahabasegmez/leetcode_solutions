public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hafiza = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int suAnkiSayi = nums[i];
            int arananEs = target - suAnkiSayi;

            if (hafiza.ContainsKey(arananEs)) {

                return new int[] { hafiza[arananEs], i };
            }

            if (!hafiza.ContainsKey(suAnkiSayi)) {
                hafiza.Add(suAnkiSayi, i);
            }
        }

        return new int[0];
    }
}