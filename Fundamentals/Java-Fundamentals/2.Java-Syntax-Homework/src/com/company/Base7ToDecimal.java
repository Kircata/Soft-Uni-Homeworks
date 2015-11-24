package com.company;


import java.util.Scanner;

public class Base7ToDecimal {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int numberInBaseSeven = scan.nextInt();
        String numberAsString = Integer.toString(numberInBaseSeven);
        int currentPow = 0;
        int numberInDecimal=0;
        for (int index = numberAsString.length()-1; index >=0 ; index--, currentPow++) {
            int currentDigit = Integer.parseInt(Character.toString(numberAsString.charAt(index)));
            numberInDecimal+= currentDigit * Math.pow(7, currentPow);
        }
        System.out.println(numberInDecimal);
    }
}
