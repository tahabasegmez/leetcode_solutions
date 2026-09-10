public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int length = points.Length;

        PriorityQueue<int, int> queue = new();
        bool[] visited = new bool[length];

        int[] minDistToPoint = new int[length];
        Array.Fill(minDistToPoint, int.MaxValue);

        queue.Enqueue(0, 0);
        minDistToPoint[0] = 0; // don't wanna add to queue if a lower cost is already found to that point.

        int sum = 0;
        int connectedCount = 0; 

        while (queue.Count > 0) {
            queue.TryDequeue(out int curIdx, out int dist);

            if (visited[curIdx]) continue;

            visited[curIdx] = true;
            sum += dist;
            connectedCount++;

            if (connectedCount == length) break;

            int curX = points[curIdx][0];
            int curY = points[curIdx][1];

            for (int i = 0; i < length; i++) {
                if (visited[i] || curIdx == i) continue;

                dist = Math.Abs(curX - points[i][0]) + Math.Abs(curY - points[i][1]);
                
                if (dist < minDistToPoint[i]) {
                    minDistToPoint[i] = dist;
                    queue.Enqueue(i, dist);
                }
            }
        }

        return sum;
    }
}