/*
* Dynamic Programming
*/
public class Solution {
    public int ClimbStairs(int n) { 
        if (n == 1) return 1;
        if (n == 2) return 2;

        int[] steps = new int[n + 1];

        // if thequestion asks how distinct ways, or can be redacted into subproblem this may be solved using dp 
        // initialize first k steps manually until find a pattern -> 1st 1 (1), 2nd 2(1+1, 2), 3th 3(1+1+1, 1+2, 2+1), 4th 5(1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 2+2), 5th ....
        // 3th step2 + step1, 4th step3 + step2, 5th .... -> FOUND!
        
        steps[1] = 1;
        steps[2] = 2;
        

        for (int i = 3; i <= n; i++) {
            steps[i] = steps[i - 1] + steps[i - 2];
        }

        return steps[n];
    }
}

/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
 

Constraints:

1 <= n <= 45
*/