using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// 

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
        List<int> lst = A.Cast<int>().ToList(); // this isn't going to be fast.
        lst.Add(0);
        lst.Add(int.MaxValue);
        lst.Sort();            
        for (int i = 0; i< lst.Count; i++){
            if (lst[i] < 0) continue;
            int diff = (lst[i+1]-lst[i]);            
            if (diff > 1) return lst[i] + 1;
            }                
        return 1;
    }
}
