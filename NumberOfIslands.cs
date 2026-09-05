public class Solution {
    public int NumIslands(char[][] grid) {
        // BFS implementation of the problem
        if (grid.Length == 1 && grid[0].Length == 1 && grid[0][0] == '1') return 1;

        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

        int rL = grid.Length;
        int cL = grid[0].Length;

        int r = 0;
        int c = 0;

        int islandCounter = 0;
        
        bool IsValid(int r, int c) {
            return  r < rL &&
                    r > -1 &&
                    c < cL &&
                    c > -1 && 
                    !(grid[r][c] == '0');
        }

        for (int i = 0; i < rL; i++) {
            for (int j = 0; j < cL; j++) {
                if (!(grid[i][j] == '0') && grid[i][j] == '1') {
                    islandCounter++;
                    grid[i][j] = '0';
                    queue.Enqueue((i, j));
                    r = i;
                    c = j;
                    while (queue.Count > 0) {
                        var location = queue.Dequeue();
                        r = location.r;
                        c = location.c;

                        if (IsValid(r - 1, c)) {
                            queue.Enqueue((r - 1, c));
                            grid[r - 1][c] = '0';
                        }
                        if (IsValid(r, c - 1)) {
                            queue.Enqueue((r, c - 1));
                            grid[r][c - 1] = '0';
                        }
                        if (IsValid(r + 1, c)) {
                            queue.Enqueue((r + 1, c));
                            grid[r + 1][c] = '0';
                        }
                        if (IsValid(r, c + 1)) {
                            queue.Enqueue((r, c + 1));
                            grid[r][c + 1] = '0';
                        }
                    }
                }
            }
        }

        return islandCounter;
    }
}

