package com.company;
 
 
import java.util.Scanner;
 
public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String firstWord = scan.nextLine();
        String secondWord = scan.nextLine();
        System.out.println(areExchangeable(firstWord,secondWord));
 
    }
    public static boolean areExchangeable(String firstString, String secondString){
        boolean areExchangeable = true;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < firstString.length(); i++) {
            char currentLetter = firstString.charAt(i);
            if (sb.toString().contains(Character.toString(currentLetter))){
                int indexOfLetter = firstString.indexOf(currentLetter);
                if(secondString.charAt(indexOfLetter) != secondString.charAt(i)){
                    areExchangeable = false;
                    break;
                }
            }
            sb.append(currentLetter);
        }
        return areExchangeable;
    }
}
