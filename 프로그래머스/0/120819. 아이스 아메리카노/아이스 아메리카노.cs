using System;

public class Solution {
    public int[] solution(int money) {
        
        int cups = money / 5500;
        int changes = money % 5500;
        int[] answer = new int[] {cups , changes};
        return answer;
    }
}