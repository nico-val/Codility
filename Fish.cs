using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        Stack<int> downstream = new Stack<int>();
        int survivors = 0;
        for (int i = 0; i<A.Length; i++){
            //If this fish is flowing downstream, push it into the stack
            if (B[i] == 1) downstream.Push(A[i]);
            //If the fish is flowing upstream but there are no downstream fishes ahead, it's a survivor
            if (B[i] == 0 && downstream.Count == 0) survivors++;
            //If the fish is flowing upstream and there are downstream fishes ahead, compare their size.
            //If the upstream fish is bigger than the top of the downstream stack, pop one from it and
            //restart the loop. Otherwise this upstream fish is discarded.
                else if (A[i] > downstream.Peek()) {downstream.Pop();i--;}            
            }
        return downstream.Count + survivors;            
    }
}
