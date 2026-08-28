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