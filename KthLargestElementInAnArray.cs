public class Solution {
    public int FindKthLargest(int[] nums, int k) 
    {
        int max = 0;
        int length = nums.Length;
        int comp = 0;

        BuildHeap(nums, ref length);

        for (int i = 0; i < k; i++)
        {
            max = Pop(nums, ref length);
            length--;    
        }
        
        return max;
    }

    public static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;          
        int l = 2 * i + 1;    
        int r = 2 * i + 2;    


        if (l < n && arr[l] > arr[largest])
        {
            largest = l;
        }

        if (r < n && arr[r] > arr[largest])
        {
            largest = r;
        }

        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, n, largest);
        }
    }

    public static void BuildHeap(int[] arr, ref int length)
    {
        int n = length;

        int startIdx = (n / 2) - 1;

        for (int i = startIdx; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
    }

    public static int Pop(int[] arr, ref int length)
    {
        int max = arr[0];
        arr[0] = arr[length - 1];
        Heapify(arr, length, 0);
        return max;
    }
}