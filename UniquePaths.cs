/*
* Dynamic Programming 2-D
*/

public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] cache = new int[m][]; // i prefer jagged array for dp

        for (int i = 0; i < m; i++)
        {
            cache[i] = new int[n]; 
        }

        // let's start this from finish
        // check right and bottom of the chosen point, sum them up and assign, 
        // that gives us possible paths from this point to the finish
        for (int i = n - 1; i >= 0 ; i--){
            for (int j = m - 1; j >= 0; j--){
                if (j + 1 < m && i + 1 < n){
                    cache[j][i] += cache[j][i+1] + cache[j+1][i];
                }
                else if (j + 1 == m && i + 1 < n){
                    cache[j][i] += cache[j][i+1];
                }
                else if (i + 1 == n && j + 1 < m){
                    cache[j][i] += cache[j+1][i];
                }
                else {
                    cache[j][i] = 1; // give 1 to the finish in order to achieve 1s at the top and left
                }
            }
        }

        return cache[0][0]; // the last sum gives us solution
        
    }
}

/*
There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

The test cases are generated so that the answer will be less than or equal to 2 * 109.

 

Example 1:


Input: m = 3, n = 7
Output: 28
Example 2:

Input: m = 3, n = 2
Output: 3
Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down
 

Constraints:

1 <= m, n <= 100
*/