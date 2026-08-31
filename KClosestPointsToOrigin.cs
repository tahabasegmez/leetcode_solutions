// Min-Heap implementation
public class Solution {
    public int[][] KClosest(int[][] points, int k) 
    {
        // guard

        int length = points.Length;

        BuildHeap(points, length);
        

        int[][] ret = new int[k][];

        for (int i = 0; i < k; i++)
        {
            ret[i] = new int[2];
            ret[i] = Pop(points, ref length);
        }

        return ret;
    }

    public static int[] Pop(int[][] arr, ref int length)
    {
        int[] max = arr[0];
        length--;                    
        arr[0] = arr[length];        
        Heapify(arr, length, 0);    
        return max;
    }

    public static double Euclidean(double i, double y)
    {
        return Math.Sqrt(Math.Pow(i, 2) + Math.Pow(y, 2));
    }

    public static void Heapify(int[][] arr, int n, int i)
    {
        int smallest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        double smallestD = Euclidean(arr[smallest][0], arr[smallest][1]);

        if (left < n)
        {
            double leftD = Euclidean(arr[left][0], arr[left][1]);
            if (leftD < smallestD)      // ← "<" oldu
            {
                smallest = left;
                smallestD = leftD;
            }
        }

        if (right < n)
        {
            double rightD = Euclidean(arr[right][0], arr[right][1]);
            if (rightD < smallestD)     // ← "<" oldu
            {
                smallest = right;
                smallestD = rightD;
            }
        }

        if (smallest != i)
        {
            int[] swap = arr[i];
            arr[i] = arr[smallest];
            arr[smallest] = swap;

            Heapify(arr, n, smallest);
        }
    }

    public static void BuildHeap(int[][] arr, int length)
    {
        int startIdx = length / 2 - 1;

        for (; startIdx>=0; startIdx--)
        {
            Heapify(arr, length, startIdx);
        }
    }
}