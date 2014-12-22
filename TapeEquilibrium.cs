using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        long totalSum = 0;
        long leftSum = 0;
        long diff = long.MaxValue;
        foreach (int i in A) totalSum += i;
        for (int j = 0; j< A.Length-1; j++) {
            leftSum += A[j];
            if (Math.Abs((totalSum-2*leftSum))<diff) diff =Math.Abs(totalSum-2*leftSum);
            
            }
            
            return (int) diff;
    }
}