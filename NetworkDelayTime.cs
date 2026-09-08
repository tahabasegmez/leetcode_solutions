public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        if (k > times.Length) return -1;
        
        int[] dist = new int[n+1];
        Array.Fill(dist, int.MaxValue);

        dist[0] = int.MinValue;

        PriorityQueue<int, int> queue = new();
        queue.Enqueue(k, 0); // next u to explore edges that originate from it
        dist[k] = 0; // dist[u], if it is the third iteration for example, then dist[u] is the shortest path to u from k, which is 0 since k is the starting point

        while (queue.Count > 0) {
            queue.TryDequeue(out int u, out int w);

            foreach (int[] i in times) {
                if (i[0] != u) continue; // looking for edges that originate from u

                if (dist[u] + i[2] < dist[i[1]]) {  // found one, lets compare if dist[v] > dist[u] + w 
                    dist[i[1]] = i[2] + dist[u]; // new path to v from current u costs lower, so update
                    queue.Enqueue(i[1], i[2]); // add this edge (originates from u, goes to neighbors) to priority queue, this will be dequeued later to decide which edge we should proceed.
                }
            }
        }
        dist.Sort(); // there must be more efficient way to get highest cost(weight)
        
        if (dist[dist.Length - 1] == int.MaxValue) return -1; // if at least one node is not accessible, there will be at least one INT_MAX value in the array 
        else return dist[dist.Length - 1];
    }
}