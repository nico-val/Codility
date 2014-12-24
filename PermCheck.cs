using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        for(int i = 0;i<A.Length;i++){
            if (A[i] != i+1) return 0;
            }
        return 1;
    }
}
