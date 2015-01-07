using System;
using System.Collections.Generic;
using System.Linq;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        List<char> list = new List<char>();
        foreach (char c in S){            
            if (c == '(') list.Add(c);            
            else if (c == ')' && list.Count == 0) return 0;
            else if (c == ')' && list[list.Count - 1] == '(') list.RemoveAt(list.Count-1);
            else return 0;
            }
        if (list.Count == 0) return 1;
        else return 0; 
        }
}
