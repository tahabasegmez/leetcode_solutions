/* 
* Array - Hashing
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mem = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int current = nums[i]; 
            int peer = target - current;

            if (mem.ContainsKey(peer)) { // did we see the peer before

                return new int[] { mem[peer], i }; // return peer index and current's index
            }

            if (!mem.ContainsKey(current)) { // we didn't see, add current value as key and its index as value
                mem.Add(current, i);
            }
        }

        return new int[0];
    }
}

/*
You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
*/