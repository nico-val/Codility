using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        bool[] check = new bool[X];                        
        int total = X*(X+1)/2;
        for (int i = 0;i<A.Length;i++){
            if (check[A[i]-1] == false)
            {
                total -= A[i];
                check[A[i]-1]=true;
                }        
            if (total == 0) return i;
            }            
        return -1;
    }
}
