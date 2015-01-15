using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        
        int i = 0;        
        Stack<int> s = new Stack<int>();
        int blocks = 0;
        
        while(i < H.Length){
            if(s.Count > 0){
                if(H[i] == s.Peek()) {s.Push(H[i]);i++;}
                else if(H[i] > s.Peek()) {s.Push(H[i]);blocks++;i++;}
                else if(H[i] < s.Peek()) {s.Pop();}
                }            
            else {s.Push(H[i]);if(H[i]>0) blocks++;i++;}
            }
        return blocks;
    }
}
