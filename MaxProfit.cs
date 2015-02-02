using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if (A.Length < 2) return 0;
        int min = A[0];
        int prof = 0;    
        for (int i =1; i<A.Length; i++){
            if (A[i] < min) min = A[i];
            else if ((A[i] - min) > prof) prof = A[i] - min;
            }
        return prof;
    }
}
