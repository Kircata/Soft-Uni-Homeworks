package com.company;


import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] words = scan.nextLine().split("[ ;:,.!?'-]+");
        String wordToMatch = scan.nextLine();
        int matchCounter = 0;
        for (String word : words){
            if (word.toLowerCase().equals(wordToMatch)){
                matchCounter++;
            }
        }
        System.out.println(matchCounter);
    }
}
