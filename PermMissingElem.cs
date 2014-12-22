using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {        
        long sum = 0;
        foreach (int i in A) sum += i;
        long totalSum = (long)(A.Length+1)*(long)(A.Length+2)/2;
        return (int)(totalSum - sum);
    }
}
