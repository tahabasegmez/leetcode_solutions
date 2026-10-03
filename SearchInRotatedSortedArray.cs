/* 
* Binary Search
*/

public class Solution {
    public int Search(int[] nums, int target) 
    {
        return ModifiedBinarySearch(nums, 0, nums.Length - 1, target);
    }

    /*
    * there are 3 possibilities:
    *   1- left side is normal but right side is not: 4,5,6,7,8,9,1,2,3
    *   2- left side is not normal but right side is: 7,8,9,1,2,3,4,5,6
    *   3- perfectly sorted: 1,2,3,4,5,6,7,8,9
    */
    public int ModifiedBinarySearch(int[] n, int s, int e, int t) // dividing and finding the normal side that binary search can work properly
    {
        if (s > e) {
            return -1;
        }

        int m = s + (e - s) / 2;
        
        if (n[m] == t) return m;

        if (n[s] <= n[m]) // if the left side is normal
        {

            if (t >= n[s] && t < n[m]) // if the target is between start end middle, which is normal
            {
                return ModifiedBinarySearch(n, s, m - 1, t); 
            }
            else // else look to the right side
            {
                return ModifiedBinarySearch(n, m + 1, e, t); 
            }
        }

        else // if the left side is not normal, the right side should be normal
        {

            if (t > n[m] && t <= n[e]) // if the target is between, which is normal
            {
                return ModifiedBinarySearch(n, m + 1, e, t); 
            }
            else // look to the left side
            {
                return ModifiedBinarySearch(n, s, m - 1, t); 
            }
        }
    }
}
/*
There is an integer array nums sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly left rotated at an unknown index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].

Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
Example 3:

Input: nums = [1], target = 0
Output: -1
 

Constraints:

1 <= nums.length <= 5000
-104 <= nums[i] <= 104
All values of nums are unique.
nums is an ascending array that is possibly rotated.
-104 <= target <= 104
*/