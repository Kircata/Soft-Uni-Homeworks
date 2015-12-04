package com.company;


import java.util.Scanner;

public class _SumCards {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] cards = scan.nextLine().split("\\s");
        int sum = 0;
        for (int index = 0; index < cards.length;) {
            char currentChar = cards[index].charAt(0);
            int currentFace = getFace(currentChar);
            if (index != cards.length-1
                    && currentChar == cards[index+1].charAt(0)){
                index++;
                int currentSum = 0;
                currentSum+=currentFace;
                while(index < cards.length
                        && currentChar == cards[index].charAt(0)){
                    currentSum+=currentFace;
                    index++;
                }
                sum+= currentSum * 2;
            } else {
                sum+=currentFace;
                index++;
            }

        }
        System.out.println(sum);
    }
    public static int getFace(char currentChar){
        int currentFace=0;
        switch (currentChar){
            case '2': currentFace=2; break;
            case '3': currentFace=3; break;
            case '4': currentFace=4; break;
            case '5': currentFace=5; break;
            case '6': currentFace=6; break;
            case '7': currentFace=7; break;
            case '8': currentFace=8; break;
            case '9': currentFace=9; break;
            case '1': currentFace=10; break;
            case 'J': currentFace=12; break;
            case 'Q': currentFace=13; break;
            case 'K': currentFace=14; break;
            case 'A': currentFace=15; break;
        }
        return currentFace;
    }
}

