public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        PriorityQueue<int, int> queue = new();
        bool[] visited = new bool[points.Length];

        queue.Enqueue(0, 0);
        int sum = 0;
        int connectedCount = 0; 

        while (queue.Count > 0) {
            queue.TryDequeue(out int curIdx, out int c);

            if (visited[curIdx]) continue;

            visited[curIdx] = true;
            sum += c;
            connectedCount++;

            if (connectedCount == points.Length) break;

            int curX = points[curIdx][0];
            int curY = points[curIdx][1];

            for (int i = 0; i < points.Length; i++) {
                if (visited[i] || curIdx == i) continue;

                int dist = Math.Abs(curX - points[i][0]) + Math.Abs(curY - points[i][1]);
                queue.Enqueue(i, dist);
            }
        }

        return sum;
    }
}