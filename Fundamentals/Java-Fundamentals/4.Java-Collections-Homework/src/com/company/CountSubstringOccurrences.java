package com.company;

import java.util.Scanner;

public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        String substringToMatch = scan.nextLine();
        int matchCounter = 0;
        for (int i = 0; i <= text.length() - substringToMatch.length(); i++) {
            String currentSubstring = text.substring(i, i+substringToMatch.length());
            if (currentSubstring.toLowerCase().equals(substringToMatch)){
                matchCounter++;
            }
        }
        System.out.println(matchCounter);
    }
}
