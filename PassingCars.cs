using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int open = 0;
        int count = 0;
        foreach (int i in A){
            if (i == 0) open++;
            else if (i == 1) count += open;
            }
        if (Math.Abs(count) > 1000000000) return -1;
        else return count;
    }
}
