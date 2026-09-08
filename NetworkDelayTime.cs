public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        if (k > times.Length) return -1;
        
        int[] dist = new int[n+1];
        Array.Fill(dist, int.MaxValue);

        dist[0] = int.MinValue;

        PriorityQueue<int, int> queue = new();
        queue.Enqueue(k, 0); // next u to explore edges that originate from it
        dist[k] = 0; // dist[u]

        while (queue.Count > 0) {
            queue.TryDequeue(out int u, out int w);

            foreach (int[] i in times) {
                if (i[0] != u) continue; // looking for edges that originate from u

                if (dist[u] + i[2] < dist[i[1]]) {  // found one, lets compare if dist[v] > dist[u] + w 
                    dist[i[1]] = i[2] + dist[u]; // new path to v from current u costs lower, so update
                    queue.Enqueue(i[1], i[2]); // will be going to v in the future, add this edge with its weight
                }
            }
        }
        dist.Sort(); // there must be more efficient way to get highest cost(weight)
        
        if (dist[dist.Length - 1] == int.MaxValue) return -1; // if at least one node is not accessible, there will be at least one INT_MAX value in the array 
        else return dist[dist.Length - 1];
    }
}