using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        int count = 0;        
        if (A.Length > 0) count = 1;
        if (A.Length > 1){        
        for (int i = 0; i<A.Length-1;i++){
            if (A[i] != A[i+1]) count++;
            }
        }
        return count;
    }
}
