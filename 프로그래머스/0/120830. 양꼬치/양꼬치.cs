using System;

public class Solution {
    public int solution(int n, int k) {
        
        
        int yang = 12000 * n;
        int drink = 2000 * k;
        int discount = n/10 * 2000;
        int total = yang + drink;
        int answer = total - discount;
            
        
        return answer;
    }
}