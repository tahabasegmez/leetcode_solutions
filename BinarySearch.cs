/*
* Binary Search
*/
public class Solution {
    public int Search(int[] nums, int target) 
    {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
    public int BinarySearch(int[] nums, int start, int end, int target)
    {
        if (start > end){
            return -1;
        }

        int middle = (start + end) / 2;
        
        if (nums[middle] == target) return middle;
        
        else if (target > nums[middle])
        {
            return BinarySearch(nums, middle + 1, end, target);
        }
        else
        {
            return BinarySearch(nums, start, middle - 1, target);
        }
    }
}

/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
 

Constraints:

1 <= nums.length <= 104
-104 < nums[i], target < 104
All the integers in nums are unique.
nums is sorted in ascending order.
*/