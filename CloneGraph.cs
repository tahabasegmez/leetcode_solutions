/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;

        Node[] cloneContainer = new Node[101];

        Queue<Node> queue = new(); // BFS
        queue.Enqueue(node); // BFS

        cloneContainer[node.val] = new Node(node.val);

        Node cur; // BFS

        while (queue.Count != 0) {
            cur = queue.Dequeue();

            foreach (Node n in cur.neighbors) {  // BFS

                if (cloneContainer[n.val] == null) {
                    queue.Enqueue(n); // BFS
                    cloneContainer[n.val] = new Node(n.val);
                }
                cloneContainer[cur.val].neighbors.Add(cloneContainer[n.val]);
            }
        }

        return cloneContainer[node.val];
    }
}