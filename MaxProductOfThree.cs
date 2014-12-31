using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        
        int[] maxMin = new int[6];        
        if (A.Length <=6) maxMin = A;
        else {
        maxMin[0] = A[0];
        maxMin[1] = A[1];
        maxMin[2] = A[2];
        maxMin[3] = A[A.Length-3];
        maxMin[4] = A[A.Length-2];
        maxMin[5] = A[A.Length-1];
        }
        int max = int.MinValue;
        for (int i = 0; i<maxMin.Length-2;i++){
            for (int j = i+1; j<maxMin.Length-1;j++){
                for (int k = j+1; k<maxMin.Length;k++){
                    int val = maxMin[i]*maxMin[j]*maxMin[k];
                    if (val> max) max = val;
                    }                        
                }                        
            }                        
    return max;
    }
}
