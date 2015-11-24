package com.company;


import java.util.Scanner;

public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String firstString = scan.nextLine();
        String secondString = scan.nextLine();
        int sum = getSum(firstString,secondString);
        System.out.println(sum);
    }

    public static int getSum(String firstString, String secondString) {
        int sum = 0;
        if (firstString.length() != secondString.length()){
            int minLength = Math.min(firstString.length(), secondString.length());
            if (firstString.length() > secondString.length()){
                for (int i = 0; i < firstString.length(); i++) {
                    if (i < minLength){
                        sum+= firstString.charAt(i) * secondString.charAt(i);
                    }
                    else{
                        sum+= firstString.charAt(i);
                    }

                }
            }
            else{
                for (int i = 0; i < secondString.length(); i++) {
                    if (i < minLength){
                        sum+= firstString.charAt(i) * secondString.charAt(i);
                    }
                    else{
                        sum+= secondString.charAt(i);
                    }
                }
            }
        }
        else{
            for (int i = 0; i < firstString.length(); i++) {
                sum+= firstString.charAt(i) * secondString.charAt(i);
            }
        }
        return sum;
    }
}
